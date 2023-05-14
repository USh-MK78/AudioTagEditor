
namespace AudioTagEditor
{
    partial class ArtistNameCollectionEditor
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
            this.components = new System.ComponentModel.Container();
            this.InputArtistName_comboBox = new System.Windows.Forms.ComboBox();
            this.ArtistName_listBox = new System.Windows.Forms.ListBox();
            this.ArtistNameCE_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UseCommasChk = new System.Windows.Forms.CheckBox();
            this.ArtistNameCE_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputArtistName_comboBox
            // 
            this.InputArtistName_comboBox.FormattingEnabled = true;
            this.InputArtistName_comboBox.Location = new System.Drawing.Point(12, 12);
            this.InputArtistName_comboBox.Name = "InputArtistName_comboBox";
            this.InputArtistName_comboBox.Size = new System.Drawing.Size(251, 20);
            this.InputArtistName_comboBox.TabIndex = 0;
            // 
            // ArtistName_listBox
            // 
            this.ArtistName_listBox.ContextMenuStrip = this.ArtistNameCE_contextMenuStrip;
            this.ArtistName_listBox.FormattingEnabled = true;
            this.ArtistName_listBox.ItemHeight = 12;
            this.ArtistName_listBox.Location = new System.Drawing.Point(12, 38);
            this.ArtistName_listBox.Name = "ArtistName_listBox";
            this.ArtistName_listBox.Size = new System.Drawing.Size(251, 220);
            this.ArtistName_listBox.TabIndex = 1;
            this.ArtistName_listBox.DoubleClick += new System.EventHandler(this.ArtistName_listBox_DoubleClick);
            // 
            // ArtistNameCE_contextMenuStrip
            // 
            this.ArtistNameCE_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.ArtistNameCE_contextMenuStrip.Name = "contextMenuStrip1";
            this.ArtistNameCE_contextMenuStrip.Size = new System.Drawing.Size(102, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UseCommasChk
            // 
            this.UseCommasChk.AutoSize = true;
            this.UseCommasChk.Location = new System.Drawing.Point(174, 267);
            this.UseCommasChk.Name = "UseCommasChk";
            this.UseCommasChk.Size = new System.Drawing.Size(90, 16);
            this.UseCommasChk.TabIndex = 7;
            this.UseCommasChk.Text = "Use commas";
            this.UseCommasChk.UseVisualStyleBackColor = true;
            // 
            // ArtistNameCollectionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 295);
            this.Controls.Add(this.UseCommasChk);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ArtistName_listBox);
            this.Controls.Add(this.InputArtistName_comboBox);
            this.Name = "ArtistNameCollectionEditor";
            this.Text = "ArtistNameCollectionEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArtistNameCollectionEditor_FormClosing);
            this.Load += new System.EventHandler(this.ArtistNameCollectionEditor_Load);
            this.ArtistNameCE_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox InputArtistName_comboBox;
        private System.Windows.Forms.ListBox ArtistName_listBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip ArtistNameCE_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.CheckBox UseCommasChk;
    }
}