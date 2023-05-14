using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using TagLib;

namespace AudioTagEditor
{
    [TypeConverter(typeof(CustomSortTypeConverter))]
    public class Mp3AudioPropertyGridSetting
    {
        public string Title { get; set; }
        public string AlbumName { get; set; }

        public List<ArtistName> ArtistName_List = new List<ArtistName>();
        [Editor(typeof(ArtistName_CollectionEditor), typeof(UITypeEditor))]
        public List<ArtistName> ArtistNameList { get => ArtistName_List; set => ArtistName_List = value; }
        public class ArtistName
        {
            public string Name { get; set; }

            public static List<ArtistName> Add(string[] qw)
            {
                #region Temp
                //List<ArtistName> artistNames = new List<ArtistName>();

                //for (int f = 0; f < qw.Length; f++)
                //{
                //    ArtistName artistName = new ArtistName
                //    {
                //        Name = qw[f]
                //    };

                //    artistNames.Add(artistName);
                //}

                //return artistNames;
                #endregion

                return qw.ToList().Select(x => new ArtistName { Name = x }).ToList();
            }

            public override string ToString()
            {
                return "Artist :" + Name;
            }
        }

        public List<AlbumArtistName> AlbumArtistName_List = new List<AlbumArtistName>();
        public List<AlbumArtistName> AlbumArtistNameList { get => AlbumArtistName_List; set => AlbumArtistName_List = value; }
        public class AlbumArtistName
        {
            public string Name { get; set; }

            public static List<AlbumArtistName> Add(string[] qw)
            {
                return qw.ToList().Select(x => new AlbumArtistName { Name = x }).ToList();
            }

            public override string ToString()
            {
                return "Album Artist :" + Name;
            }
        }

        public List<ComposersName> ComposersName_List = new List<ComposersName>();
        public List<ComposersName> ComposersNameList { get => ComposersName_List; set => ComposersName_List = value; }
        public class ComposersName
        {
            public string Name { get; set; }

            public static List<ComposersName> Add(string[] qw)
            {
                return qw.ToList().Select(x => new ComposersName { Name = x }).ToList();
            }

            public override string ToString()
            {
                return "Composers :" + Name;
            }
        }

        public List<Genres> Genres_List = new List<Genres>();
        public List<Genres> GenresList { get => Genres_List; set => Genres_List = value; }
        public class Genres
        {
            public string GenresName { get; set; }

            public static List<Genres> Add(string[] qw)
            {
                return qw.ToList().Select(x => new Genres { GenresName = x }).ToList();
            }

            public override string ToString()
            {
                return "Genres ;" + GenresName;
            }
        }

        [TypeConverter(typeof(CustomSortTypeConverter))]
        public TrackAndDiscCount TrackAndDiscCountData = new TrackAndDiscCount();
        public class TrackAndDiscCount
        {
            public uint Track { get; set; }
            public uint TrackCount { get; set; }
            public uint Disc { get; set; }
            public uint DiscCount { get; set; }
        }

        public uint Year { get; set; }
        
        public string SubTitle { get; set; }
        public uint BeatPerMinute { get; set; }

        public string Description { get; set; }
        public string AmazonId { get; set; }
        public string Comment { get; set; }
        public string Conductor { get; set; }
        public string Copyright { get; set; }
        public DateTime DateTagged { get; set; }

        public string Grouping { get; set; }
        public string InitialKey { get; set; }
        public string ISRC { get; set; }
        public string Lyrics { get; set; }

        [TypeConverter(typeof(CustomExpandableObjectSortTypeConverter))]
        public Property property { get; set; } = new Property();
        public class Property
        {
            [ReadOnly(true)]
            public TimeSpan? TimeSpan { get; set; }

            [ReadOnly(true)]
            public int AudioBitrate { get; set; }

            [ReadOnly(true)]
            public int AudioChannels { get; set; }

            [ReadOnly(true)]
            public int AudioSampleRate { get; set; }

            [ReadOnly(true)]
            public int BitsPerSample { get; set; }

            [ReadOnly(true)]
            public List<ICodec> Codecs { get; set; }

            [ReadOnly(true)]
            public string Description { get; set; }

            [ReadOnly(true)]
            public MediaTypes MediaTypes { get; set; }

            [ReadOnly(true)]
            public int PhotoHeight { get; set; }

            [ReadOnly(true)]
            public int PhotoWidth { get; set; }

            [ReadOnly(true)]
            public int PhotoQuality { get; set; }

            [ReadOnly(true)]
            public int VideoHeight { get; set; }

            [ReadOnly(true)]
            public int VideoWidth { get; set; }

            public override string ToString()
            {
                return "Audio Property";
            }
        }

        [TypeConverter(typeof(CustomExpandableObjectSortTypeConverter))]
        public MusicBrainzSection MusicBrainzSections { get; set; } = new MusicBrainzSection();
        public class MusicBrainzSection
        {
            public string MusicBrainzArtistId { get; set; }
            public string MusicBrainzDiscId { get; set; }
            public string MusicBrainzReleaseArtistId { get; set; }
            public string MusicBrainzReleaseCountry { get; set; }
            public string MusicBrainzReleaseGroupId { get; set; }
            public string MusicBrainzReleaseId { get; set; }
            public string MusicBrainzReleaseStatus { get; set; }
            public string MusicBrainzReleaseType { get; set; }
            public string MusicBrainzTrackId { get; set; }

            public override string ToString()
            {
                return "MusicBrainz Info";
            }
        }


        public string MusicIpId { get; set; }


        public List<PerformersRole> PerformersRole_List = new List<PerformersRole>();
        public List<PerformersRole> PerformersRoleList { get => PerformersRole_List; set => PerformersRole_List = value; }
        public class PerformersRole
        {
            public string Value { get; set; }

            public static List<PerformersRole> Add(string[] qw)
            {
                return qw.ToList().Select(x => new PerformersRole { Value = x }).ToList();
            }

            public override string ToString()
            {
                return "Genres ;" + Value;
            }
        }

        public string Publisher { get; set; }
        public string RemixedBy { get; set; }

        [TypeConverter(typeof(CustomExpandableObjectSortTypeConverter))]
        public ReplayGain ReplayGains { get; set; } = new ReplayGain();
        public class ReplayGain
        {
            [TypeConverter(typeof(CustomExpandableObjectSortTypeConverter))]
            public Album AlbumGain { get; set; } = new Album();
            public class Album
            {
                public double ReplayGainAlbumGain { get; set; }
                public double ReplayGainAlbumPeak { get; set; }

                public override string ToString()
                {
                    return "AlbumGain";
                }
            }

            [TypeConverter(typeof(CustomExpandableObjectSortTypeConverter))]
            public Track TrackGain { get; set; } = new Track();
            public class Track
            {
                public double ReplayGainTrackGain { get; set; }
                public double ReplayGainTrackPeak { get; set; }

                public override string ToString()
                {
                    return "TrackGain";
                }
            }

            public override string ToString()
            {
                return "ReplayGain";
            }
        }

        [ReadOnly(true)]
        public TagTypes TagType { get; set; }

        [Browsable(false)]
        public List<IPicture> ImageList { get; set; }

        [Browsable(false)]
        public List<Image> ToImages
        {
            get
            {
                return ImageList.Select(x => Image.FromStream(new MemoryStream(x.Data.Data))).ToList();
            }
        }
    }

    public class CustomSortTypeConverter : TypeConverter
    {
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            PropertyDescriptorCollection PDC = TypeDescriptor.GetProperties(value, attributes);

            Type type = value.GetType();

            List<string> list = type.GetProperties().Select(x => x.Name).ToList();

            return PDC.Sort(list.ToArray());
        }

        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
    }

    public class CustomExpandableObjectSortTypeConverter : ExpandableObjectConverter
    {
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            PropertyDescriptorCollection PDC = TypeDescriptor.GetProperties(value, attributes);

            Type type = value.GetType();

            List<string> list = type.GetProperties().Select(x => x.Name).ToList();

            return PDC.Sort(list.ToArray());
        }

        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
    }

    class ArtistName_CollectionEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
        public override object EditValue(ITypeDescriptorContext context, System.IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService svc = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            if (svc != null && value != null)
            {
                ArtistNameCollectionEditor form = new ArtistNameCollectionEditor(value as List<Mp3AudioPropertyGridSetting.ArtistName>);
                form.ShowDialog();

                value = form.ArtistNameList;
            }
            return value; // can also replace the wrapper object here
        }
    }

    //public class DescText
    //{
    //    public  String T { get; set; }
    //    public DescText(String s)
    //    {
    //        T = s;
    //    }
    //}

    //[System.AttributeUsage(AttributeTargets.All)]
    //public class CustomAttribute : System.Attribute
    //{
    //    public string text { get; set; }

    //    public override object TypeId => base.TypeId;

    //    public CustomAttribute(DescText descText)
    //    {
    //        if (descText.T is string) text = descText.T;
    //    }
    //}


    //public class CustomDescriptionAttribute : DescriptionAttribute
    //{
    //    public static string tC { get; set; }

    //    public CustomDescriptionAttribute(object description) : base(description.ToString())
    //    {
    //        tC = SetDescription(description);
    //        DescriptionValue = tC;
    //    }

    //    //public override string Description => tC;
    //    public override string Description => base.Description;

    //    public static string SetDescription(object obj)
    //    {
    //        string s = "";
    //        if (obj is string)
    //        {
    //            s = obj.ToString();
    //        }

    //        return s;
    //    }
    //}
}
