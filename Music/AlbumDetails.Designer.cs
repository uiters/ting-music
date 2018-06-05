namespace Music
{
    partial class AlbumDetails
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
            this.image = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalSong = new System.Windows.Forms.Label();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.background.SuspendLayout();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.Image = global::Music.Properties.Resources.myMusic;
            this.image.Location = new System.Drawing.Point(3, 3);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(152, 152);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 70;
            this.image.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 158);
            this.label1.TabIndex = 81;
            // 
            // background
            // 
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background.Controls.Add(this.label2);
            this.background.Controls.Add(this.lblTotalSong);
            this.background.Controls.Add(this.lblPlaylistName);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(158, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(692, 158);
            this.background.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(51, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 87;
            this.label2.Text = "songs";
            // 
            // lblTotalSong
            // 
            this.lblTotalSong.AutoEllipsis = true;
            this.lblTotalSong.AutoSize = true;
            this.lblTotalSong.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalSong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.lblTotalSong.Location = new System.Drawing.Point(32, 67);
            this.lblTotalSong.Name = "lblTotalSong";
            this.lblTotalSong.Size = new System.Drawing.Size(21, 14);
            this.lblTotalSong.TabIndex = 86;
            this.lblTotalSong.Text = "69";
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoEllipsis = true;
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaylistName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlaylistName.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.lblPlaylistName.Location = new System.Drawing.Point(29, 18);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(104, 36);
            this.lblPlaylistName.TabIndex = 85;
            this.lblPlaylistName.Text = "ndc07";
            // 
            // AlbumDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.background);
            this.Controls.Add(this.image);
            this.Controls.Add(this.label1);
            this.Name = "AlbumDetails";
            this.Size = new System.Drawing.Size(850, 158);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Label lblTotalSong;
        public System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.Label label2;
    }
}
