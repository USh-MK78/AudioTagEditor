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
	public partial class EditArtistNameForm : Form
	{
		public string ArtistNameString { get; set; }

		public EditArtistNameForm(string Name)
		{
			InitializeComponent();

			ArtistNameString = Name;
		}

		private void EditArtistNameForm_Load(object sender, EventArgs e)
		{
			ArtistNameTXTBox.Text = ArtistNameString;
		}

		private void EditArtistNameForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			ArtistNameString = ArtistNameTXTBox.Text;
		}
	}
}
