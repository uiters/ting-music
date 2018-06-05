using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;

namespace Music
{
    public partial class MyMusic : UserControl
    {
        private List<Song> songs;
        private List<Myplaylist> artists = new List<Myplaylist>();
        private List<Myplaylist> albums = new List<Myplaylist>();
        public List<Myplaylist> ListAlbums
        {
            get => albums;
        }
        public List<Myplaylist> ListArtists
        {
            get => artists;
        }
        public event EventHandler SongsClick;
        public event EventHandler Artist_Click;
        public event EventHandler Album_Click;
        public event EventHandler SongsSorted;


        public MyMusic()
        {
            InitializeComponent();
            btnShuffleAllAlbums.IconVisible = true;
            btnShuffleAllSongs.IconVisible = true;
            btnShuufleAllArtists.IconVisible = true;
        }

        #region Method
        private void ChangeColor(FlowLayoutPanel panel, Control[] controls)
        {
            //panel.contr;
            panel.Visible = false;
            panel.Controls.Clear();
            for (int i = 0; i < controls.Length; i++)
            {
                controls[i].BackColor = (i % 2 == 0) ? Color.Silver : Color.Gainsboro;
                panel.Controls.Add(controls[i]);
            }
            panel.Visible = true;

        }
        public void SetSongs(List<Song> songs)
        {
            this.songs = songs;
            panelSongs.Tag = songs;
        }
        private void MetroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedTab == metroTabControl1.TabPages[0])
                Songs_Enter(sender, e);
            else if (metroTabControl1.SelectedTab == metroTabControl1.TabPages[1])
                Artists_Enter(sender, e);
            else Albums_Enter(sender, e);
        }

        #endregion

        #region Method Songs
        private void Songs_Enter(object sender, EventArgs e)
        {
            SongsClick?.Invoke(sender, e);
            panel1.Visible = false; 
            for (int i = 0; i < songs.Count; i++)
            {
                songs[i].BackColor = (i % 2 == 0) ? Color.Silver : Color.Gainsboro;
            }
            AddSongs(songs.ToArray());
            panel1.Visible = true;

        }
        public void AddSong(Song value)
        {
            panelSongs.Controls.Add(value);
        }
        public void AddSongs(Song[] value)
        {
            panelSongs.Controls.Clear();
            panelSongs.Controls.AddRange(value);
        }
        public void SetScrollSongInSongs(Control value)
        {
            panelSongs.ScrollControlIntoView(value);
        }
        public void SongsClear()
        {
            panelSongs.Controls.Clear();
        }
        public List<Song> ListSongs
        {
            get
            {
                return panelSongs.Controls.Cast<Song>().ToList();
            }
        }
        public void ShowLanguage(ResourceManager resource, CultureInfo culture)
        {
            Songs.Text = resource.GetString("Songs", culture);
            Albums.Text = resource.GetString("Albums", culture);
            Artists.Text = resource.GetString("Artists", culture);
            label1.Text = resource.GetString("labelSort", culture);
            label4.Text = resource.GetString("labelSort", culture);
            label5.Text = resource.GetString("labelSort", culture);
            comboBoxSortBySongs.Items.RemoveAt(0);
            string none = resource.GetString("None", culture);
            comboBoxSortBySongs.Items.Insert(0, none);
            //label4.Text = resource.GetString("labelSort", culture);
            //label4.Text = resource.GetString("labelSort", culture);

        }

        #endregion

        #region Method artists
        private void Artists_Enter(object sender, EventArgs e)
        {
            ShowArtits();
        }
        public void AddArtist(Myplaylist artist)
        {
            if (artist.Songs.Count < 2)
            {
                panelArtists.Controls.Add(artist);
                this.artists.Add(artist);
                artist.BtnImage_Click += Artist_BtnImage_Click;
            }
            else return;
        }
        
        private void Artist_BtnImage_Click(object sender, EventArgs e)
        {
            Myplaylist artist = sender as Myplaylist;
            ShowSongInArtist(artist);
            Artist_Click?.Invoke(sender, e);

        }
        public void ShowArtits()
        {
            panel2.Visible = true;
            panelArtists.Visible = false;
            panelArtists.Controls.Clear();
            panelArtists.Controls.AddRange(artists.ToArray());
            panelArtists.Visible = true;

        }
        private void ShowSongInArtist(Myplaylist artist)
        {
            panel2.Visible = false;
            panelArtists.Visible = false;
            panelArtists.Controls.Clear();
            panelArtists.Controls.Add(artist.fDetails);
            panelArtists.Controls.AddRange(artist.Songs.ToArray());
            for (int i = 0; i < artist.Songs.Count; i++)
            {
                artist.Songs[i].BackColor = (i % 2 == 0) ? Color.Silver : Color.Gainsboro;
            }
            panelArtists.Visible = true;
        }
        public void SetScrollSongInArtists(Control value)
        {
            panelArtists.ScrollControlIntoView(value);
        }
        public void HideSongs()
        {
            panelSongs.Visible = false;
            panelArtists.Visible = false;
            panelAlbums.Visible = false;
        }
        public void ShowSongs()
        {
            panelSongs.Visible = true;
            panelArtists.Visible = true;
            panelAlbums.Visible = true;
        }
        #endregion

        #region Method Albums
        private void Albums_Enter(object sender, EventArgs e)
        {
            ShowAlbums();
        }
        public void AddAlbum(Myplaylist album)
        {
            if (album.Songs.Count < 2)
            {
                panelAlbums.Controls.Add(album);
                this.albums.Add(album);
                album.BtnImage_Click += Album_BtnImage_Click;
            }
            else return;
        }
        private void Album_BtnImage_Click(object sender, EventArgs e)
        {
            Myplaylist album = sender as Myplaylist;
            ShowSongInAlbum(album);
            Album_Click?.Invoke(sender, e);
        }
        private void ShowSongInAlbum(Myplaylist album)
        {
            panelAlbums.Visible = false;
            panel3.Visible = false;
            panelAlbums.Controls.Clear();
            panelAlbums.Controls.Add(album.fDetails);
            for (int i = 0; i < album.Songs.Count; i++)
            {
                album.Songs[i].BackColor = (i % 2 == 0) ? Color.Silver : Color.Gainsboro;
            }
            panelAlbums.Controls.AddRange(album.Songs.ToArray());
            panelAlbums.Visible = true;
        }
        public void ShowAlbums()
        {
            panel3.Visible = true;
            panelAlbums.Visible = false;
            panelAlbums.Controls.Clear();
            panelAlbums.Controls.AddRange(albums.ToArray());
            panelAlbums.Visible = true;

        }

        public void SetScrollSongInAlbums(Control value)
        {
            panelAlbums.ScrollControlIntoView(value);
        }



        #endregion

        #region Sort Songs
        private void ComboBoxSortBySongs_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBoxSortBySongs.SelectedIndex)
            {
                case 0:
                    SortNone();
                    break;
                case 1:
                    SortSongsAtoZ();
                    break;
                case 2:
                    SortSongsZtoA();
                    break;
                default:
                    SortSongsAtoZ();
                    break;
            }
        }

        private void SortNone()
        {
            songs = (List<Song>)panelSongs.Tag;
            ChangeColor(panelSongs, songs.ToArray());
            SongsSorted?.Invoke(songs, null);
        }

        private void SortSongsZtoA()
        {
            songs?.Sort(UISort.iCompareZToA);
            ChangeColor(panelSongs, songs.ToArray());
            SongsSorted?.Invoke(songs, null);
        }

        private void SortSongsAtoZ()
        {
            songs?.Sort(UISort.iCompareAToZ);
            ChangeColor(panelSongs, songs.ToArray());
            SongsSorted?.Invoke(songs, null);

        }


        #endregion

        #region Sort Albums
        private void ComboBoxSortAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            switch (combo.SelectedIndex)
            {
                case 0:
                    SortAlbums_AtoZ();
                    break;
                case 1:
                    SortAblums_ZtoA();
                    break;
                default:
                    SortAlbums_AtoZ();
                    break;
            }
        }

        private void SortAblums_ZtoA()
        {
            albums.Sort(UISort.iCompareAlbumZtoA);
            ChangeColor(panelAlbums, albums.ToArray());
        }

        private void SortAlbums_AtoZ()
        {
            albums.Sort(UISort.iCompareAlbumAtoZ);
            ChangeColor(panelAlbums, albums.ToArray());
        }
        #endregion

        #region Sort Artist
        private void comboBoxSortByArtists_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            switch (combo.SelectedIndex)
            {
                case 0:
                    SortArtists_AtoZ();
                    break;
                case 1:
                    SortArtists_ZtoA();
                    break;
                default:
                    SortArtists_AtoZ();
                    break;
            }
        }

        private void SortArtists_ZtoA()
        {
            artists.Sort(UISort.iCompareArtistZtoA);
            ChangeColor(panelArtists, artists.ToArray());
        }

        private void SortArtists_AtoZ()
        {
            artists.Sort(UISort.iCompareArtistAtoZ);
            ChangeColor(panelArtists, artists.ToArray());
        }
        #endregion


    }
}
