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

namespace Music
{
    public partial class MyMusic : UserControl
    {
        public MyMusic()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        public Song song
        {
            set
            {
                panelSongs.Controls.Add(value);
                value.Dock = DockStyle.Top;
            }
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

        private Thread thread;

        public void Clear()
        {
            panelSongs.Controls.Clear();
        }
        private void comboBoxSortBySongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSortBySongs.SelectedIndex)
            {
                case 0:
                    SortFromAToZ();
                    break;
                case 1:
                    SortFromZToA();
                    break;
                case 3:
                    SortArtist();
                    break;
                default:
                    break;
            }
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
            //thread.Suspend();
            thread = new Thread(UpdateList);
            thread.IsBackground = true;
            thread.Start();
        }
        public void UpdateList()
        {
            fMusic.PlaylistCurrent.clear();
            foreach (var item in listSong)
            {
                fMusic.PlaylistLocalFile.appendItem(MediaPlayer.Instance.CreateMedia(item.Path));
            }

        }
    }
}
