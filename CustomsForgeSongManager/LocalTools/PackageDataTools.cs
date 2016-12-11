﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RocksmithToolkitLib.DLCPackage;
using RocksmithToolkitLib.Extensions;
using RocksmithToolkitLib.Xml;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using RocksmithToolkitLib.PsarcLoader;
using RocksmithToolkitLib;
using RocksmithToolkitLib.DLCPackage.Manifest2014;
using System.Reflection;

namespace CustomsForgeSongManager.LocalTools
{
    // TODO: maybe think about creating Generic Repair methods
    // SongManager repairs and Bulk Repairs are using very similar methods
    // these methods could be made generic and moved into a 'RepairTools' class.
    static class PackageDataTools
    {
        #region Package Info
        public static DLCPackageData AddMsgToPackageComment(this DLCPackageData packageData, string msg)
        {
            var arrIdComment = packageData.ToolkitInfo.PackageComment;
            if (String.IsNullOrEmpty(arrIdComment))
                arrIdComment = msg;
            else if (!arrIdComment.Contains(msg))
                arrIdComment = arrIdComment + " " + msg;

            packageData.ToolkitInfo.PackageComment = arrIdComment;

            return packageData;
        }

        public static DLCPackageData AddDefaultPackageVersion(this DLCPackageData packageData)
        {
            if (String.IsNullOrEmpty(packageData.ToolkitInfo.PackageVersion))
                packageData.ToolkitInfo.PackageVersion = "1";
            else
                packageData.ToolkitInfo.PackageVersion = packageData.ToolkitInfo.PackageVersion.GetValidVersion();

            return packageData;
        }

        public static DLCPackageData ValidatePackageDataName(this DLCPackageData packageData)
        {
            packageData.Name = packageData.Name.GetValidKey();

            return packageData;
        }

        public static Song2014 ValidateData(this Song2014 songXml, DLCPackageData packageData)
        {
            songXml.AlbumYear = packageData.SongInfo.SongYear.ToString().GetValidYear();
            songXml.ArtistName = packageData.SongInfo.Artist.GetValidAtaSpaceName();
            songXml.Title = packageData.SongInfo.SongDisplayName.GetValidAtaSpaceName();
            songXml.AlbumName = packageData.SongInfo.Album.GetValidAtaSpaceName();
            songXml.ArtistNameSort = packageData.SongInfo.ArtistSort.GetValidSortableName();
            songXml.SongNameSort = packageData.SongInfo.SongDisplayNameSort.GetValidSortableName();
            songXml.AlbumNameSort = packageData.SongInfo.AlbumSort.GetValidSortableName();
            songXml.AverageTempo = Convert.ToSingle(packageData.SongInfo.AverageTempo.ToString().GetValidTempo());

            return songXml;
        }
        #endregion

        #region Tone Fixing
        public static DLCPackageData GetDataWithFixedTones(string srcFilePath)
        {

            var packageData = new DLCPackageData();
            var fnameWithoutExt = Path.GetFileNameWithoutExtension(srcFilePath);
            Platform platform = Packer.GetPlatform(srcFilePath);
            string unpackedDir = Path.Combine(Path.GetTempPath(), String.Format("{0}_{1}", fnameWithoutExt, platform.platform));

            string songVersion = string.Empty, songName = string.Empty;
            var psarcOld = new PsarcPackager();

            try
            {
                // using (var psarcOld = new PsarcPackager())
                packageData = psarcOld.ReadPackage(srcFilePath);
            }
            catch (InvalidDataException ex)
            {
                if (ex.Message.ToString().Contains("EOF"))
                {
                    var field = typeof(PsarcPackager).GetField("packageDir", BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance);
                    var workingDir = field.GetValue(psarcOld).ToString();

                    //packageData = DLCPackageData.LoadFromFolder(workingDir, platform, platform);

                    //foreach (var arr in packageData.Arrangements)
                    //    FixMissingTonesInXML(arr.SongXml.File);

                    foreach (var arr in Directory.EnumerateFiles(workingDir, "*.xml", SearchOption.AllDirectories))
                    {
                        if (!arr.ToLower().Contains("vocals") && !arr.ToLower().Contains("showlights"))
                            FixMissingTonesInXML(arr);
                    }

                    packageData = DLCPackageData.LoadFromFolder(workingDir, platform, platform);
                }
            }

            return packageData;
        }

        public static void FixMissingTonesInXML(string xmlPath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText(xmlPath));

            var songNode = xmlDoc.SelectSingleNode("//song");
            var ebeatsNode = songNode.SelectSingleNode("//ebeats");
            var tonesNode = xmlDoc.CreateElement("tones");
            tonesNode.SetAttribute("count", "0");

            songNode.InsertAfter(tonesNode, ebeatsNode);

            xmlDoc.Save(xmlPath);
        }
        #endregion
    }
}
