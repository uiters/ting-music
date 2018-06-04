namespace Music
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.cbMinute = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNowPlaying = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnShutDown = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMyMusic = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.BackColor = System.Drawing.Color.White;
            this.metroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox1.ForeColor = System.Drawing.Color.White;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "English",
            "Vietnamese"});
            this.metroComboBox1.Location = new System.Drawing.Point(71, 100);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(242, 29);
            this.metroComboBox1.TabIndex = 36;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroComboBox1.UseCustomBackColor = true;
            this.metroComboBox1.UseCustomForeColor = true;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.UseStyleColors = true;
            // 
            // cbMinute
            // 
            this.cbMinute.BackColor = System.Drawing.Color.White;
            this.cbMinute.Enabled = false;
            this.cbMinute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMinute.ForeColor = System.Drawing.Color.White;
            this.cbMinute.FormattingEnabled = true;
            this.cbMinute.ItemHeight = 23;
            this.cbMinute.Items.AddRange(new object[] {
            "15",
            "30",
            "45",
            "60",
            "90",
            "120"});
            this.cbMinute.Location = new System.Drawing.Point(71, 177);
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(88, 29);
            this.cbMinute.TabIndex = 39;
            this.cbMinute.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbMinute.UseCustomBackColor = true;
            this.cbMinute.UseCustomForeColor = true;
            this.cbMinute.UseSelectable = true;
            this.cbMinute.UseStyleColors = true;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.label3.Location = new System.Drawing.Point(165, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 85;
            this.label3.Text = "Minutes";
            // 
            // lblTime
            // 
            this.lblTime.AutoEllipsis = true;
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.lblTime.Location = new System.Drawing.Point(248, 182);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(44, 18);
            this.lblTime.TabIndex = 86;
            this.lblTime.Text = "15:06";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoEllipsis = true;
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.lblStatus.Location = new System.Drawing.Point(292, 143);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(26, 17);
            this.lblStatus.TabIndex = 87;
            this.lblStatus.Text = "On";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "     Your local music files";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 45D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(71, 220);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(239, 40);
            this.bunifuFlatButton2.TabIndex = 90;
            this.bunifuFlatButton2.Text = "     Your local music files";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnNowPlaying
            // 
            this.btnNowPlaying.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnNowPlaying.BackColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNowPlaying.BorderRadius = 0;
            this.btnNowPlaying.ButtonText = "     Check for Updates";
            this.btnNowPlaying.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNowPlaying.DisabledColor = System.Drawing.Color.Gray;
            this.btnNowPlaying.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNowPlaying.Iconimage")));
            this.btnNowPlaying.Iconimage_right = null;
            this.btnNowPlaying.Iconimage_right_Selected = null;
            this.btnNowPlaying.Iconimage_Selected = null;
            this.btnNowPlaying.IconMarginLeft = 0;
            this.btnNowPlaying.IconMarginRight = 0;
            this.btnNowPlaying.IconRightVisible = true;
            this.btnNowPlaying.IconRightZoom = 0D;
            this.btnNowPlaying.IconVisible = true;
            this.btnNowPlaying.IconZoom = 45D;
            this.btnNowPlaying.IsTab = false;
            this.btnNowPlaying.Location = new System.Drawing.Point(71, 274);
            this.btnNowPlaying.Name = "btnNowPlaying";
            this.btnNowPlaying.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNowPlaying.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnNowPlaying.selected = false;
            this.btnNowPlaying.Size = new System.Drawing.Size(239, 40);
            this.btnNowPlaying.TabIndex = 89;
            this.btnNowPlaying.Text = "     Check for Updates";
            this.btnNowPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNowPlaying.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnNowPlaying.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNowPlaying.Click += new System.EventHandler(this.btnNowPlaying_Click);
            // 
            // btnShutDown
            // 
            this.btnShutDown.BackColor = System.Drawing.Color.Transparent;
            this.btnShutDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShutDown.BackgroundImage")));
            this.btnShutDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShutDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutDown.Location = new System.Drawing.Point(244, 139);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.OffColor = System.Drawing.Color.Gray;
            this.btnShutDown.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnShutDown.Size = new System.Drawing.Size(43, 25);
            this.btnShutDown.TabIndex = 38;
            this.btnShutDown.Value = false;
            this.btnShutDown.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch1_OnValueChange);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "     Shut down timer";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Enabled = false;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 45D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(71, 131);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(174, 40);
            this.bunifuFlatButton1.TabIndex = 37;
            this.bunifuFlatButton1.Text = "     Shut down timer";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnMyMusic
            // 
            this.btnMyMusic.Activecolor = System.Drawing.Color.Transparent;
            this.btnMyMusic.BackColor = System.Drawing.Color.Transparent;
            this.btnMyMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMyMusic.BorderRadius = 0;
            this.btnMyMusic.ButtonText = "     Language";
            this.btnMyMusic.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMyMusic.DisabledColor = System.Drawing.Color.Transparent;
            this.btnMyMusic.Enabled = false;
            this.btnMyMusic.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMyMusic.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMyMusic.Iconimage")));
            this.btnMyMusic.Iconimage_right = null;
            this.btnMyMusic.Iconimage_right_Selected = null;
            this.btnMyMusic.Iconimage_Selected = null;
            this.btnMyMusic.IconMarginLeft = 0;
            this.btnMyMusic.IconMarginRight = 0;
            this.btnMyMusic.IconRightVisible = true;
            this.btnMyMusic.IconRightZoom = 0D;
            this.btnMyMusic.IconVisible = true;
            this.btnMyMusic.IconZoom = 45D;
            this.btnMyMusic.IsTab = false;
            this.btnMyMusic.Location = new System.Drawing.Point(71, 58);
            this.btnMyMusic.Name = "btnMyMusic";
            this.btnMyMusic.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMyMusic.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnMyMusic.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnMyMusic.selected = false;
            this.btnMyMusic.Size = new System.Drawing.Size(131, 40);
            this.btnMyMusic.TabIndex = 34;
            this.btnMyMusic.Text = "     Language";
            this.btnMyMusic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyMusic.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnMyMusic.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lbStatus
            // 
            this.lbStatus.AutoEllipsis = true;
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.lbStatus.Location = new System.Drawing.Point(68, 329);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(53, 18);
            this.lbStatus.TabIndex = 91;
            this.lbStatus.Text = "Status:";
            this.lbStatus.Visible = false;
            // 
            // label
            // 
            this.label.AutoEllipsis = true;
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.label.Location = new System.Drawing.Point(127, 329);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 18);
            this.label.TabIndex = 92;
            this.label.Text = "Pedding";
            this.label.Visible = false;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.btnNowPlaying);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMinute);
            this.Controls.Add(this.btnShutDown);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.btnMyMusic);
            this.Name = "Setting";
            this.Size = new System.Drawing.Size(850, 474);
            this.Load += new System.EventHandler(this.Setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnMyMusic;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuiOSSwitch btnShutDown;
        private MetroFramework.Controls.MetroComboBox cbMinute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblStatus;
        private Bunifu.Framework.UI.BunifuFlatButton btnNowPlaying;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label;
    }
}
