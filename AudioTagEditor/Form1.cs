using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TagLib;

namespace AudioTagEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AlbumCoverpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            AlbumCoverpictureBox.ContextMenuStrip = contextMenuStrip1;
        }

        string p = "";
        public TagLib.File file = null;
        List<string[]> mp3List = new List<string[]>();

        public Mp3AudioPropertyGridSetting mp3AudioPGSetting { get; set; }

        private void selectDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Select Library",
                InitialDirectory = System.Environment.CurrentDirectory,
                Filter = "Select Directory|*.",
                RestoreDirectory = true,
                CheckFileExists = false,
                CheckPathExists = true,
                ValidateNames = false,
                FileName = "Select Folder"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MusicList_listBox.Items.Clear();
                MusicList_listBox.Update();
                AlbumCoverpictureBox.Image = null;
                AlbumCoverComboBox.Items.Clear();
                AudioTagPropertyGrid.SelectedObject = null;

                p = Path.GetDirectoryName(openFileDialog.FileName);

                //mp3List = new List<string>();
                foreach (var path in Directory.GetFiles(p, "*.mp3", SearchOption.AllDirectories).ToArray()) mp3List.Add(new string[] { "mp3", p, Path.GetFileName(path), path, path.Replace(p, "") });
                foreach (var path in Directory.GetFiles(p, "*.wav", SearchOption.AllDirectories).ToArray()) mp3List.Add(new string[] { "wav", p, Path.GetFileName(path), path, path.Replace(p, "") });
                foreach (var path in Directory.GetFiles(p, "*.m4a", SearchOption.AllDirectories).ToArray()) mp3List.Add(new string[] { "m4a", p, Path.GetFileName(path), path, path.Replace(p, "") });
                foreach (var path in Directory.GetFiles(p, "*.ogg", SearchOption.AllDirectories).ToArray()) mp3List.Add(new string[] { "ogg", p, Path.GetFileName(path), path, path.Replace(p, "") });

                //mp3List.Add(Directory.GetFiles(p, "*.mp3", SearchOption.AllDirectories).Select(x => Path.GetFileName(x)).ToArray());
                //mp3List.AddRange(Directory.GetFiles(p, "*.wav", SearchOption.AllDirectories).Select(x => Path.GetFileName(x)).ToList().ToArray());
                //mp3List.AddRange(Directory.GetFiles(p, "*.m4a", SearchOption.AllDirectories).Select(x => Path.GetFileName(x)).ToList().ToArray());
                //mp3List.AddRange(Directory.GetFiles(p, "*.ogg", SearchOption.AllDirectories).Select(x => Path.GetFileName(x)).ToList().ToArray());

                MusicList_listBox.Items.AddRange(mp3List.Select(x => x[2]).ToArray());

                if (mp3List.Count != 0) MusicList_listBox.SelectedIndex = 0;
                if (mp3List.Count == 0) MusicList_listBox.SelectedIndex = -1;

                this.Text = "AudioTagEditor [ Open Directory :" + p + " ]";
            }
            else
            {
                this.Text = "AudioTagEditor";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            file = TagLib.File.Create(mp3List[MusicList_listBox.SelectedIndex][3]);

            Mp3AudioPropertyGridSetting mp3AudioPropertyGridSetting = new Mp3AudioPropertyGridSetting
            {
                Title = file.Tag.Title,
                AlbumName = file.Tag.Album,
                ArtistNameList = Mp3AudioPropertyGridSetting.ArtistName.Add(file.Tag.Performers),
                AlbumArtistNameList = Mp3AudioPropertyGridSetting.AlbumArtistName.Add(file.Tag.AlbumArtists),
                ComposersNameList = Mp3AudioPropertyGridSetting.ComposersName.Add(file.Tag.Composers),              
                GenresList = Mp3AudioPropertyGridSetting.Genres.Add(file.Tag.Genres),
                TrackAndDiscCountData = new Mp3AudioPropertyGridSetting.TrackAndDiscCount
                {
                    Track = file.Tag.Track,
                    TrackCount = file.Tag.TrackCount,
                    Disc = file.Tag.Disc,
                    DiscCount = file.Tag.DiscCount,
                },
                Year = file.Tag.Year,
                SubTitle = file.Tag.Subtitle,
                BeatPerMinute = file.Tag.BeatsPerMinute,
                Description = file.Tag.Description,
                AmazonId = file.Tag.AmazonId,
                Comment = file.Tag.Comment,
                Conductor = file.Tag.Conductor,
                Copyright = file.Tag.Copyright,
                DateTagged = file.Tag.DateTagged ?? new DateTime(),
                Grouping = file.Tag.Grouping,
                InitialKey = file.Tag.InitialKey,
                ISRC = file.Tag.ISRC,
                Lyrics = file.Tag.Lyrics,
                property = new Mp3AudioPropertyGridSetting.Property
                {
                    TimeSpan = file.Properties.Duration,
                    AudioBitrate = file.Properties.AudioBitrate,
                    AudioChannels = file.Properties.AudioChannels,
                    AudioSampleRate = file.Properties.AudioSampleRate,
                    BitsPerSample = file.Properties.BitsPerSample,
                    Codecs = file.Properties.Codecs.ToList(),
                    Description = file.Properties.Description,
                    MediaTypes = file.Properties.MediaTypes,
                    PhotoHeight = file.Properties.PhotoHeight,
                    PhotoWidth = file.Properties.PhotoWidth,
                    PhotoQuality = file.Properties.PhotoQuality,
                    VideoHeight = file.Properties.VideoHeight,
                    VideoWidth = file.Properties.VideoWidth
                },
                MusicBrainzSections = new Mp3AudioPropertyGridSetting.MusicBrainzSection
                {
                    MusicBrainzArtistId = file.Tag.MusicBrainzArtistId,
                    MusicBrainzDiscId = file.Tag.MusicBrainzDiscId,
                    MusicBrainzReleaseArtistId = file.Tag.MusicBrainzReleaseArtistId,
                    MusicBrainzReleaseCountry = file.Tag.MusicBrainzReleaseCountry,
                    MusicBrainzReleaseGroupId = file.Tag.MusicBrainzReleaseGroupId,
                    MusicBrainzReleaseId = file.Tag.MusicBrainzReleaseId,
                    MusicBrainzReleaseStatus = file.Tag.MusicBrainzReleaseStatus,
                    MusicBrainzReleaseType = file.Tag.MusicBrainzReleaseType,
                    MusicBrainzTrackId = file.Tag.MusicBrainzTrackId
                },
                ImageList = file.Tag.Pictures.ToList(),
                MusicIpId = file.Tag.MusicIpId,
                PerformersRoleList = Mp3AudioPropertyGridSetting.PerformersRole.Add(file.Tag.PerformersRole),
                Publisher = file.Tag.Publisher,
                RemixedBy = file.Tag.RemixedBy,
                ReplayGains = new Mp3AudioPropertyGridSetting.ReplayGain
                {
                    AlbumGain = new Mp3AudioPropertyGridSetting.ReplayGain.Album
                    {
                        ReplayGainAlbumGain = file.Tag.ReplayGainAlbumGain,
                        ReplayGainAlbumPeak = file.Tag.ReplayGainAlbumPeak
                    },
                    TrackGain = new Mp3AudioPropertyGridSetting.ReplayGain.Track
                    {
                        ReplayGainTrackGain = file.Tag.ReplayGainTrackGain,
                        ReplayGainTrackPeak = file.Tag.ReplayGainTrackPeak
                    }
                },
                TagType = file.Tag.TagTypes
            };

            mp3AudioPGSetting = mp3AudioPropertyGridSetting;

            AudioTagPropertyGrid.SelectedObject = mp3AudioPropertyGridSetting;

            AlbumCoverComboBox.Items.Clear();

            for (int d = 0; d < mp3AudioPGSetting.ImageList.Count; d++) AlbumCoverComboBox.Items.Add("AlbumCover_" + d);

            if (mp3AudioPGSetting.ImageList.Count != 0)
            {
                AlbumCoverComboBox.SelectedIndex = 0;
                AlbumCoverpictureBox.Image = mp3AudioPGSetting.ToImages[0];
            }
            if (mp3AudioPGSetting.ImageList.Count == 0) AlbumCoverpictureBox.Image = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlbumCoverpictureBox.Image = mp3AudioPGSetting.ToImages[AlbumCoverComboBox.SelectedIndex];
        }

        private void AudioTagPropertyGrid_Leave(object sender, EventArgs e)
        {
            if (AudioTagPropertyGrid.SelectedObject != null)
            {
                file.Tag.Title = mp3AudioPGSetting.Title;
                file.Tag.Album = mp3AudioPGSetting.AlbumName;
                file.Tag.Performers = mp3AudioPGSetting.ArtistNameList.Select(x => x.Name).ToArray();
                file.Tag.AlbumArtists = mp3AudioPGSetting.AlbumArtistNameList.Select(x => x.Name).ToArray();
                file.Tag.Composers = mp3AudioPGSetting.ComposersNameList.Select(x => x.Name).ToArray();
                file.Tag.Track = mp3AudioPGSetting.TrackAndDiscCountData.Track;
                file.Tag.TrackCount = mp3AudioPGSetting.TrackAndDiscCountData.TrackCount;
                file.Tag.Disc = mp3AudioPGSetting.TrackAndDiscCountData.Disc;
                file.Tag.DiscCount = mp3AudioPGSetting.TrackAndDiscCountData.DiscCount;
                file.Tag.Year = mp3AudioPGSetting.Year;
                file.Tag.Genres = mp3AudioPGSetting.GenresList.Select(x => x.GenresName).ToArray();
                file.Tag.Subtitle = mp3AudioPGSetting.SubTitle;
                file.Tag.BeatsPerMinute = mp3AudioPGSetting.BeatPerMinute;
                file.Tag.Description = mp3AudioPGSetting.Description;
                file.Tag.AmazonId = mp3AudioPGSetting.AmazonId;
                file.Tag.Comment = mp3AudioPGSetting.Comment;
                file.Tag.Conductor = mp3AudioPGSetting.Conductor;
                file.Tag.Copyright = mp3AudioPGSetting.Copyright;
                file.Tag.DateTagged = mp3AudioPGSetting.DateTagged;
                file.Tag.Grouping = mp3AudioPGSetting.Grouping;
                file.Tag.InitialKey = mp3AudioPGSetting.InitialKey;
                file.Tag.ISRC = mp3AudioPGSetting.ISRC;
                file.Tag.Lyrics = mp3AudioPGSetting.Lyrics;

                file.Tag.MusicBrainzArtistId = mp3AudioPGSetting.MusicBrainzSections.MusicBrainzArtistId;
                file.Tag.MusicBrainzDiscId = mp3AudioPGSetting.MusicBrainzSections.MusicBrainzDiscId;
                file.Tag.MusicBrainzReleaseArtistId = mp3AudioPGSetting.MusicBrainzSections.MusicBrainzReleaseArtistId;
                file.Tag.MusicBrainzReleaseCountry = mp3AudioPGSetting.MusicBrainzSections.MusicBrainzReleaseCountry;
                file.Tag.MusicBrainzReleaseGroupId = mp3AudioPGSetting.MusicBrainzSections.MusicBrainzReleaseGroupId;
                file.Tag.MusicBrainzReleaseId = mp3AudioPGSetting.MusicBrainzSections.MusicBrainzReleaseId;
                file.Tag.MusicBrainzReleaseStatus = mp3AudioPGSetting.MusicBrainzSections.MusicBrainzReleaseStatus;
                file.Tag.MusicBrainzReleaseType = mp3AudioPGSetting.MusicBrainzSections.MusicBrainzReleaseType;
                file.Tag.MusicBrainzTrackId = mp3AudioPGSetting.MusicBrainzSections.MusicBrainzTrackId;

                file.Tag.MusicIpId = mp3AudioPGSetting.MusicIpId;
                file.Tag.PerformersRole = mp3AudioPGSetting.PerformersRoleList.Select(x => x.Value).ToArray();
                file.Tag.Publisher = mp3AudioPGSetting.Publisher;
                file.Tag.RemixedBy = mp3AudioPGSetting.RemixedBy;

                file.Tag.ReplayGainAlbumGain = mp3AudioPGSetting.ReplayGains.AlbumGain.ReplayGainAlbumGain;
                file.Tag.ReplayGainAlbumPeak = mp3AudioPGSetting.ReplayGains.AlbumGain.ReplayGainAlbumPeak;
                file.Tag.ReplayGainTrackGain = mp3AudioPGSetting.ReplayGains.TrackGain.ReplayGainTrackGain;
                file.Tag.ReplayGainTrackPeak = mp3AudioPGSetting.ReplayGains.TrackGain.ReplayGainTrackPeak;

                //file.Tag.TagTypes = mp3AudioPGSetting.TagType;

                file.Save();
            }
        }

        private void AddAlbumCoverBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Image",
                InitialDirectory = System.Environment.CurrentDirectory,
                Filter = "JPG File|*.jpg|JPEG File|*.jpeg|png File|*.png"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog.FileName);

                ImageConverter ic = new ImageConverter();
                mp3AudioPGSetting.ImageList.Add(new Picture(new ByteVector((byte[])ic.ConvertTo(image, typeof(byte[])))));

                AlbumCoverComboBox.Items.Clear();

                for (int d = 0; d < mp3AudioPGSetting.ImageList.Count; d++) AlbumCoverComboBox.Items.Add("AlbumCover_" + d);

                if (mp3AudioPGSetting.ImageList.Count != 0)
                {
                    AlbumCoverComboBox.SelectedIndex = 0;
                    AlbumCoverpictureBox.Image = mp3AudioPGSetting.ToImages[mp3AudioPGSetting.ImageList.Count - 1];
                }
                if (mp3AudioPGSetting.ImageList.Count == 0) AlbumCoverpictureBox.Image = null;

                file.Tag.Pictures = mp3AudioPGSetting.ImageList.ToArray();

                file.Save();
            }
        }

        private void DeleteAlbumCoverBtn_Click(object sender, EventArgs e)
        {
            if (AlbumCoverComboBox.SelectedIndex != -1)
            {
                mp3AudioPGSetting.ImageList.RemoveAt(AlbumCoverComboBox.SelectedIndex);

                AlbumCoverComboBox.Items.Clear();

                for (int d = 0; d < mp3AudioPGSetting.ImageList.Count; d++) AlbumCoverComboBox.Items.Add("AlbumCover_" + d);

                if (mp3AudioPGSetting.ImageList.Count != 0)
                {
                    AlbumCoverComboBox.SelectedIndex = 0;
                    AlbumCoverpictureBox.Image = mp3AudioPGSetting.ToImages[mp3AudioPGSetting.ImageList.Count - 1];
                }
                if (mp3AudioPGSetting.ImageList.Count == 0) AlbumCoverpictureBox.Image = null;

                file.Tag.Pictures = mp3AudioPGSetting.ImageList.ToArray();

                file.Save();
            }
        }

        private void editImageInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AudioTagImageInfoEditor audioTagImageInfoEditor = new AudioTagImageInfoEditor(file.Tag.Pictures[AlbumCoverComboBox.SelectedIndex]);
            audioTagImageInfoEditor.ShowDialog();

            file.Tag.Pictures[AlbumCoverComboBox.SelectedIndex].Type = audioTagImageInfoEditor.PictureInfo.Type;
            file.Tag.Pictures[AlbumCoverComboBox.SelectedIndex].MimeType = audioTagImageInfoEditor.PictureInfo.MimeType;
            file.Tag.Pictures[AlbumCoverComboBox.SelectedIndex].Description = audioTagImageInfoEditor.PictureInfo.Description;

            file.Save();

            //if (audioTagImageInfoEditor.IsDisposed == true)
            //{

            //}
            //if (audioTagImageInfoEditor.IsDisposed == false)
            //{

            //}
        }

        private void exportImageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editzplFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Open Zpl",
                InitialDirectory = @"C:\Users\User\Desktop",
                Filter = "zpl file|*.zpl"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PlayListEditor playListEditor = new PlayListEditor(openFileDialog.FileName);
                playListEditor.Show();
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MusicList_listBox.Items.Count != 0)
            {
                mp3List.Clear();

                MusicList_listBox.Items.Clear();
                MusicList_listBox.Update();
                AlbumCoverpictureBox.Image = null;
                AlbumCoverComboBox.Items.Clear();
                AudioTagPropertyGrid.SelectedObject = null;

                foreach (var path in Directory.GetFiles(p, "*.mp3", SearchOption.AllDirectories).ToArray()) mp3List.Add(new string[] { "mp3", p, Path.GetFileName(path), path, path.Replace(p, "") });
                foreach (var path in Directory.GetFiles(p, "*.wav", SearchOption.AllDirectories).ToArray()) mp3List.Add(new string[] { "wav", p, Path.GetFileName(path), path, path.Replace(p, "") });
                foreach (var path in Directory.GetFiles(p, "*.m4a", SearchOption.AllDirectories).ToArray()) mp3List.Add(new string[] { "m4a", p, Path.GetFileName(path), path, path.Replace(p, "") });
                foreach (var path in Directory.GetFiles(p, "*.ogg", SearchOption.AllDirectories).ToArray()) mp3List.Add(new string[] { "ogg", p, Path.GetFileName(path), path, path.Replace(p, "") });

                MusicList_listBox.Items.AddRange(mp3List.Select(x => x[2]).ToArray());

                if (mp3List.Count != 0) MusicList_listBox.SelectedIndex = 0;
                if (mp3List.Count == 0) MusicList_listBox.SelectedIndex = -1;

                this.Text = "AudioTagEditor [ Open Directory :" + p + " ]";
            }
            if (MusicList_listBox.Items.Count == 0) return;

        }

        private void closeDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mp3List.Clear();
            MusicList_listBox.Items.Clear();
            MusicList_listBox.Update();
            AlbumCoverpictureBox.Image = null;
            AlbumCoverComboBox.Items.Clear();
            AudioTagPropertyGrid.SelectedObject = null;
            file = null;
            p = "";
        }
    }
}
