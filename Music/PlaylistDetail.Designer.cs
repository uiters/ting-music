﻿namespace Music
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
            this.panelHead = new System.Windows.Forms.Panel();
            this.image = new System.Windows.Forms.PictureBox();
            this.panelSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.Panel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRename = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPlayAll = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTotalSong = new System.Windows.Forms.Label();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.background.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHead.Controls.Add(this.background);
            this.panelHead.Controls.Add(this.image);
            this.panelHead.Controls.Add(this.label1);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(850, 158);
            this.panelHead.TabIndex = 0;
            // 
            // image
            // 
            this.image.Image = global::Music.Properties.Resources.myMusic;
            this.image.Location = new System.Drawing.Point(3, 3);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(152, 152);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 69;
            this.image.TabStop = false;
            // 
            // panelSongs
            // 
            this.panelSongs.AutoScroll = true;
            this.panelSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSongs.Location = new System.Drawing.Point(0, 158);
            this.panelSongs.Name = "panelSongs";
            this.panelSongs.Size = new System.Drawing.Size(850, 316);
            this.panelSongs.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 158);
            this.label1.TabIndex = 80;
            // 
            // background
            // 
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background.Controls.Add(this.btnDelete);
            this.background.Controls.Add(this.btnRename);
            this.background.Controls.Add(this.btnPlayAll);
            this.background.Controls.Add(this.lblTotalSong);
            this.background.Controls.Add(this.lblPlaylistName);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(158, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(692, 158);
            this.background.TabIndex = 81;
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.Transparent;
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
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
            this.btnDelete.Location = new System.Drawing.Point(361, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(107, 29);
            this.btnDelete.TabIndex = 91;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnDelete.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRename
            // 
            this.btnRename.Activecolor = System.Drawing.Color.Transparent;
            this.btnRename.BackColor = System.Drawing.Color.Gainsboro;
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
            this.btnRename.Location = new System.Drawing.Point(199, 123);
            this.btnRename.Name = "btnRename";
            this.btnRename.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnRename.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRename.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRename.selected = false;
            this.btnRename.Size = new System.Drawing.Size(107, 29);
            this.btnRename.TabIndex = 90;
            this.btnRename.Text = "Rename";
            this.btnRename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRename.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnRename.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnPlayAll
            // 
            this.btnPlayAll.Activecolor = System.Drawing.Color.Transparent;
            this.btnPlayAll.BackColor = System.Drawing.Color.Gainsboro;
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
            this.btnPlayAll.Location = new System.Drawing.Point(37, 123);
            this.btnPlayAll.Name = "btnPlayAll";
            this.btnPlayAll.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnPlayAll.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPlayAll.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPlayAll.selected = false;
            this.btnPlayAll.Size = new System.Drawing.Size(107, 29);
            this.btnPlayAll.TabIndex = 89;
            this.btnPlayAll.Text = "Play all";
            this.btnPlayAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlayAll.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnPlayAll.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAll.Click += new System.EventHandler(this.btnPlayAll_Click_2);
            // 
            // lblTotalSong
            // 
            this.lblTotalSong.AutoEllipsis = true;
            this.lblTotalSong.AutoSize = true;
            this.lblTotalSong.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalSong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.lblTotalSong.Location = new System.Drawing.Point(34, 69);
            this.lblTotalSong.Name = "lblTotalSong";
            this.lblTotalSong.Size = new System.Drawing.Size(56, 14);
            this.lblTotalSong.TabIndex = 88;
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
            this.lblPlaylistName.Location = new System.Drawing.Point(31, 20);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(104, 36);
            this.lblPlaylistName.TabIndex = 87;
            this.lblPlaylistName.Text = "ndc07";
            // 
            // PlaylistDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelSongs);
            this.Controls.Add(this.panelHead);
            this.Name = "PlaylistDetail";
            this.Size = new System.Drawing.Size(850, 474);
            this.panelHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.FlowLayoutPanel panelSongs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel background;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnRename;
        private Bunifu.Framework.UI.BunifuFlatButton btnPlayAll;
        private System.Windows.Forms.Label lblTotalSong;
        public System.Windows.Forms.Label lblPlaylistName;
    }
}