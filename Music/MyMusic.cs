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
            //this.DoubleBuffered = true;
        }

        public Song song
        {
            set
            {
                panelSongs.Controls.Add(value);
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
        public List<Song> SetTag
        {
            set => comboBoxGenreSongs.Tag = value;
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

        private void SetIndexSongs(List<Song> songs)
        {
            UISort.index = 0;
            panelSongs.Controls.Clear();
            songs.ForEach(SetNumberSong);
            panelSongs.Controls.AddRange(songs.ToArray());
            UpdatePlayList();   // update playlist      
            GC.Collect();
        }

        #region Sort Song
        public void SortFromAToZ(List<Song> songs)
        {
            songs.Sort(iCompareAToZ);
            SetIndexSongs(songs);
        }
        public void SortFromZToA(List<Song> songs)
        {
            songs.Sort(iCompareZToA);
            SetIndexSongs(songs);
        }
        public void SortArtist(List<Song> songs)
        {
            songs.Sort(iCompareArtist);
            SetIndexSongs(songs);
        }
        public void NoneSort(List<Song> songs)
        {
            this.Clear();
            UpdatePlayList();
            panelSongs.Controls.AddRange(songs.ToArray());
        }
        #endregion

        #region Genre Song
        public void GenrePop()
        {
            List<Song> list = this.Tag as List<Song>;
            List<Song> songs = list.FindAll(Pop);
            comboBoxGenreSongs.Tag = songs;
        }
        public void GenreRock()
        {
            List<Song> list = this.Tag as List<Song>;
            List<Song> songs = list.FindAll(Rock);
            comboBoxGenreSongs.Tag = songs;
        }
        public void GenreOther()
        {
            List<Song> list = this.Tag as List<Song>;
            List<Song> songs = list.FindAll(Other);
            comboBoxGenreSongs.Tag = songs;
        }
        public void GenreAll()
        {
            List<Song> songs = this.Tag as List<Song>;
            SetIndexSongs(songs);
            comboBoxGenreSongs.Tag = songs;
        }
        #endregion

        void UpdatePlayList()
        {
            thread = new Thread(UpdateList);
            thread.IsBackground = true;
            thread.Start();
        }
        private void UpdateList()
        {
            Program.fMusicCurent.PlaylistCurrent.clear();
            foreach (var item in listSong)
            {
                Program.fMusicCurent.PlaylistCurrent.appendItem(MediaPlayer.Instance.CreateMedia(item.Path));
            }
            Program.fMusicCurent.UpdateCountSongs();
        }

        private void comboBoxGenreSongs_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxGenreSongs.SelectedItem.ToString() == comboBoxGenreSongs.Text)
                return;
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
            List<Song> songs = comboBoxGenreSongs.Tag as List<Song>;
            switch (comboBoxSortBySongs.SelectedIndex)
            {
                case 0:
                    NoneSort(songs);
                    break;
                case 1:
                    SortFromAToZ(songs);
                    break;
                case 2:
                    SortFromZToA(songs);
                    break;
                case 3:
                    SortArtist(songs);
                    break;
                default:
                    break;
            }
        }
        private void comboBoxSortBySongs_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxSortBySongs.SelectedItem.ToString() == comboBoxSortBySongs.Text)
                return;
            switch (comboBoxSortBySongs.SelectedIndex)
            {
                case 0:
                    NoneSort(comboBoxGenreSongs.Tag as List<Song>);
                    break;
                case 1:
                    SortFromAToZ(listSong);
                    break;
                case 2:
                    SortFromZToA(listSong);
                    break;
                case 3:
                    SortArtist(listSong);
                    break;
                default:
                    break;
            }
        }
    }
}
