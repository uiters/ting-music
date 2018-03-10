namespace Music
{
    partial class fMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMusic));
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelPlay = new System.Windows.Forms.Panel();
            this.btnPlay = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnShuffle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRepeat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnForward = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLyric = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVolume = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSlider2 = new Bunifu.Framework.UI.BunifuSlider();
            this.labelTimeTo = new System.Windows.Forms.Label();
            this.labelSongName = new System.Windows.Forms.Label();
            this.labelArtistName = new System.Windows.Forms.Label();
            this.labelTimeFrom = new System.Windows.Forms.Label();
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAbout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPlayList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSetting = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNowPlaying = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnRecentPlays = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMyMusic = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNavigationPanel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearchMusic = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txbSearchMusic = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.myMusic1 = new Music.MyMusic();
            this.panelBottom.SuspendLayout();
            this.panelPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.DimGray;
            this.panelBottom.Controls.Add(this.panelPlay);
            this.panelBottom.Controls.Add(this.btnLyric);
            this.panelBottom.Controls.Add(this.btnVolume);
            this.panelBottom.Controls.Add(this.bunifuSlider2);
            this.panelBottom.Controls.Add(this.labelTimeTo);
            this.panelBottom.Controls.Add(this.labelSongName);
            this.panelBottom.Controls.Add(this.labelArtistName);
            this.panelBottom.Controls.Add(this.labelTimeFrom);
            this.panelBottom.Controls.Add(this.bunifuSlider1);
            this.panelBottom.Controls.Add(this.pictureBox2);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 528);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1073, 90);
            this.panelBottom.TabIndex = 26;
            // 
            // panelPlay
            // 
            this.panelPlay.Controls.Add(this.btnPlay);
            this.panelPlay.Controls.Add(this.btnShuffle);
            this.panelPlay.Controls.Add(this.btnRepeat);
            this.panelPlay.Controls.Add(this.btnForward);
            this.panelPlay.Controls.Add(this.btnBack);
            this.panelPlay.Location = new System.Drawing.Point(586, 21);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(248, 67);
            this.panelPlay.TabIndex = 53;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Image = global::Music.Properties.Resources.pause;
            this.btnPlay.ImageActive = null;
            this.btnPlay.Location = new System.Drawing.Point(100, 8);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(50, 50);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 53;
            this.btnPlay.TabStop = false;
            this.btnPlay.Zoom = 10;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnShuffle.BackColor = System.Drawing.Color.Transparent;
            this.btnShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShuffle.BorderRadius = 0;
            this.btnShuffle.ButtonText = "";
            this.btnShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffle.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnShuffle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShuffle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShuffle.Iconimage")));
            this.btnShuffle.Iconimage_right = null;
            this.btnShuffle.Iconimage_right_Selected = null;
            this.btnShuffle.Iconimage_Selected = null;
            this.btnShuffle.IconMarginLeft = 0;
            this.btnShuffle.IconMarginRight = 0;
            this.btnShuffle.IconRightVisible = true;
            this.btnShuffle.IconRightZoom = 0D;
            this.btnShuffle.IconVisible = true;
            this.btnShuffle.IconZoom = 40D;
            this.btnShuffle.IsTab = false;
            this.btnShuffle.Location = new System.Drawing.Point(205, 17);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Normalcolor = System.Drawing.Color.Transparent;
            this.btnShuffle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnShuffle.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnShuffle.selected = false;
            this.btnShuffle.Size = new System.Drawing.Size(32, 32);
            this.btnShuffle.TabIndex = 57;
            this.btnShuffle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShuffle.Textcolor = System.Drawing.Color.White;
            this.btnShuffle.TextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnRepeat
            // 
            this.btnRepeat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnRepeat.BackColor = System.Drawing.Color.Transparent;
            this.btnRepeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRepeat.BorderRadius = 0;
            this.btnRepeat.ButtonText = "";
            this.btnRepeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepeat.DisabledColor = System.Drawing.Color.Gray;
            this.btnRepeat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRepeat.Iconimage = global::Music.Properties.Resources.repeat;
            this.btnRepeat.Iconimage_right = null;
            this.btnRepeat.Iconimage_right_Selected = null;
            this.btnRepeat.Iconimage_Selected = null;
            this.btnRepeat.IconMarginLeft = 0;
            this.btnRepeat.IconMarginRight = 0;
            this.btnRepeat.IconRightVisible = true;
            this.btnRepeat.IconRightZoom = 0D;
            this.btnRepeat.IconVisible = true;
            this.btnRepeat.IconZoom = 50D;
            this.btnRepeat.IsTab = false;
            this.btnRepeat.Location = new System.Drawing.Point(12, 17);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Normalcolor = System.Drawing.Color.Transparent;
            this.btnRepeat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRepeat.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnRepeat.selected = false;
            this.btnRepeat.Size = new System.Drawing.Size(32, 32);
            this.btnRepeat.TabIndex = 56;
            this.btnRepeat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepeat.Textcolor = System.Drawing.Color.White;
            this.btnRepeat.TextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // btnForward
            // 
            this.btnForward.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForward.BorderRadius = 0;
            this.btnForward.ButtonText = "";
            this.btnForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForward.DisabledColor = System.Drawing.Color.Gray;
            this.btnForward.Iconcolor = System.Drawing.Color.Transparent;
            this.btnForward.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnForward.Iconimage")));
            this.btnForward.Iconimage_right = null;
            this.btnForward.Iconimage_right_Selected = null;
            this.btnForward.Iconimage_Selected = null;
            this.btnForward.IconMarginLeft = 0;
            this.btnForward.IconMarginRight = 0;
            this.btnForward.IconRightVisible = true;
            this.btnForward.IconRightZoom = 0D;
            this.btnForward.IconVisible = true;
            this.btnForward.IconZoom = 32D;
            this.btnForward.IsTab = false;
            this.btnForward.Location = new System.Drawing.Point(167, 17);
            this.btnForward.Name = "btnForward";
            this.btnForward.Normalcolor = System.Drawing.Color.Transparent;
            this.btnForward.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnForward.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnForward.selected = false;
            this.btnForward.Size = new System.Drawing.Size(32, 32);
            this.btnForward.TabIndex = 55;
            this.btnForward.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForward.Textcolor = System.Drawing.Color.White;
            this.btnForward.TextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            // 
            // btnBack
            // 
            this.btnBack.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
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
            this.btnBack.IconZoom = 32D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(50, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBack.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(32, 32);
            this.btnBack.TabIndex = 54;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            // 
            // btnLyric
            // 
            this.btnLyric.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnLyric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLyric.BackColor = System.Drawing.Color.Transparent;
            this.btnLyric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLyric.BorderRadius = 0;
            this.btnLyric.ButtonText = "";
            this.btnLyric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLyric.DisabledColor = System.Drawing.Color.Gray;
            this.btnLyric.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLyric.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLyric.Iconimage")));
            this.btnLyric.Iconimage_right = null;
            this.btnLyric.Iconimage_right_Selected = null;
            this.btnLyric.Iconimage_Selected = null;
            this.btnLyric.IconMarginLeft = 0;
            this.btnLyric.IconMarginRight = 0;
            this.btnLyric.IconRightVisible = true;
            this.btnLyric.IconRightZoom = 0D;
            this.btnLyric.IconVisible = true;
            this.btnLyric.IconZoom = 50D;
            this.btnLyric.IsTab = false;
            this.btnLyric.Location = new System.Drawing.Point(873, 38);
            this.btnLyric.Name = "btnLyric";
            this.btnLyric.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLyric.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLyric.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnLyric.selected = false;
            this.btnLyric.Size = new System.Drawing.Size(32, 32);
            this.btnLyric.TabIndex = 47;
            this.btnLyric.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLyric.Textcolor = System.Drawing.Color.White;
            this.btnLyric.TextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            // 
            // btnVolume
            // 
            this.btnVolume.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolume.BackColor = System.Drawing.Color.Transparent;
            this.btnVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolume.BorderRadius = 0;
            this.btnVolume.ButtonText = "";
            this.btnVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolume.DisabledColor = System.Drawing.Color.Gray;
            this.btnVolume.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVolume.Iconimage = global::Music.Properties.Resources.volume_up;
            this.btnVolume.Iconimage_right = null;
            this.btnVolume.Iconimage_right_Selected = null;
            this.btnVolume.Iconimage_Selected = null;
            this.btnVolume.IconMarginLeft = 0;
            this.btnVolume.IconMarginRight = 0;
            this.btnVolume.IconRightVisible = true;
            this.btnVolume.IconRightZoom = 0D;
            this.btnVolume.IconVisible = true;
            this.btnVolume.IconZoom = 35D;
            this.btnVolume.IsTab = false;
            this.btnVolume.Location = new System.Drawing.Point(911, 38);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVolume.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnVolume.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnVolume.selected = false;
            this.btnVolume.Size = new System.Drawing.Size(32, 32);
            this.btnVolume.TabIndex = 46;
            this.btnVolume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolume.Textcolor = System.Drawing.Color.White;
            this.btnVolume.TextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // bunifuSlider2
            // 
            this.bunifuSlider2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSlider2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider2.BackgroudColor = System.Drawing.Color.White;
            this.bunifuSlider2.BorderRadius = 0;
            this.bunifuSlider2.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.bunifuSlider2.Location = new System.Drawing.Point(949, 40);
            this.bunifuSlider2.MaximumValue = 100;
            this.bunifuSlider2.Name = "bunifuSlider2";
            this.bunifuSlider2.Size = new System.Drawing.Size(112, 30);
            this.bunifuSlider2.TabIndex = 45;
            this.bunifuSlider2.Value = 10;
            // 
            // labelTimeTo
            // 
            this.labelTimeTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimeTo.AutoSize = true;
            this.labelTimeTo.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeTo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.labelTimeTo.Location = new System.Drawing.Point(1017, 0);
            this.labelTimeTo.Name = "labelTimeTo";
            this.labelTimeTo.Size = new System.Drawing.Size(50, 21);
            this.labelTimeTo.TabIndex = 41;
            this.labelTimeTo.Text = "03:20";
            // 
            // labelSongName
            // 
            this.labelSongName.AutoEllipsis = true;
            this.labelSongName.BackColor = System.Drawing.Color.Transparent;
            this.labelSongName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSongName.ForeColor = System.Drawing.Color.White;
            this.labelSongName.Location = new System.Drawing.Point(105, 61);
            this.labelSongName.Name = "labelSongName";
            this.labelSongName.Size = new System.Drawing.Size(461, 19);
            this.labelSongName.TabIndex = 40;
            this.labelSongName.Text = "Attention";
            // 
            // labelArtistName
            // 
            this.labelArtistName.AutoEllipsis = true;
            this.labelArtistName.BackColor = System.Drawing.Color.Transparent;
            this.labelArtistName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtistName.ForeColor = System.Drawing.Color.White;
            this.labelArtistName.Location = new System.Drawing.Point(105, 31);
            this.labelArtistName.Name = "labelArtistName";
            this.labelArtistName.Size = new System.Drawing.Size(461, 22);
            this.labelArtistName.TabIndex = 39;
            this.labelArtistName.Text = "Charlie Puth";
            // 
            // labelTimeFrom
            // 
            this.labelTimeFrom.AutoSize = true;
            this.labelTimeFrom.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.labelTimeFrom.Location = new System.Drawing.Point(102, 0);
            this.labelTimeFrom.Name = "labelTimeFrom";
            this.labelTimeFrom.Size = new System.Drawing.Size(50, 21);
            this.labelTimeFrom.TabIndex = 38;
            this.labelTimeFrom.Text = "00:50";
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.White;
            this.bunifuSlider1.BorderRadius = 0;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.bunifuSlider1.Location = new System.Drawing.Point(158, -1);
            this.bunifuSlider1.MaximumValue = 100;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(846, 30);
            this.bunifuSlider1.TabIndex = 37;
            this.bunifuSlider1.Value = 50;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Controls.Add(this.btnNavigationPanel);
            this.panelLeft.Controls.Add(this.label7);
            this.panelLeft.Controls.Add(this.label8);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(223, 528);
            this.panelLeft.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnPlayList);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnNowPlaying);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.btnRecentPlays);
            this.panel1.Controls.Add(this.btnMyMusic);
            this.panel1.Location = new System.Drawing.Point(9, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 319);
            this.panel1.TabIndex = 29;
            // 
            // btnAbout
            // 
            this.btnAbout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.BorderRadius = 0;
            this.btnAbout.ButtonText = "       About";
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.DisabledColor = System.Drawing.Color.Gray;
            this.btnAbout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAbout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAbout.Iconimage")));
            this.btnAbout.Iconimage_right = null;
            this.btnAbout.Iconimage_right_Selected = null;
            this.btnAbout.Iconimage_Selected = null;
            this.btnAbout.IconMarginLeft = 0;
            this.btnAbout.IconMarginRight = 0;
            this.btnAbout.IconRightVisible = true;
            this.btnAbout.IconRightZoom = 0D;
            this.btnAbout.IconVisible = true;
            this.btnAbout.IconZoom = 50D;
            this.btnAbout.IsTab = false;
            this.btnAbout.Location = new System.Drawing.Point(0, 271);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAbout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAbout.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnAbout.selected = false;
            this.btnAbout.Size = new System.Drawing.Size(205, 40);
            this.btnAbout.TabIndex = 36;
            this.btnAbout.Text = "       About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnAbout.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click_1);
            // 
            // btnPlayList
            // 
            this.btnPlayList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnPlayList.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayList.BorderRadius = 0;
            this.btnPlayList.ButtonText = "       Playlist";
            this.btnPlayList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayList.DisabledColor = System.Drawing.Color.Gray;
            this.btnPlayList.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPlayList.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPlayList.Iconimage")));
            this.btnPlayList.Iconimage_right = null;
            this.btnPlayList.Iconimage_right_Selected = null;
            this.btnPlayList.Iconimage_Selected = null;
            this.btnPlayList.IconMarginLeft = 0;
            this.btnPlayList.IconMarginRight = 0;
            this.btnPlayList.IconRightVisible = true;
            this.btnPlayList.IconRightZoom = 0D;
            this.btnPlayList.IconVisible = true;
            this.btnPlayList.IconZoom = 50D;
            this.btnPlayList.IsTab = false;
            this.btnPlayList.Location = new System.Drawing.Point(0, 138);
            this.btnPlayList.Name = "btnPlayList";
            this.btnPlayList.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPlayList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPlayList.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnPlayList.selected = false;
            this.btnPlayList.Size = new System.Drawing.Size(205, 40);
            this.btnPlayList.TabIndex = 36;
            this.btnPlayList.Text = "       Playlist";
            this.btnPlayList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayList.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnPlayList.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayList.Click += new System.EventHandler(this.btnPlayList_Click_1);
            // 
            // btnSetting
            // 
            this.btnSetting.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.BorderRadius = 0;
            this.btnSetting.ButtonText = "       Setting";
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.DisabledColor = System.Drawing.Color.Gray;
            this.btnSetting.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSetting.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSetting.Iconimage")));
            this.btnSetting.Iconimage_right = null;
            this.btnSetting.Iconimage_right_Selected = null;
            this.btnSetting.Iconimage_Selected = null;
            this.btnSetting.IconMarginLeft = 0;
            this.btnSetting.IconMarginRight = 0;
            this.btnSetting.IconRightVisible = true;
            this.btnSetting.IconRightZoom = 0D;
            this.btnSetting.IconVisible = true;
            this.btnSetting.IconZoom = 50D;
            this.btnSetting.IsTab = false;
            this.btnSetting.Location = new System.Drawing.Point(0, 225);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSetting.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSetting.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnSetting.selected = false;
            this.btnSetting.Size = new System.Drawing.Size(205, 40);
            this.btnSetting.TabIndex = 35;
            this.btnSetting.Text = "       Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnSetting.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click_1);
            // 
            // btnNowPlaying
            // 
            this.btnNowPlaying.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnNowPlaying.BackColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNowPlaying.BorderRadius = 0;
            this.btnNowPlaying.ButtonText = "       Now playing";
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
            this.btnNowPlaying.IconZoom = 50D;
            this.btnNowPlaying.IsTab = false;
            this.btnNowPlaying.Location = new System.Drawing.Point(0, 92);
            this.btnNowPlaying.Name = "btnNowPlaying";
            this.btnNowPlaying.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNowPlaying.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnNowPlaying.selected = false;
            this.btnNowPlaying.Size = new System.Drawing.Size(205, 40);
            this.btnNowPlaying.TabIndex = 35;
            this.btnNowPlaying.Text = "       Now playing";
            this.btnNowPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNowPlaying.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnNowPlaying.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNowPlaying.Click += new System.EventHandler(this.btnNowPlaying_Click_1);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(-1, 184);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(205, 35);
            this.bunifuSeparator2.TabIndex = 31;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // btnRecentPlays
            // 
            this.btnRecentPlays.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnRecentPlays.BackColor = System.Drawing.Color.Transparent;
            this.btnRecentPlays.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecentPlays.BorderRadius = 0;
            this.btnRecentPlays.ButtonText = "       Recent plays";
            this.btnRecentPlays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecentPlays.DisabledColor = System.Drawing.Color.Gray;
            this.btnRecentPlays.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRecentPlays.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRecentPlays.Iconimage")));
            this.btnRecentPlays.Iconimage_right = null;
            this.btnRecentPlays.Iconimage_right_Selected = null;
            this.btnRecentPlays.Iconimage_Selected = null;
            this.btnRecentPlays.IconMarginLeft = 0;
            this.btnRecentPlays.IconMarginRight = 0;
            this.btnRecentPlays.IconRightVisible = true;
            this.btnRecentPlays.IconRightZoom = 0D;
            this.btnRecentPlays.IconVisible = true;
            this.btnRecentPlays.IconZoom = 50D;
            this.btnRecentPlays.IsTab = false;
            this.btnRecentPlays.Location = new System.Drawing.Point(0, 46);
            this.btnRecentPlays.Name = "btnRecentPlays";
            this.btnRecentPlays.Normalcolor = System.Drawing.Color.Transparent;
            this.btnRecentPlays.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRecentPlays.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnRecentPlays.selected = false;
            this.btnRecentPlays.Size = new System.Drawing.Size(205, 40);
            this.btnRecentPlays.TabIndex = 34;
            this.btnRecentPlays.Text = "       Recent plays";
            this.btnRecentPlays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecentPlays.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnRecentPlays.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecentPlays.Click += new System.EventHandler(this.btnRecentPlays_Click_1);
            // 
            // btnMyMusic
            // 
            this.btnMyMusic.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnMyMusic.BackColor = System.Drawing.Color.Transparent;
            this.btnMyMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMyMusic.BorderRadius = 0;
            this.btnMyMusic.ButtonText = "       My music";
            this.btnMyMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyMusic.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnMyMusic.IconZoom = 50D;
            this.btnMyMusic.IsTab = false;
            this.btnMyMusic.Location = new System.Drawing.Point(0, 0);
            this.btnMyMusic.Name = "btnMyMusic";
            this.btnMyMusic.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMyMusic.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMyMusic.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnMyMusic.selected = false;
            this.btnMyMusic.Size = new System.Drawing.Size(205, 40);
            this.btnMyMusic.TabIndex = 33;
            this.btnMyMusic.Text = "       My music";
            this.btnMyMusic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyMusic.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnMyMusic.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyMusic.Click += new System.EventHandler(this.btnMyMusic_Click_1);
            // 
            // btnNavigationPanel
            // 
            this.btnNavigationPanel.Activecolor = System.Drawing.Color.White;
            this.btnNavigationPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnNavigationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNavigationPanel.BorderRadius = 0;
            this.btnNavigationPanel.ButtonText = "";
            this.btnNavigationPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavigationPanel.DisabledColor = System.Drawing.Color.Gray;
            this.btnNavigationPanel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNavigationPanel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNavigationPanel.Iconimage")));
            this.btnNavigationPanel.Iconimage_right = null;
            this.btnNavigationPanel.Iconimage_right_Selected = null;
            this.btnNavigationPanel.Iconimage_Selected = null;
            this.btnNavigationPanel.IconMarginLeft = 0;
            this.btnNavigationPanel.IconMarginRight = 0;
            this.btnNavigationPanel.IconRightVisible = true;
            this.btnNavigationPanel.IconRightZoom = 0D;
            this.btnNavigationPanel.IconVisible = true;
            this.btnNavigationPanel.IconZoom = 50D;
            this.btnNavigationPanel.IsTab = false;
            this.btnNavigationPanel.Location = new System.Drawing.Point(8, 9);
            this.btnNavigationPanel.Name = "btnNavigationPanel";
            this.btnNavigationPanel.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNavigationPanel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNavigationPanel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnNavigationPanel.selected = false;
            this.btnNavigationPanel.Size = new System.Drawing.Size(40, 40);
            this.btnNavigationPanel.TabIndex = 30;
            this.btnNavigationPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavigationPanel.Textcolor = System.Drawing.Color.White;
            this.btnNavigationPanel.TextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnNavigationPanel.Click += new System.EventHandler(this.btnNavigationPanel_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(137, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "music";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.label8.Location = new System.Drawing.Point(61, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 38);
            this.label8.TabIndex = 31;
            this.label8.Text = "Ting";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.panelHeader.Controls.Add(this.bunifuFlatButton1);
            this.panelHeader.Controls.Add(this.bunifuFlatButton3);
            this.panelHeader.Controls.Add(this.bunifuFlatButton2);
            this.panelHeader.Controls.Add(this.btnSearchMusic);
            this.panelHeader.Controls.Add(this.txbSearchMusic);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(223, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(850, 54);
            this.panelHeader.TabIndex = 28;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
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
            this.bunifuFlatButton1.IconZoom = 30D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(787, 3);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(16, 16);
            this.bunifuFlatButton1.TabIndex = 54;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.bunifuFlatButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 30D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(831, 3);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(16, 16);
            this.bunifuFlatButton3.TabIndex = 53;
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.bunifuFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "";
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
            this.bunifuFlatButton2.IconZoom = 30D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(809, 3);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(16, 16);
            this.bunifuFlatButton2.TabIndex = 52;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnSearchMusic
            // 
            this.btnSearchMusic.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.btnSearchMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.btnSearchMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchMusic.BorderRadius = 0;
            this.btnSearchMusic.ButtonText = "";
            this.btnSearchMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchMusic.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearchMusic.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearchMusic.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearchMusic.Iconimage")));
            this.btnSearchMusic.Iconimage_right = null;
            this.btnSearchMusic.Iconimage_right_Selected = null;
            this.btnSearchMusic.Iconimage_Selected = null;
            this.btnSearchMusic.IconMarginLeft = 0;
            this.btnSearchMusic.IconMarginRight = 0;
            this.btnSearchMusic.IconRightVisible = true;
            this.btnSearchMusic.IconRightZoom = 0D;
            this.btnSearchMusic.IconVisible = true;
            this.btnSearchMusic.IconZoom = 40D;
            this.btnSearchMusic.IsTab = false;
            this.btnSearchMusic.Location = new System.Drawing.Point(638, 15);
            this.btnSearchMusic.Name = "btnSearchMusic";
            this.btnSearchMusic.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.btnSearchMusic.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSearchMusic.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnSearchMusic.selected = false;
            this.btnSearchMusic.Size = new System.Drawing.Size(27, 27);
            this.btnSearchMusic.TabIndex = 32;
            this.btnSearchMusic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchMusic.Textcolor = System.Drawing.Color.White;
            this.btnSearchMusic.TextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            // 
            // txbSearchMusic
            // 
            this.txbSearchMusic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearchMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.txbSearchMusic.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.txbSearchMusic.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.txbSearchMusic.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.txbSearchMusic.BorderThickness = 1;
            this.txbSearchMusic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearchMusic.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchMusic.ForeColor = System.Drawing.Color.White;
            this.txbSearchMusic.isPassword = false;
            this.txbSearchMusic.Location = new System.Drawing.Point(203, 14);
            this.txbSearchMusic.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchMusic.Name = "txbSearchMusic";
            this.txbSearchMusic.Size = new System.Drawing.Size(462, 27);
            this.txbSearchMusic.TabIndex = 33;
            this.txbSearchMusic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(23, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(88, 23);
            this.labelTitle.TabIndex = 34;
            this.labelTitle.Text = "My music";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panelLeft;
            this.bunifuDragControl2.Vertical = true;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.myMusic1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(223, 54);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(850, 474);
            this.panel.TabIndex = 29;
            // 
            // myMusic1
            // 
            this.myMusic1.AutoSize = true;
            this.myMusic1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.myMusic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myMusic1.Location = new System.Drawing.Point(0, 0);
            this.myMusic1.Name = "myMusic1";
            this.myMusic1.Size = new System.Drawing.Size(850, 474);
            this.myMusic1.TabIndex = 0;
            this.myMusic1.Load += new System.EventHandler(this.myMusic1_Load);
            // 
            // fMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 618);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMusic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelPlay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearchMusic;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbSearchMusic;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAbout;
        private Bunifu.Framework.UI.BunifuFlatButton btnPlayList;
        private Bunifu.Framework.UI.BunifuFlatButton btnSetting;
        private Bunifu.Framework.UI.BunifuFlatButton btnNowPlaying;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuFlatButton btnRecentPlays;
        private Bunifu.Framework.UI.BunifuFlatButton btnMyMusic;
        private Bunifu.Framework.UI.BunifuFlatButton btnNavigationPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelBottom;
        private Bunifu.Framework.UI.BunifuFlatButton btnLyric;
        private Bunifu.Framework.UI.BunifuFlatButton btnVolume;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider2;
        private System.Windows.Forms.Label labelTimeTo;
        private System.Windows.Forms.Label labelSongName;
        private System.Windows.Forms.Label labelArtistName;
        private System.Windows.Forms.Label labelTimeFrom;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel panel;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Panel panelPlay;
        private Bunifu.Framework.UI.BunifuImageButton btnPlay;
        private Bunifu.Framework.UI.BunifuFlatButton btnShuffle;
        private Bunifu.Framework.UI.BunifuFlatButton btnRepeat;
        private Bunifu.Framework.UI.BunifuFlatButton btnForward;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
        private MyMusic myMusic1;
    }
}

