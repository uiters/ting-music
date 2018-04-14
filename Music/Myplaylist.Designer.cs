namespace Music
{
    partial class Myplaylist
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
            this.labelPlaylistName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPlaylistName
            // 
            this.labelPlaylistName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlaylistName.AutoEllipsis = true;
            this.labelPlaylistName.BackColor = System.Drawing.Color.Transparent;
            this.labelPlaylistName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPlaylistName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaylistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.labelPlaylistName.Location = new System.Drawing.Point(12, 186);
            this.labelPlaylistName.Name = "labelPlaylistName";
            this.labelPlaylistName.Size = new System.Drawing.Size(196, 16);
            this.labelPlaylistName.TabIndex = 63;
            this.labelPlaylistName.Text = "ndc07";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 10);
            this.label1.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(41, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 10);
            this.label2.TabIndex = 66;
            // 
            // btnImage
            // 
            this.btnImage.BackgroundImage = global::Music.Properties.Resources.myPlaylist;
            this.btnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Location = new System.Drawing.Point(10, 29);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(200, 150);
            this.btnImage.TabIndex = 64;
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // Myplaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.labelPlaylistName);
            this.Name = "Myplaylist";
            this.Size = new System.Drawing.Size(220, 209);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label labelPlaylistName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
