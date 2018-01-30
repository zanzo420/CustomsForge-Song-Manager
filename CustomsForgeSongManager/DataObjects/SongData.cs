﻿using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;
using GenTools;
using DataGridViewTools;
using System.Collections.Generic;
using System.ComponentModel;

// DO NOT USE RESHAPER TO SORT THIS CLASS -- HAND SORT ONLY

namespace CustomsForgeSongManager.DataObjects
{
    [Obfuscation(Exclude = false, Feature = "-rename")]
    public enum SongDataStatus : byte
    {
        None = 0,
        UpToDate = 1,
        OutDated = 2,
        NotFound = 3
    }

    [Obfuscation(Exclude = false, Feature = "-rename")]
    public enum SongTaggerStatus : byte
    {
        [XmlEnum("0")]
        False = 0,
        [XmlEnum("1")]
        True = 1,
        [XmlEnum("2")]
        ODLC = 2
    }

    // TODO: get custom filter to work with Enums, i.e. p.PropertyType.IsEnum
    [Obfuscation(Exclude = false, Feature = "-rename")]
    public enum RepairStatus : byte
    {
        NotRepaired = 0,
        Repaired = 1,
        RepairedDD = 2,
        RepairedMaxFive = 3,
        RepairedDDMaxFive = 4,
        ODLC = 5,
        Unknown = 6
    }

    // only essential data should be saved to the XML songinfo file (NO BLOAT)
    // NOTE: custom object order here determines order of elements in the xml file
    [Serializable]
    public class SongData : NotifyPropChangedBase
    {
        //ver 1 : Initial release
        //ver 2 : SongKey changed to DLCKey
        //ver 3 : removed DLCKey from arrangement
        //ver 4 : changed tagged to SongTaggerStatus
        //ver 5 : added ArtistSort TitleSort and AlbumSort variables
        //ver 6 : changed Path to FilePath to avoid conflict with reserved name System.IO.Path
        //ver 7 : add RepairStatus
        //ver 8 : add RepairStatus 'ODLC'
        //ver 9 : all app reference files moved to 'My Documents/CFSM'
        //ver 10 : force create a fresh 'My Documents/CFSM' folder'
        //ver 1 - 10: time to recycle vers numbers

        // incrementing forces songInfo.xml and appSettings.xml to reset/update to defaults
        public const string SongDataListCurrentVersion = "4";

        public string FilePath { get; set; }
        public DateTime FileDate { get; set; }
        public int FileSize { get; set; }
        public string DLCKey { get; set; }
        public string Artist { get; set; }
        public string ArtistSort { get; set; }
        public string Title { get; set; }
        public string TitleSort { get; set; }
        public string Album { get; set; }
        public string AlbumSort { get; set; }
        public Int32 SongYear { get; set; }
        public Single SongLength { get; set; }
        public Single SongAverageTempo { get; set; }
        public Single SongVolume { get; set; }
        public DateTime LastConversionDateTime { get; set; }
        public string Version { get; set; }

        // used by detail table
        [XmlArray("Arrangements")] // provides proper xml serialization
        [XmlArrayItem("Arrangement")] // provides proper xml serialization
        public FilteredBindingList<Arrangement> Arrangements2D { get; set; }

        public string ToolkitVer { get; set; }

        private string _charterName;
        public string CharterName
        {
            get
            {
                if (String.IsNullOrEmpty(_charterName))
                {
                    _charterName = "N/A";
                    if (OfficialDLC)
                        _charterName = "Ubisoft";
                }
                return _charterName;
            }
            set
            {
                _charterName = value;
            }
        }

        public string AppID { get; set; }
        //
        public string IgnitionID { get; set; } // not serialized if empty
        public string IgnitionVersion { get; set; } // not serialized if empty
        public string IgnitionAuthor { get; set; }
        public string IgnitionUpdated { get; set; } // not serialized if empty
        public string AudioCache { get; set; } // not serialized if empty
        public SongDataStatus Status { get; set; }
        public SongTaggerStatus Tagged { get; set; }
        public RepairStatus RepairStatus { get; set; }
        public bool ExtraMetaDataScanned { get; set; }
        //
        // these elements are not serialized only used to display data in datagridview
        //
        private bool _selected;
        [XmlIgnore]
        public bool Selected
        {
            get
            {
                // TODO: handle ODLC decisions at the datagrid level
                // allow non dgvMasterSongs ODLC to be deleted/moved/selected
                if (Globals.DgvCurrent.Name == "dgvMasterSongs")
                    return OfficialDLC ? false : _selected;

                return _selected;
            }
            set
            {
                if (!OfficialDLC || Globals.DgvCurrent.Name != "dgvMasterSongs")
                    SetPropertyField("Selected", ref _selected, value); // _selected = value;          
                else
                    SetPropertyField("Selected", ref _selected, false); //_selected = false;
            }
        }

        [XmlIgnore]
        public bool OfficialDLC
        {
            get { return this.Tagged == SongTaggerStatus.ODLC; }
        }

        [XmlIgnore]
        public bool IsRsCompPack
        {
            get { return !String.IsNullOrEmpty(FilePath) && FilePath.Contains(Constants.RS1COMP); }
        }

        [XmlIgnore]
        public string Enabled
        {
            get { return (new FileInfo(FilePath).Name).ToLower().Contains("disabled") ? "No" : "Yes"; }
            set { } // required for XML file usage
        }

        [XmlIgnore]
        public string ArrangementsInitials
        {
            get
            {
                string result = string.Empty;
                foreach (string arrangement in Arrangements2D.Select(x => x.Name.ToLower()).ToArray())
                {
                    if (arrangement.Contains("lead") && !arrangement.Contains("lead2"))
                        result += "L";
                    if (arrangement.Contains("lead2"))
                        result += "l";
                    if (arrangement.Contains("rhythm") && !arrangement.Contains("rhythm2"))
                        result += "R";
                    if (arrangement.Contains("rhythm2"))
                        result = "r";
                    if (arrangement.Contains("bass") && !arrangement.Contains("bass2"))
                        result += "B";
                    if (arrangement.Contains("bass2"))
                        result += "b";
                    if (arrangement.Contains("vocals"))
                        result += "V";
                    if (arrangement.Contains("combo"))
                        result += "C";
                }
                return result;
            }
        }

        [XmlIgnore] // preserves old 1D display method
        public string Arrangements1D
        {
            get { return String.Join(", ", Arrangements2D.Select(o => o.Name)); }
            set { }
        }

        [XmlIgnore] // preserves old 1D display method
        public string Tuning
        {
            get { return Arrangements2D.Select(o => o.Tuning).FirstOrDefault(); }
            // get { return String.Join(", ", Arrangements2D.Select(o => o.Tuning)); }
        }

        [XmlIgnore] // preserves old 1D display method show DMax
        public Int32? DD
        {
            get { return Convert.ToInt32(Arrangements2D.Max(o => o.DMax)); }
            //get { return String.Join(", ", Arrangements2D.Select(o => o.DMax)); }
        }

        [XmlIgnore] // preserves old 1D display method
        public Int32? Sections
        {
            get { return Arrangements2D.Max(o => o.SectionCount); }
        }

        [XmlIgnore]
        public string ArtistTitleAlbum
        {
            get { return String.Format("{0};{1};{2}", Artist, Title, Album); }
            // set { } // required for XML file usage
        }

        [XmlIgnore]
        public string ArtistTitleAlbumDate
        {
            get { return String.Format("{0};{1};{2};{3}", Artist, Title, Album, LastConversionDateTime.ToString("s")); }
            // set { } // required for XML file usage
        }

        [XmlIgnore]
        public string FileName
        {
            get { return (Path.Combine(Path.GetFileName(Path.GetDirectoryName(FilePath)), Path.GetFileName(FilePath))); }
            // set { } // required for XML file usage
        }

        // duplicate PID finder
        [XmlIgnore]
        public string PID { get; set; }

        [XmlIgnore]
        public string PIDArrangement { get; set; }

        //extra arrangemenet data   
        [XmlIgnore]
        public string ChordNums { get { return Arrangements2D[0].ChordNums.ToString(); } }
        [XmlIgnore]
        public Int32 ChordCount { get { return Arrangements2D.Sum(a => a.ChordCount); } }
        [XmlIgnore]
        public Int32 NoteCount { get { return Arrangements2D.Sum(a => a.NoteCount); } }
        [XmlIgnore]
        public Int32 OctaveCount { get { return Arrangements2D.Sum(a => a.OctaveCount); } }
        [XmlIgnore]
        public Int32 BendCount { get { return Arrangements2D.Sum(a => a.BendCount); } }
        [XmlIgnore]
        public Int32 HammerOnCount { get { return Arrangements2D.Sum(a => a.HammerOnCount); } }
        [XmlIgnore]
        public Int32 PullOffCount { get { return Arrangements2D.Sum(a => a.PullOffCount); } }
        [XmlIgnore]
        public Int32 HarmonicCount { get { return Arrangements2D.Sum(a => a.HarmonicCount); } }
        [XmlIgnore]
        public Int32 FretHandMuteCount { get { return Arrangements2D.Sum(a => a.FretHandMuteCount); } }
        [XmlIgnore]
        public Int32 PalmMuteCount { get { return Arrangements2D.Sum(a => a.PalmMuteCount); } }
        [XmlIgnore]
        public Int32 PluckCount { get { return Arrangements2D.Sum(a => a.PluckCount); } }
        [XmlIgnore]
        public Int32 SlapCount { get { return Arrangements2D.Sum(a => a.SlapCount); } }
        [XmlIgnore]
        public Int32 PopCount { get { return Arrangements2D.Sum(a => a.PopCount); } }
        [XmlIgnore]
        public Int32 SlideCount { get { return Arrangements2D.Sum(a => a.SlideCount); } }
        [XmlIgnore]
        public Int32 SustainCount { get { return Arrangements2D.Sum(a => a.SustainCount); } }
        [XmlIgnore]
        public Int32 TremoloCount { get { return Arrangements2D.Sum(a => a.TremoloCount); } }
        [XmlIgnore]
        public Int32 HarmonicPinchCount { get { return Arrangements2D.Sum(a => a.HarmonicCount); } }
        [XmlIgnore]
        public Int32 UnpitchedSlideCount { get { return Arrangements2D.Sum(a => a.UnpitchedSlideCount); } }
        [XmlIgnore]
        public Int32 TapCount { get { return Arrangements2D.Sum(a => a.TapCount); } }
        [XmlIgnore]
        public Int32 VibratoCount { get { return Arrangements2D.Sum(a => a.VibratoCount); } }
        [XmlIgnore]
        public Int32 HighestFretUsed { get { return Arrangements2D.Max(a => a.HighestFretUsed); } }


        public void Delete()
        {
            if (!String.IsNullOrEmpty(AudioCache) && File.Exists(AudioCache))
                File.Delete(AudioCache);
            AudioCache = String.Empty;
            if (File.Exists(FilePath))
                File.Delete(FilePath);
        }

        public void UpdateFileInfo()
        {
            var fi = new FileInfo(FilePath);
            FileDate = fi.LastWriteTimeUtc;
            FileSize = (int)fi.Length;
        }
    }

    // used for Analyzer data
    [XmlRoot("Arrangment")]
    public class Arrangement
    {
        public string PersistentID { get; set; }
        public string Name { get; set; } // arrangement name
        public string Tuning { get; set; }
        public string ToneBase { get; set; }
        public Int32? DMax { get; set; } // null value is not serialized
        public Int32? SectionCount { get; set; } // null value is not serialized

        public bool ShouldSerializeDMax()
        {
            return DMax.HasValue;
        }

        public bool ShouldSerializeSectionCount()
        {
            return SectionCount.HasValue;
        }

        public Arrangement()
        {
        }

        public Arrangement(SongData Parent)
        {
            this.Parent = Parent;
        }

        [XmlIgnore]
        public string DLCKey
        {
            get
            {
                if (Parent != null)
                    return Parent.DLCKey;
                return string.Empty;
            }
        }

        [XmlIgnore]
        public SongData Parent { get; set; }
        [XmlIgnore]
        public List<string> ChordNames { get; set; }
        [XmlIgnore]
        public List<int> ChordCounts { get; set; }

        public string ChordNums
        {
            get
            {
                if (ChordNames == null)
                    return "";

                string stringList = "";

                for (int i = 0; i < ChordNames.Count(); i++)
                {
                    stringList += (ChordNames[i] + "-" + ChordCounts[i].ToString() + "| ");
                }

                return stringList;
            }
            set { }
        }

        public Int32 ChordCount { get; set; }
        public Int32 NoteCount { get; set; }
        public Int32 BendCount { get; set; }
        public Int32 FretHandMuteCount { get; set; }
        public Int32 HammerOnCount { get; set; }
        public Int32 HarmonicCount { get; set; }
        public Int32 HarmonicPinchCount { get; set; }
        public Int32 HighestFretUsed { get; set; }
        public Int32 OctaveCount { get; set; }
        public Int32 PalmMuteCount { get; set; }
        public Int32 PluckCount { get; set; }
        public Int32 PopCount { get; set; }
        public Int32 PullOffCount { get; set; }
        public Int32 SlapCount { get; set; }
        public Int32 SlideCount { get; set; }
        public Int32 SustainCount { get; set; }
        public Int32 TapCount { get; set; }
        public Int32 TremoloCount { get; set; }
        public Int32 UnpitchedSlideCount { get; set; }
        public Int32 VibratoCount { get; set; }

        // TODO: add progress tracker fields 

    }



}