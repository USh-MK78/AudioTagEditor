using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioTagEditor
{
    public partial class PlayListEditor : Form
    {
        public string ZplPath { get; set; }
        public ZplPlaylistPropertyGridSetting ZplPlaylistPropertyGridSetting { get; set; }

        public PlayListEditor()
        {
            InitializeComponent();
        }

        public PlayListEditor(string Path)
        {
            InitializeComponent();

            ZplPath = Path;
        }

        public static T XMLImport<T>(string Path)
        {
            System.IO.FileStream fs1 = new FileStream(Path, FileMode.Open, FileAccess.Read);
            System.Xml.Serialization.XmlSerializer s1 = new System.Xml.Serialization.XmlSerializer(typeof(T));
            return (T)s1.Deserialize(fs1);
        }

        private void PlayListEditor_Load(object sender, EventArgs e)
        {
            if (ZplPath != "")
            {
                ZPLXml zPLXml = XMLImport<ZPLXml>(ZplPath);

                ZplPlaylistPropertyGridSetting zplPlaylistPropertyGridSetting = new ZplPlaylistPropertyGridSetting
                {
                    head = new ZplPlaylistPropertyGridSetting.Head
                    {
                        MetaList = new List<ZplPlaylistPropertyGridSetting.Head.Meta>(),
                        PlaylistTitle = zPLXml.head.PlaylistTitles.Title
                    },
                    body = new ZplPlaylistPropertyGridSetting.Body
                    {
                        seq = new ZplPlaylistPropertyGridSetting.Body.Seq
                        {
                            MediaList = new List<ZplPlaylistPropertyGridSetting.Body.Seq.Media>()
                        }
                    }
                };

                foreach (var d in zPLXml.head.meta_Value)
                {
                    ZplPlaylistPropertyGridSetting.Head.Meta meta = new ZplPlaylistPropertyGridSetting.Head.Meta
                    {
                        Name = d.Name,
                        Context = d.Content
                    };

                    zplPlaylistPropertyGridSetting.head.MetaList.Add(meta);
                }

                foreach (var d in zPLXml.body.seq.media_Value)
                {
                    ZplPlaylistPropertyGridSetting.Body.Seq.Media media = new ZplPlaylistPropertyGridSetting.Body.Seq.Media
                    {
                        Path = d.MediaSrc,
                        Album_Title = d.albumTitle,
                        Album_Artist = d.albumArtist,
                        Track_Title = d.trackTitle,
                        Track_Artist = d.trackArtist,
                        Duration = d.duration
                    };

                    zplPlaylistPropertyGridSetting.body.seq.MediaList.Add(media);
                }

                ZplPlaylistPropertyGridSetting = zplPlaylistPropertyGridSetting;

                PG_Playlist_HeadInfo.SelectedObject = ZplPlaylistPropertyGridSetting.head;

                string[] s = ZplPlaylistPropertyGridSetting.body.seq.MediaList.Select(x => x.Track_Title).ToArray();
                listBox1.Items.AddRange(s);

                listBox1.SelectedIndex = 0;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PG_Playlist_BodyInfo.SelectedObject = ZplPlaylistPropertyGridSetting.body.seq.MediaList[listBox1.SelectedIndex];
        }
    }
}
