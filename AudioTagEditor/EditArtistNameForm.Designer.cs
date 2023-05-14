
namespace AudioTagEditor
{
	partial class EditArtistNameForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ArtistNameTXTBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// ArtistNameTXTBox
			// 
			this.ArtistNameTXTBox.Location = new System.Drawing.Point(4, 3);
			this.ArtistNameTXTBox.Name = "ArtistNameTXTBox";
			this.ArtistNameTXTBox.Size = new System.Drawing.Size(262, 19);
			this.ArtistNameTXTBox.TabIndex = 0;
			// 
			// EditArtistNameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(270, 25);
			this.Controls.Add(this.ArtistNameTXTBox);
			this.Name = "EditArtistNameForm";
			this.Text = "EditArtistNameForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditArtistNameForm_FormClosing);
			this.Load += new System.EventHandler(this.EditArtistNameForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox ArtistNameTXTBox;
	}
}