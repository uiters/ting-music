using System.Drawing;

namespace Music
{
    partial class Song
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Song));
            this.lblSongName = new System.Windows.Forms.Label();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnOption = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPlay = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBoxSong = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.BackColor = System.Drawing.Color.Transparent;
            this.lblSongName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSongName.Location = new System.Drawing.Point(118, 23);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(79, 18);
            this.lblSongName.TabIndex = 55;
            this.lblSongName.Text = "1.Attention";
            // 
            // lblArtistName
            // 
            this.lblArtistName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArtistName.AutoEllipsis = true;
            this.lblArtistName.BackColor = System.Drawing.Color.Transparent;
            this.lblArtistName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblArtistName.Location = new System.Drawing.Point(396, 24);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(241, 16);
            this.lblArtistName.TabIndex = 56;
            this.lblArtistName.Text = "Charlie Puth";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalTime.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalTime.Location = new System.Drawing.Point(758, 23);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(45, 18);
            this.lblTotalTime.TabIndex = 57;
            this.lblTotalTime.Text = "03:58";
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory.AutoEllipsis = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCategory.Location = new System.Drawing.Point(643, 25);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(109, 16);
            this.lblCategory.TabIndex = 59;
            this.lblCategory.Text = "Pop";
            // 
            // btnOption
            // 
            this.btnOption.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOption.BackColor = System.Drawing.Color.Transparent;
            this.btnOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOption.BorderRadius = 0;
            this.btnOption.ButtonText = "";
            this.btnOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOption.DisabledColor = System.Drawing.Color.Gray;
            this.btnOption.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOption.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOption.Iconimage")));
            this.btnOption.Iconimage_right = null;
            this.btnOption.Iconimage_right_Selected = null;
            this.btnOption.Iconimage_Selected = null;
            this.btnOption.IconMarginLeft = 0;
            this.btnOption.IconMarginRight = 0;
            this.btnOption.IconRightVisible = true;
            this.btnOption.IconRightZoom = 0D;
            this.btnOption.IconVisible = true;
            this.btnOption.IconZoom = 32D;
            this.btnOption.IsTab = false;
            this.btnOption.Location = new System.Drawing.Point(808, 14);
            this.btnOption.Name = "btnOption";
            this.btnOption.Normalcolor = System.Drawing.Color.Transparent;
            this.btnOption.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnOption.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnOption.selected = false;
            this.btnOption.Size = new System.Drawing.Size(32, 32);
            this.btnOption.TabIndex = 58;
            this.btnOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOption.Textcolor = System.Drawing.Color.White;
            this.btnOption.TextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnOption.Click += new System.EventHandler(this.BtnOption_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.ImageActive = null;
            this.btnPlay.Location = new System.Drawing.Point(68, 11);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 40);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 54;
            this.btnPlay.TabStop = false;
            this.btnPlay.Zoom = 10;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click_1);
            // 
            // pictureBoxSong
            // 
            this.pictureBoxSong.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxSong.Name = "pictureBoxSong";
            this.pictureBoxSong.Size = new System.Drawing.Size(55, 55);
            this.pictureBoxSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSong.TabIndex = 0;
            this.pictureBoxSong.TabStop = false;
            // 
            // Song
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lblArtistName);
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pictureBoxSong);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Song";
            this.Size = new System.Drawing.Size(842, 60);
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSong;
        private Bunifu.Framework.UI.BunifuImageButton btnPlay;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.Label lblTotalTime;
        private Bunifu.Framework.UI.BunifuFlatButton btnOption;
        private System.Windows.Forms.Label lblCategory;
        private static readonly Image pause = fMusic.pause;
        private static readonly Image play = fMusic.play;
    }
}
