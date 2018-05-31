namespace Music
{
    partial class PlaylistDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistDetail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRename = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddSongs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPlayAll = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTotalSong = new System.Windows.Forms.Label();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnRename);
            this.panel1.Controls.Add(this.btnAddSongs);
            this.panel1.Controls.Add(this.btnPlayAll);
            this.panel1.Controls.Add(this.lblTotalSong);
            this.panel1.Controls.Add(this.lblPlaylistName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 181);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelete.Iconimage")));
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = false;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 30D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(596, 116);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(107, 29);
            this.btnDelete.TabIndex = 79;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnDelete.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRename
            // 
            this.btnRename.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnRename.BackColor = System.Drawing.Color.Transparent;
            this.btnRename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRename.BorderRadius = 0;
            this.btnRename.ButtonText = "Rename";
            this.btnRename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRename.DisabledColor = System.Drawing.Color.Gray;
            this.btnRename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnRename.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRename.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRename.Iconimage")));
            this.btnRename.Iconimage_right = null;
            this.btnRename.Iconimage_right_Selected = null;
            this.btnRename.Iconimage_Selected = null;
            this.btnRename.IconMarginLeft = 0;
            this.btnRename.IconMarginRight = 0;
            this.btnRename.IconRightVisible = false;
            this.btnRename.IconRightZoom = 0D;
            this.btnRename.IconVisible = true;
            this.btnRename.IconZoom = 30D;
            this.btnRename.IsTab = false;
            this.btnRename.Location = new System.Drawing.Point(457, 116);
            this.btnRename.Name = "btnRename";
            this.btnRename.Normalcolor = System.Drawing.Color.Transparent;
            this.btnRename.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRename.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRename.selected = false;
            this.btnRename.Size = new System.Drawing.Size(107, 29);
            this.btnRename.TabIndex = 78;
            this.btnRename.Text = "Rename";
            this.btnRename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRename.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnRename.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnAddSongs
            // 
            this.btnAddSongs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnAddSongs.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSongs.BorderRadius = 0;
            this.btnAddSongs.ButtonText = "Add to";
            this.btnAddSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSongs.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddSongs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnAddSongs.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddSongs.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddSongs.Iconimage")));
            this.btnAddSongs.Iconimage_right = null;
            this.btnAddSongs.Iconimage_right_Selected = null;
            this.btnAddSongs.Iconimage_Selected = null;
            this.btnAddSongs.IconMarginLeft = 0;
            this.btnAddSongs.IconMarginRight = 0;
            this.btnAddSongs.IconRightVisible = false;
            this.btnAddSongs.IconRightZoom = 0D;
            this.btnAddSongs.IconVisible = true;
            this.btnAddSongs.IconZoom = 30D;
            this.btnAddSongs.IsTab = false;
            this.btnAddSongs.Location = new System.Drawing.Point(318, 116);
            this.btnAddSongs.Name = "btnAddSongs";
            this.btnAddSongs.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddSongs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddSongs.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddSongs.selected = false;
            this.btnAddSongs.Size = new System.Drawing.Size(107, 29);
            this.btnAddSongs.TabIndex = 77;
            this.btnAddSongs.Text = "Add to";
            this.btnAddSongs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddSongs.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnAddSongs.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSongs.Click += new System.EventHandler(this.btnAddSongs_Click);
            // 
            // btnPlayAll
            // 
            this.btnPlayAll.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnPlayAll.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayAll.BorderRadius = 0;
            this.btnPlayAll.ButtonText = "Play all";
            this.btnPlayAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayAll.DisabledColor = System.Drawing.Color.Gray;
            this.btnPlayAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnPlayAll.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPlayAll.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPlayAll.Iconimage")));
            this.btnPlayAll.Iconimage_right = null;
            this.btnPlayAll.Iconimage_right_Selected = null;
            this.btnPlayAll.Iconimage_Selected = null;
            this.btnPlayAll.IconMarginLeft = 0;
            this.btnPlayAll.IconMarginRight = 0;
            this.btnPlayAll.IconRightVisible = false;
            this.btnPlayAll.IconRightZoom = 0D;
            this.btnPlayAll.IconVisible = true;
            this.btnPlayAll.IconZoom = 30D;
            this.btnPlayAll.IsTab = false;
            this.btnPlayAll.Location = new System.Drawing.Point(183, 116);
            this.btnPlayAll.Name = "btnPlayAll";
            this.btnPlayAll.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPlayAll.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPlayAll.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPlayAll.selected = false;
            this.btnPlayAll.Size = new System.Drawing.Size(107, 29);
            this.btnPlayAll.TabIndex = 76;
            this.btnPlayAll.Text = "Play all";
            this.btnPlayAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlayAll.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnPlayAll.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAll.Click += new System.EventHandler(this.btnPlayAll_Click);
            // 
            // lblTotalSong
            // 
            this.lblTotalSong.AutoEllipsis = true;
            this.lblTotalSong.AutoSize = true;
            this.lblTotalSong.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalSong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.lblTotalSong.Location = new System.Drawing.Point(180, 73);
            this.lblTotalSong.Name = "lblTotalSong";
            this.lblTotalSong.Size = new System.Drawing.Size(56, 14);
            this.lblTotalSong.TabIndex = 73;
            this.lblTotalSong.Text = "69 songs";
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoEllipsis = true;
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaylistName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlaylistName.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.lblPlaylistName.Location = new System.Drawing.Point(177, 24);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(104, 36);
            this.lblPlaylistName.TabIndex = 72;
            this.lblPlaylistName.Text = "ndc07";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(38, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 8);
            this.label2.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 8);
            this.label1.TabIndex = 70;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Music.Properties.Resources.myPlaylist;
            this.pictureBox.Location = new System.Drawing.Point(12, 29);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(140, 140);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 69;
            this.pictureBox.TabStop = false;
            // 
            // panelSongs
            // 
            this.panelSongs.AutoScroll = true;
            this.panelSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSongs.Location = new System.Drawing.Point(0, 181);
            this.panelSongs.Name = "panelSongs";
            this.panelSongs.Size = new System.Drawing.Size(850, 293);
            this.panelSongs.TabIndex = 8;
            // 
            // PlaylistDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSongs);
            this.Controls.Add(this.panel1);
            this.Name = "PlaylistDetail";
            this.Size = new System.Drawing.Size(850, 474);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblTotalSong;
        private System.Windows.Forms.FlowLayoutPanel panelSongs;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnRename;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddSongs;
        private Bunifu.Framework.UI.BunifuFlatButton btnPlayAll;
        public System.Windows.Forms.Label lblPlaylistName;
    }
}
