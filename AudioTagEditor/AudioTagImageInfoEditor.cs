using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;

namespace AudioTagEditor
{
    public partial class AudioTagImageInfoEditor : Form
    {
        public IPicture PictureInfo { get; set; }
        public IPicturePropertyGridSetting picturePropertyGridSettings { get; set; }

        public AudioTagImageInfoEditor(IPicture picture)
        {
            InitializeComponent();

            PictureInfo = picture;

            IPicturePropertyGridSetting picturePropertyGridSetting = new IPicturePropertyGridSetting
            {
                pictureType = picture.Type,
                MimeType = picture.MimeType,
                Description = picture.Description
            };

            picturePropertyGridSettings = picturePropertyGridSetting;
            propertyGrid1.SelectedObject = picturePropertyGridSetting;
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            PictureInfo.Type = picturePropertyGridSettings.pictureType;
            PictureInfo.MimeType = picturePropertyGridSettings.MimeType;
            PictureInfo.Description = picturePropertyGridSettings.Description;

            //IPicturePropertyGridSetting picturePropertyGridSetting = new IPicturePropertyGridSetting
            //{
            //    pictureType = PictureInfo.
            //}
        }

        private void AudioTagImageInfoEditor_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
