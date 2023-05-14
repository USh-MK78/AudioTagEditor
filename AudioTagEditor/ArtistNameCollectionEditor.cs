using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioTagEditor
{
    public partial class ArtistNameCollectionEditor : Form
    {
        public List<Mp3AudioPropertyGridSetting.ArtistName> ArtistNameList { get; set; }

        public ArtistNameCollectionEditor(List<Mp3AudioPropertyGridSetting.ArtistName> artistNames = null)
        {
            InitializeComponent();
            ArtistNameList = artistNames;
        }

        public Form1 Form1;

        private void ArtistNameCollectionEditor_Load(object sender, EventArgs e)
        {
            Form1 = (Form1)Application.OpenForms["Form1"];

            if (ArtistNameList.Count != 0)
            {
                InputArtistName_comboBox.Items.AddRange(ArtistNameList.Select(x => x.Name).ToArray());
                ArtistName_listBox.Items.AddRange(ArtistNameList.Select(x => x.Name).ToArray());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InputArtistName_comboBox.Text != "")
			{
                if (UseCommasChk.Checked == true)
                {
                    List<string> strList = InputArtistName_comboBox.Text.Split(',').ToList();
                    ArtistName_listBox.Items.AddRange(strList.ToArray());

                    foreach (var i in strList.ToArray())
                    {
                        ArtistNameList.Add(new Mp3AudioPropertyGridSetting.ArtistName { Name = i.ToString() });
                    }
                }
                if (UseCommasChk.Checked == false)
                {
                    ArtistName_listBox.Items.Add(InputArtistName_comboBox.Text);
                    ArtistNameList.Add(new Mp3AudioPropertyGridSetting.ArtistName { Name = InputArtistName_comboBox.Text });
                }
            }
            if (InputArtistName_comboBox.Text == "")
			{
                MessageBox.Show("Please enter the artist name");
			}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArtistNameList.RemoveAt(ArtistName_listBox.SelectedIndex);
            ArtistName_listBox.Items.RemoveAt(ArtistName_listBox.SelectedIndex);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ArtistName_listBox.SelectedIndex != -1)
			{
                Clipboard.SetText(ArtistName_listBox.Items[ArtistName_listBox.SelectedIndex].ToString());
            }
        }

		private void ArtistName_listBox_DoubleClick(object sender, EventArgs e)
		{
            EditArtistNameForm editArtistNameForm = new EditArtistNameForm(ArtistName_listBox.SelectedItem.ToString());
            editArtistNameForm.ShowDialog();

            ArtistNameList.Insert(ArtistName_listBox.SelectedIndex, new Mp3AudioPropertyGridSetting.ArtistName { Name = editArtistNameForm.ArtistNameString });
            ArtistNameList.RemoveAt(ArtistName_listBox.SelectedIndex);

            ArtistName_listBox.Items.Insert(ArtistName_listBox.SelectedIndex, editArtistNameForm.ArtistNameString);
            ArtistName_listBox.Items.RemoveAt(ArtistName_listBox.SelectedIndex);
		}

        private void ArtistNameCollectionEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.mp3AudioPGSetting.ArtistNameList = ArtistNameList;
            //Form1.file.Save();
        }
    }
}
