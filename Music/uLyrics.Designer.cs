﻿namespace Music
{
    partial class uLyrics
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uLyrics));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblSongName = new System.Windows.Forms.Label();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.pictureBoxSong = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblLyrics = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSong)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnBack);
            this.panelLeft.Controls.Add(this.lblSongName);
            this.panelLeft.Controls.Add(this.lblArtistName);
            this.panelLeft.Controls.Add(this.pictureBoxSong);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(381, 474);
            this.panelLeft.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.BorderRadius = 0;
            this.btnBack.ButtonText = "";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledColor = System.Drawing.Color.Gray;
            this.btnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBack.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBack.Iconimage")));
            this.btnBack.Iconimage_right = null;
            this.btnBack.Iconimage_right_Selected = null;
            this.btnBack.Iconimage_Selected = null;
            this.btnBack.IconMarginLeft = 0;
            this.btnBack.IconMarginRight = 0;
            this.btnBack.IconRightVisible = true;
            this.btnBack.IconRightZoom = 0D;
            this.btnBack.IconVisible = true;
            this.btnBack.IconZoom = 30D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBack.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(16, 16);
            this.btnBack.TabIndex = 54;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSongName
            // 
            this.lblSongName.AutoEllipsis = true;
            this.lblSongName.BackColor = System.Drawing.Color.Transparent;
            this.lblSongName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.ForeColor = System.Drawing.Color.White;
            this.lblSongName.Location = new System.Drawing.Point(0, 45);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(381, 19);
            this.lblSongName.TabIndex = 42;
            this.lblSongName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblArtistName
            // 
            this.lblArtistName.AutoEllipsis = true;
            this.lblArtistName.BackColor = System.Drawing.Color.Transparent;
            this.lblArtistName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistName.ForeColor = System.Drawing.Color.White;
            this.lblArtistName.Location = new System.Drawing.Point(28, 11);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(324, 22);
            this.lblArtistName.TabIndex = 41;
            this.lblArtistName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxSong
            // 
            this.pictureBoxSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSong.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSong.Image")));
            this.pictureBoxSong.Location = new System.Drawing.Point(39, 115);
            this.pictureBoxSong.Name = "pictureBoxSong";
            this.pictureBoxSong.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSong.TabIndex = 43;
            this.pictureBoxSong.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.AutoScroll = true;
            this.panelRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRight.Controls.Add(this.lblLyrics);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(381, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(469, 474);
            this.panelRight.TabIndex = 1;
            // 
            // lblLyrics
            // 
            this.lblLyrics.AutoSize = true;
            this.lblLyrics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLyrics.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLyrics.ForeColor = System.Drawing.Color.White;
            this.lblLyrics.Location = new System.Drawing.Point(2, 12);
            this.lblLyrics.Name = "lblLyrics";
            this.lblLyrics.Size = new System.Drawing.Size(0, 17);
            this.lblLyrics.TabIndex = 0;
            this.lblLyrics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 300;
            this.bunifuElipse1.TargetControl = this.pictureBoxSong;
            // 
            // Lyrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.DoubleBuffered = true;
            this.Name = "Lyrics";
            this.Size = new System.Drawing.Size(850, 474);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSong)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.Label lblLyrics;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
        public System.Windows.Forms.PictureBox pictureBoxSong;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}