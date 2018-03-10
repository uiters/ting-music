namespace Music
{
    partial class MyMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMusic));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageSongs = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShuffleAllSongs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboBoxGenreSongs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSortBySongs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageArtist = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelArtists = new System.Windows.Forms.FlowLayoutPanel();
            this.artist1 = new Music.Artist();
            this.artist2 = new Music.Artist();
            this.artist3 = new Music.Artist();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShuufleAllArtists = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboBoxSortByArtists = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageAlbum = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelAlbum = new System.Windows.Forms.FlowLayoutPanel();
            this.album1 = new Music.Album();
            this.album2 = new Music.Album();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShuffleAllAlbums = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboBoxGenreAlbums = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSortByAlbums = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.playlist11 = new Music.Playlist1();
            this.materialTabControl2.SuspendLayout();
            this.tabPageSongs.SuspendLayout();
            this.flowLayoutPanelSongs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageArtist.SuspendLayout();
            this.flowLayoutPanelArtists.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageAlbum.SuspendLayout();
            this.flowLayoutPanelAlbum.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl2;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(850, 23);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.tabPageSongs);
            this.materialTabControl2.Controls.Add(this.tabPageArtist);
            this.materialTabControl2.Controls.Add(this.tabPageAlbum);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl2.Location = new System.Drawing.Point(0, 23);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(850, 451);
            this.materialTabControl2.TabIndex = 1;
            this.materialTabControl2.SelectedIndexChanged += new System.EventHandler(this.materialTabControl2_SelectedIndexChanged);
            // 
            // tabPageSongs
            // 
            this.tabPageSongs.AutoScroll = true;
            this.tabPageSongs.Controls.Add(this.flowLayoutPanelSongs);
            this.tabPageSongs.Controls.Add(this.panel1);
            this.tabPageSongs.Location = new System.Drawing.Point(4, 22);
            this.tabPageSongs.Name = "tabPageSongs";
            this.tabPageSongs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSongs.Size = new System.Drawing.Size(842, 425);
            this.tabPageSongs.TabIndex = 0;
            this.tabPageSongs.Text = "Songs";
            this.tabPageSongs.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelSongs
            // 
            this.flowLayoutPanelSongs.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelSongs.Controls.Add(this.playlist11);
            this.flowLayoutPanelSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSongs.Location = new System.Drawing.Point(3, 45);
            this.flowLayoutPanelSongs.Name = "flowLayoutPanelSongs";
            this.flowLayoutPanelSongs.Size = new System.Drawing.Size(836, 377);
            this.flowLayoutPanelSongs.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShuffleAllSongs);
            this.panel1.Controls.Add(this.comboBoxGenreSongs);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxSortBySongs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 42);
            this.panel1.TabIndex = 3;
            // 
            // btnShuffleAllSongs
            // 
            this.btnShuffleAllSongs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnShuffleAllSongs.BackColor = System.Drawing.Color.Transparent;
            this.btnShuffleAllSongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShuffleAllSongs.BorderRadius = 0;
            this.btnShuffleAllSongs.ButtonText = "  Shuffle all";
            this.btnShuffleAllSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffleAllSongs.DisabledColor = System.Drawing.Color.Gray;
            this.btnShuffleAllSongs.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShuffleAllSongs.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShuffleAllSongs.Iconimage")));
            this.btnShuffleAllSongs.Iconimage_right = null;
            this.btnShuffleAllSongs.Iconimage_right_Selected = null;
            this.btnShuffleAllSongs.Iconimage_Selected = null;
            this.btnShuffleAllSongs.IconMarginLeft = 0;
            this.btnShuffleAllSongs.IconMarginRight = 0;
            this.btnShuffleAllSongs.IconRightVisible = false;
            this.btnShuffleAllSongs.IconRightZoom = 0D;
            this.btnShuffleAllSongs.IconVisible = false;
            this.btnShuffleAllSongs.IconZoom = 30D;
            this.btnShuffleAllSongs.IsTab = false;
            this.btnShuffleAllSongs.Location = new System.Drawing.Point(10, 7);
            this.btnShuffleAllSongs.Name = "btnShuffleAllSongs";
            this.btnShuffleAllSongs.Normalcolor = System.Drawing.Color.Transparent;
            this.btnShuffleAllSongs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnShuffleAllSongs.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShuffleAllSongs.selected = false;
            this.btnShuffleAllSongs.Size = new System.Drawing.Size(107, 29);
            this.btnShuffleAllSongs.TabIndex = 48;
            this.btnShuffleAllSongs.Text = "  Shuffle all";
            this.btnShuffleAllSongs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShuffleAllSongs.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShuffleAllSongs.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // comboBoxGenreSongs
            // 
            this.comboBoxGenreSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGenreSongs.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.comboBoxGenreSongs.FormattingEnabled = true;
            this.comboBoxGenreSongs.Items.AddRange(new object[] {
            "Pop",
            "Rock"});
            this.comboBoxGenreSongs.Location = new System.Drawing.Point(398, 10);
            this.comboBoxGenreSongs.Name = "comboBoxGenreSongs";
            this.comboBoxGenreSongs.Size = new System.Drawing.Size(107, 25);
            this.comboBoxGenreSongs.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(341, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Genre";
            // 
            // comboBoxSortBySongs
            // 
            this.comboBoxSortBySongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSortBySongs.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.comboBoxSortBySongs.FormattingEnabled = true;
            this.comboBoxSortBySongs.Items.AddRange(new object[] {
            "A-Z",
            "Date added",
            "Artist",
            "Album"});
            this.comboBoxSortBySongs.Location = new System.Drawing.Point(197, 10);
            this.comboBoxSortBySongs.Name = "comboBoxSortBySongs";
            this.comboBoxSortBySongs.Size = new System.Drawing.Size(107, 25);
            this.comboBoxSortBySongs.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(140, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Sort by";
            // 
            // tabPageArtist
            // 
            this.tabPageArtist.Controls.Add(this.flowLayoutPanelArtists);
            this.tabPageArtist.Controls.Add(this.panel2);
            this.tabPageArtist.Location = new System.Drawing.Point(4, 22);
            this.tabPageArtist.Name = "tabPageArtist";
            this.tabPageArtist.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArtist.Size = new System.Drawing.Size(842, 425);
            this.tabPageArtist.TabIndex = 1;
            this.tabPageArtist.Text = "Artists";
            this.tabPageArtist.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelArtists
            // 
            this.flowLayoutPanelArtists.AutoScroll = true;
            this.flowLayoutPanelArtists.Controls.Add(this.artist1);
            this.flowLayoutPanelArtists.Controls.Add(this.artist2);
            this.flowLayoutPanelArtists.Controls.Add(this.artist3);
            this.flowLayoutPanelArtists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelArtists.Location = new System.Drawing.Point(3, 45);
            this.flowLayoutPanelArtists.Name = "flowLayoutPanelArtists";
            this.flowLayoutPanelArtists.Size = new System.Drawing.Size(836, 377);
            this.flowLayoutPanelArtists.TabIndex = 5;
            // 
            // artist1
            // 
            this.artist1.BackColor = System.Drawing.Color.Transparent;
            this.artist1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.artist1.Location = new System.Drawing.Point(3, 3);
            this.artist1.Name = "artist1";
            this.artist1.Size = new System.Drawing.Size(152, 175);
            this.artist1.TabIndex = 0;
            // 
            // artist2
            // 
            this.artist2.BackColor = System.Drawing.Color.Transparent;
            this.artist2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.artist2.Location = new System.Drawing.Point(161, 3);
            this.artist2.Name = "artist2";
            this.artist2.Size = new System.Drawing.Size(152, 175);
            this.artist2.TabIndex = 1;
            // 
            // artist3
            // 
            this.artist3.BackColor = System.Drawing.Color.Transparent;
            this.artist3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.artist3.Location = new System.Drawing.Point(319, 3);
            this.artist3.Name = "artist3";
            this.artist3.Size = new System.Drawing.Size(152, 175);
            this.artist3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnShuufleAllArtists);
            this.panel2.Controls.Add(this.comboBoxSortByArtists);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 42);
            this.panel2.TabIndex = 4;
            // 
            // btnShuufleAllArtists
            // 
            this.btnShuufleAllArtists.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnShuufleAllArtists.BackColor = System.Drawing.Color.Transparent;
            this.btnShuufleAllArtists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShuufleAllArtists.BorderRadius = 0;
            this.btnShuufleAllArtists.ButtonText = "  Shuffle all";
            this.btnShuufleAllArtists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuufleAllArtists.DisabledColor = System.Drawing.Color.Gray;
            this.btnShuufleAllArtists.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShuufleAllArtists.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShuufleAllArtists.Iconimage")));
            this.btnShuufleAllArtists.Iconimage_right = null;
            this.btnShuufleAllArtists.Iconimage_right_Selected = null;
            this.btnShuufleAllArtists.Iconimage_Selected = null;
            this.btnShuufleAllArtists.IconMarginLeft = 0;
            this.btnShuufleAllArtists.IconMarginRight = 0;
            this.btnShuufleAllArtists.IconRightVisible = false;
            this.btnShuufleAllArtists.IconRightZoom = 0D;
            this.btnShuufleAllArtists.IconVisible = false;
            this.btnShuufleAllArtists.IconZoom = 30D;
            this.btnShuufleAllArtists.IsTab = false;
            this.btnShuufleAllArtists.Location = new System.Drawing.Point(10, 7);
            this.btnShuufleAllArtists.Name = "btnShuufleAllArtists";
            this.btnShuufleAllArtists.Normalcolor = System.Drawing.Color.Transparent;
            this.btnShuufleAllArtists.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnShuufleAllArtists.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShuufleAllArtists.selected = false;
            this.btnShuufleAllArtists.Size = new System.Drawing.Size(107, 29);
            this.btnShuufleAllArtists.TabIndex = 49;
            this.btnShuufleAllArtists.Text = "  Shuffle all";
            this.btnShuufleAllArtists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShuufleAllArtists.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShuufleAllArtists.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuufleAllArtists.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // comboBoxSortByArtists
            // 
            this.comboBoxSortByArtists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSortByArtists.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.comboBoxSortByArtists.FormattingEnabled = true;
            this.comboBoxSortByArtists.Items.AddRange(new object[] {
            "A-Z",
            "Date added",
            "Artist",
            "Album"});
            this.comboBoxSortByArtists.Location = new System.Drawing.Point(197, 10);
            this.comboBoxSortByArtists.Name = "comboBoxSortByArtists";
            this.comboBoxSortByArtists.Size = new System.Drawing.Size(107, 25);
            this.comboBoxSortByArtists.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(140, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Sort by";
            // 
            // tabPageAlbum
            // 
            this.tabPageAlbum.Controls.Add(this.flowLayoutPanelAlbum);
            this.tabPageAlbum.Controls.Add(this.panel3);
            this.tabPageAlbum.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlbum.Name = "tabPageAlbum";
            this.tabPageAlbum.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlbum.Size = new System.Drawing.Size(842, 425);
            this.tabPageAlbum.TabIndex = 2;
            this.tabPageAlbum.Text = "Albums";
            this.tabPageAlbum.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelAlbum
            // 
            this.flowLayoutPanelAlbum.AutoScroll = true;
            this.flowLayoutPanelAlbum.Controls.Add(this.album1);
            this.flowLayoutPanelAlbum.Controls.Add(this.album2);
            this.flowLayoutPanelAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAlbum.Location = new System.Drawing.Point(3, 45);
            this.flowLayoutPanelAlbum.Name = "flowLayoutPanelAlbum";
            this.flowLayoutPanelAlbum.Size = new System.Drawing.Size(836, 377);
            this.flowLayoutPanelAlbum.TabIndex = 5;
            // 
            // album1
            // 
            this.album1.BackColor = System.Drawing.Color.Transparent;
            this.album1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.album1.Location = new System.Drawing.Point(3, 3);
            this.album1.Name = "album1";
            this.album1.Size = new System.Drawing.Size(202, 174);
            this.album1.TabIndex = 0;
            // 
            // album2
            // 
            this.album2.BackColor = System.Drawing.Color.Transparent;
            this.album2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.album2.Location = new System.Drawing.Point(211, 3);
            this.album2.Name = "album2";
            this.album2.Size = new System.Drawing.Size(202, 174);
            this.album2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnShuffleAllAlbums);
            this.panel3.Controls.Add(this.comboBoxGenreAlbums);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBoxSortByAlbums);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(836, 42);
            this.panel3.TabIndex = 4;
            // 
            // btnShuffleAllAlbums
            // 
            this.btnShuffleAllAlbums.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnShuffleAllAlbums.BackColor = System.Drawing.Color.Transparent;
            this.btnShuffleAllAlbums.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShuffleAllAlbums.BorderRadius = 0;
            this.btnShuffleAllAlbums.ButtonText = "  Shuffle all";
            this.btnShuffleAllAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffleAllAlbums.DisabledColor = System.Drawing.Color.Gray;
            this.btnShuffleAllAlbums.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShuffleAllAlbums.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShuffleAllAlbums.Iconimage")));
            this.btnShuffleAllAlbums.Iconimage_right = null;
            this.btnShuffleAllAlbums.Iconimage_right_Selected = null;
            this.btnShuffleAllAlbums.Iconimage_Selected = null;
            this.btnShuffleAllAlbums.IconMarginLeft = 0;
            this.btnShuffleAllAlbums.IconMarginRight = 0;
            this.btnShuffleAllAlbums.IconRightVisible = false;
            this.btnShuffleAllAlbums.IconRightZoom = 0D;
            this.btnShuffleAllAlbums.IconVisible = false;
            this.btnShuffleAllAlbums.IconZoom = 30D;
            this.btnShuffleAllAlbums.IsTab = false;
            this.btnShuffleAllAlbums.Location = new System.Drawing.Point(10, 7);
            this.btnShuffleAllAlbums.Name = "btnShuffleAllAlbums";
            this.btnShuffleAllAlbums.Normalcolor = System.Drawing.Color.Transparent;
            this.btnShuffleAllAlbums.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnShuffleAllAlbums.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShuffleAllAlbums.selected = false;
            this.btnShuffleAllAlbums.Size = new System.Drawing.Size(107, 29);
            this.btnShuffleAllAlbums.TabIndex = 49;
            this.btnShuffleAllAlbums.Text = "  Shuffle all";
            this.btnShuffleAllAlbums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShuffleAllAlbums.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShuffleAllAlbums.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // comboBoxGenreAlbums
            // 
            this.comboBoxGenreAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGenreAlbums.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.comboBoxGenreAlbums.FormattingEnabled = true;
            this.comboBoxGenreAlbums.Items.AddRange(new object[] {
            "Pop",
            "Rock"});
            this.comboBoxGenreAlbums.Location = new System.Drawing.Point(398, 10);
            this.comboBoxGenreAlbums.Name = "comboBoxGenreAlbums";
            this.comboBoxGenreAlbums.Size = new System.Drawing.Size(107, 25);
            this.comboBoxGenreAlbums.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(341, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Genre";
            // 
            // comboBoxSortByAlbums
            // 
            this.comboBoxSortByAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSortByAlbums.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.comboBoxSortByAlbums.FormattingEnabled = true;
            this.comboBoxSortByAlbums.Items.AddRange(new object[] {
            "A-Z",
            "Date added",
            "Artist",
            "Album"});
            this.comboBoxSortByAlbums.Location = new System.Drawing.Point(197, 10);
            this.comboBoxSortByAlbums.Name = "comboBoxSortByAlbums";
            this.comboBoxSortByAlbums.Size = new System.Drawing.Size(107, 25);
            this.comboBoxSortByAlbums.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.Location = new System.Drawing.Point(140, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Sort by";
            // 
            // playlist11
            // 
            this.playlist11.BackColor = System.Drawing.Color.Silver;
            this.playlist11.Location = new System.Drawing.Point(3, 3);
            this.playlist11.Name = "playlist11";
            this.playlist11.Size = new System.Drawing.Size(842, 60);
            this.playlist11.TabIndex = 0;
            // 
            // MyMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.materialTabControl2);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "MyMusic";
            this.Size = new System.Drawing.Size(850, 474);
            this.materialTabControl2.ResumeLayout(false);
            this.tabPageSongs.ResumeLayout(false);
            this.flowLayoutPanelSongs.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageArtist.ResumeLayout(false);
            this.flowLayoutPanelArtists.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPageAlbum.ResumeLayout(false);
            this.flowLayoutPanelAlbum.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage tabPageSongs;
        private System.Windows.Forms.TabPage tabPageArtist;
        private System.Windows.Forms.TabPage tabPageAlbum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxGenreSongs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSortBySongs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxSortByArtists;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelArtists;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbum;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxGenreAlbums;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSortByAlbums;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton btnShuffleAllSongs;
        private Bunifu.Framework.UI.BunifuFlatButton btnShuufleAllArtists;
        private Bunifu.Framework.UI.BunifuFlatButton btnShuffleAllAlbums;
        private Artist artist1;
        private Artist artist2;
        private Artist artist3;
        private Album album1;
        private Album album2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSongs;
        private Playlist1 playlist11;
    }
}
