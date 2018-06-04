using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Music.UISort;
using System.Threading;
using WMPLib;

namespace Music
{
    public partial class MyMusic : UserControl
    {
        private readonly List<Myplaylist> artists = new List<Myplaylist>();
        private readonly List<Myplaylist> albums = new List<Myplaylist>();
        public List<Myplaylist> ListAlbums
        {
            get => albums;
        }
        public List<Myplaylist> ListArtists
        {
            get => artists;
        }

        public MyMusic()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            btnShuffleAllAlbums.IconVisible = true;
            //btnShuffleAllSongs.IconVisible = true;
            btnShuufleAllArtists.IconVisible = true;
        }

        public event EventHandler Artist_Click;
        public event EventHandler Album_Click;
        
        #region Method Songs
        private void Songs_Enter(object sender, EventArgs e)
        {

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
        #endregion


        #region Method artists
        private void Artists_Enter(object sender, EventArgs e)
        {
            Artists.Controls.Clear();
            Artists.Controls.AddRange(artists.ToArray());
        }

        public void AddArtist(Myplaylist artist)
        {
            Artists.Controls.Add(artist);
            this.artists.Add(artist);
            artist.BtnImage_Click += Artist_BtnImage_Click;
        }
        private void Artist_BtnImage_Click(object sender, EventArgs e)
        {
            Myplaylist artist = sender as Myplaylist;
            ShowSongInArtist(artist);
            Artist_Click?.Invoke(sender, e);

        }
        public void ShowArtits()
        {
            Artists.Controls.Clear();
            Artists.Controls.AddRange(artists.ToArray());
        }
        private void ShowSongInArtist(Myplaylist artist)
        {
            Artists.Controls.Clear();
            Artists.Controls.AddRange(artist.Songs.ToArray());
            for (int i = 0; i < artist.Songs.Count; i++)
            {
                artist.Songs[i].BackColor = (i % 2 == 0) ? Color.Silver : Color.Gainsboro;
            }
        }
        public void SetScrollSongInArtists(Control value)
        {
            Artists.ScrollControlIntoView(value);
        }
        #endregion


        #region Method Albums
        private void Albums_Enter(object sender, EventArgs e)
        {
            panelAlbums.Controls.Clear();
            panelAlbums.Controls.AddRange(albums.ToArray());
        }
        public void AddAlbum(Myplaylist album)
        {
            panelAlbums.Controls.Add(album);
            this.albums.Add(album);
            album.BtnImage_Click += Album_BtnImage_Click;
        }
        private void Album_BtnImage_Click(object sender, EventArgs e)
        {
            Myplaylist album = sender as Myplaylist;
            ShowSongInAlbum(album);
            Album_Click?.Invoke(sender, e);
        }
        private void ShowSongInAlbum(Myplaylist album)
        {
            panelAlbums.Controls.Clear();
            panelAlbums.Controls.AddRange(album.Songs.ToArray());
            for (int i = 0; i < album.Songs.Count; i++)
            {
                album.Songs[i].BackColor = (i % 2 == 0) ? Color.Silver : Color.Gainsboro;
            }

        }
        public void ShowAlbums()
        {
            panelAlbums.Controls.Clear();
            panelAlbums.Controls.AddRange(albums.ToArray());
        }

        public void SetScrollSongInAlbums(Control value)
        {
            panelAlbums.ScrollControlIntoView(value);
        }


        #endregion

        #region What??
        //private Thread thread;

        //private void comboBoxSortBySongs_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
        //private void comboBoxGenreSongs_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    switch (comboBoxGenreSongs.SelectedIndex)
        //    {
        //        case 1:
        //            GenrePop();
        //            break;
        //        case 2:
        //            GenreRock();
        //            break;
        //        case 3:
        //            GenreOther();
        //            break;

        //        default:
        //            GenreAll();
        //            break;
        //    }
        //}
        //private void SetIndexSongs(List<Song> songs)
        //{
        //    index = 0;
        //    panelSongs.Controls.Clear();
        //    songs.ForEach(SetNumberSong);
        //    panelSongs.Controls.AddRange(songs.ToArray());
        //    UpdatePlayList();
        //    GC.Collect();
        //}
        //public List<Song> listSong
        //{
        //    get
        //    {
        //        List<Song> songs = new List<Song>();
        //        songs.AddRange(panelSongs.Controls.Cast<Song>());
        //        return songs;
        //    }
        //}

        //#region Sort Song
        //public void SortFromAToZ()
        //{
        //    List<Song> songs = listSong;
        //    songs.Sort(iCompareAToZ);
        //    SetIndexSongs(songs);
        //}
        //public void SortFromZToA()
        //{
        //    List<Song> songs = listSong;
        //    songs.Sort(iCompareZToA);
        //    SetIndexSongs(songs);
        //}
        //public void SortArtist()
        //{
        //    List<Song> songs = listSong;
        //    songs.Sort(iCompareArtist);
        //    SetIndexSongs(songs);
        //}
        //#endregion

        //#region Genre Song
        //public void GenrePop()
        //{
        //    List<Song> songs = listSong.FindAll(Pop);
        //    SetIndexSongs(songs);
        //}
        //public void GenreRock()
        //{
        //    List<Song> songs = listSong.FindAll(Rock);
        //    SetIndexSongs(songs);
        //}
        //public void GenreOther()
        //{
        //    List<Song> songs = listSong.FindAll(Other);
        //    SetIndexSongs(songs);
        //}
        //public void GenreAll()
        //{

        //}
        //#endregion

        //void UpdatePlayList()
        //{
        //    thread = new Thread(UpdateList);
        //    thread.IsBackground = true;
        //    thread.Start();
        //}
        //public void UpdateList()
        //{
        //    //fMusic.PlaylistLocalFile.clear();
        //    //foreach (var item in listSong)
        //    //{
        //    //    fMusic.PlaylistLocalFile.appendItem(MediaPlayer.Instance.CreateMedia(item.Path));
        //    //}
        //    //fMusic.PlaylistCurrent = fMusic.PlaylistLocalFile;
        //}
        #endregion


    }
}
