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
        private Thread thread;
        public MyMusic()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            btnShuffleAllAlbums.IconVisible = true;
            btnShuffleAllSongs.IconVisible = true;
            btnShuufleAllArtists.IconVisible = true;
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
        public List<Song> listSong
        {
            get
            {
                List<Song> songs = new List<Song>();
                songs.AddRange(panelSongs.Controls.Cast<Song>());
                return songs;
            }
        }
        public Control ScrollControl
        {
            set
            {
                panelSongs.ScrollControlIntoView(value);
            }
        }



        public void Clear()
        {
            panelSongs.Controls.Clear();
        }
        public List<Control> listControl
        {
            get
            {
                List<Control> listcontrol = new List<Control>();
                listcontrol.AddRange(panelSongs.Controls.Cast<Control>());
                return listcontrol;
            }
        }


        private void comboBoxSortBySongs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBoxGenreSongs_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBoxGenreSongs.SelectedIndex)
            {
                case 1:
                    GenrePop();
                    break;
                case 2:
                    GenreRock();
                    break;
                case 3:
                    GenreOther();
                    break;

                default:
                    GenreAll();
                    break;
            }
        }
        private void SetIndexSongs(List<Song> songs)
        {
            index = 0;
            panelSongs.Controls.Clear();
            songs.ForEach(SetNumberSong);
            panelSongs.Controls.AddRange(songs.ToArray());
            UpdatePlayList();
            GC.Collect();
        }

        #region Sort Song
        public void SortFromAToZ()
        {
            List<Song> songs = listSong;
            songs.Sort(iCompareAToZ);
            SetIndexSongs(songs);
        }
        public void SortFromZToA()
        {
            List<Song> songs = listSong;
            songs.Sort(iCompareZToA);
            SetIndexSongs(songs);
        }
        public void SortArtist()
        {
            List<Song> songs = listSong;
            songs.Sort(iCompareArtist);
            SetIndexSongs(songs);
        }
        #endregion

        #region Genre Song
        public void GenrePop()
        {
            List<Song> songs = listSong.FindAll(Pop);
            SetIndexSongs(songs);
        }
        public void GenreRock()
        {
            List<Song> songs = listSong.FindAll(Rock);
            SetIndexSongs(songs);
        }
        public void GenreOther()
        {
            List<Song> songs = listSong.FindAll(Other);
            SetIndexSongs(songs);
        }
        public void GenreAll()
        {

        }
        #endregion

        void UpdatePlayList()
        {
            thread = new Thread(UpdateList);
            thread.IsBackground = true;
            thread.Start();
        }
        public void UpdateList()
        {
            //fMusic.PlaylistLocalFile.clear();
            //foreach (var item in listSong)
            //{
            //    fMusic.PlaylistLocalFile.appendItem(MediaPlayer.Instance.CreateMedia(item.Path));
            //}
            //fMusic.PlaylistCurrent = fMusic.PlaylistLocalFile;
        }
    }
}
