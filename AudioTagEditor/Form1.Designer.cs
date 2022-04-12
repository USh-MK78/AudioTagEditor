
namespace AudioTagEditor
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MusicList_listBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AudioTagPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteAlbumCoverBtn = new System.Windows.Forms.Button();
            this.AddAlbumCoverBtn = new System.Windows.Forms.Button();
            this.AlbumCoverComboBox = new System.Windows.Forms.ComboBox();
            this.AlbumCoverpictureBox = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editImageInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editzplFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumCoverpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.playlistToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectDirectoryToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // selectDirectoryToolStripMenuItem
            // 
            this.selectDirectoryToolStripMenuItem.Name = "selectDirectoryToolStripMenuItem";
            this.selectDirectoryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.selectDirectoryToolStripMenuItem.Text = "Select Directory";
            this.selectDirectoryToolStripMenuItem.Click += new System.EventHandler(this.selectDirectoryToolStripMenuItem_Click);
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editzplFileToolStripMenuItem,
            this.createPlaylistToolStripMenuItem});
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.playlistToolStripMenuItem.Text = "Playlist";
            // 
            // MusicList_listBox
            // 
            this.MusicList_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MusicList_listBox.FormattingEnabled = true;
            this.MusicList_listBox.ItemHeight = 12;
            this.MusicList_listBox.Location = new System.Drawing.Point(0, 0);
            this.MusicList_listBox.Name = "MusicList_listBox";
            this.MusicList_listBox.Size = new System.Drawing.Size(537, 404);
            this.MusicList_listBox.TabIndex = 2;
            this.MusicList_listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(352, 404);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AudioTagPropertyGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(344, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tag info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AudioTagPropertyGrid
            // 
            this.AudioTagPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AudioTagPropertyGrid.Location = new System.Drawing.Point(3, 3);
            this.AudioTagPropertyGrid.Name = "AudioTagPropertyGrid";
            this.AudioTagPropertyGrid.Size = new System.Drawing.Size(338, 372);
            this.AudioTagPropertyGrid.TabIndex = 0;
            this.AudioTagPropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.DeleteAlbumCoverBtn);
            this.tabPage2.Controls.Add(this.AddAlbumCoverBtn);
            this.tabPage2.Controls.Add(this.AlbumCoverComboBox);
            this.tabPage2.Controls.Add(this.AlbumCoverpictureBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(344, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Album Cover";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Album Cover :";
            // 
            // DeleteAlbumCoverBtn
            // 
            this.DeleteAlbumCoverBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteAlbumCoverBtn.Location = new System.Drawing.Point(317, 6);
            this.DeleteAlbumCoverBtn.Name = "DeleteAlbumCoverBtn";
            this.DeleteAlbumCoverBtn.Size = new System.Drawing.Size(23, 23);
            this.DeleteAlbumCoverBtn.TabIndex = 3;
            this.DeleteAlbumCoverBtn.Text = "-";
            this.DeleteAlbumCoverBtn.UseVisualStyleBackColor = true;
            this.DeleteAlbumCoverBtn.Click += new System.EventHandler(this.DeleteAlbumCoverBtn_Click);
            // 
            // AddAlbumCoverBtn
            // 
            this.AddAlbumCoverBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAlbumCoverBtn.Location = new System.Drawing.Point(286, 6);
            this.AddAlbumCoverBtn.Name = "AddAlbumCoverBtn";
            this.AddAlbumCoverBtn.Size = new System.Drawing.Size(23, 23);
            this.AddAlbumCoverBtn.TabIndex = 2;
            this.AddAlbumCoverBtn.Text = "+";
            this.AddAlbumCoverBtn.UseVisualStyleBackColor = true;
            this.AddAlbumCoverBtn.Click += new System.EventHandler(this.AddAlbumCoverBtn_Click);
            // 
            // AlbumCoverComboBox
            // 
            this.AlbumCoverComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlbumCoverComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlbumCoverComboBox.FormattingEnabled = true;
            this.AlbumCoverComboBox.Location = new System.Drawing.Point(89, 8);
            this.AlbumCoverComboBox.Name = "AlbumCoverComboBox";
            this.AlbumCoverComboBox.Size = new System.Drawing.Size(191, 20);
            this.AlbumCoverComboBox.TabIndex = 1;
            this.AlbumCoverComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AlbumCoverpictureBox
            // 
            this.AlbumCoverpictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlbumCoverpictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlbumCoverpictureBox.Location = new System.Drawing.Point(3, 35);
            this.AlbumCoverpictureBox.Name = "AlbumCoverpictureBox";
            this.AlbumCoverpictureBox.Size = new System.Drawing.Size(338, 340);
            this.AlbumCoverpictureBox.TabIndex = 0;
            this.AlbumCoverpictureBox.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MusicList_listBox);
            this.splitContainer1.Size = new System.Drawing.Size(893, 404);
            this.splitContainer1.SplitterDistance = 352;
            this.splitContainer1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editImageInfoToolStripMenuItem,
            this.exportImageToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 48);
            // 
            // editImageInfoToolStripMenuItem
            // 
            this.editImageInfoToolStripMenuItem.Name = "editImageInfoToolStripMenuItem";
            this.editImageInfoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.editImageInfoToolStripMenuItem.Text = "Edit image info";
            this.editImageInfoToolStripMenuItem.Click += new System.EventHandler(this.editImageInfoToolStripMenuItem_Click);
            // 
            // exportImageToolStripMenuItem
            // 
            this.exportImageToolStripMenuItem.Name = "exportImageToolStripMenuItem";
            this.exportImageToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exportImageToolStripMenuItem.Text = "Export Image";
            this.exportImageToolStripMenuItem.Click += new System.EventHandler(this.exportImageToolStripMenuItem_Click);
            // 
            // editzplFileToolStripMenuItem
            // 
            this.editzplFileToolStripMenuItem.Name = "editzplFileToolStripMenuItem";
            this.editzplFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editzplFileToolStripMenuItem.Text = "Edit .zpl file";
            this.editzplFileToolStripMenuItem.Click += new System.EventHandler(this.editzplFileToolStripMenuItem_Click);
            // 
            // createPlaylistToolStripMenuItem
            // 
            this.createPlaylistToolStripMenuItem.Name = "createPlaylistToolStripMenuItem";
            this.createPlaylistToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createPlaylistToolStripMenuItem.Text = "Create Playlist";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 428);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "AudioTagEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumCoverpictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectDirectoryToolStripMenuItem;
        private System.Windows.Forms.ListBox MusicList_listBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PropertyGrid AudioTagPropertyGrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox AlbumCoverpictureBox;
        private System.Windows.Forms.ComboBox AlbumCoverComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteAlbumCoverBtn;
        private System.Windows.Forms.Button AddAlbumCoverBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editImageInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editzplFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPlaylistToolStripMenuItem;
    }
}

