using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using WMPLib;

namespace Music
{
    public partial class fMusic : Form
    {
        private List<Song> songsFull = new List<Song>();
        private List<Song> songsNowPlaying = new List<Song>();
        private List<Song> songsLocalFile = new List<Song>();
        private List<Song> songsCurrent = new List<Song>();
        private List<Song> songsRecent = new List<Song>();
        private int indexNow = -1;
        int status;

        public fMusic()
        {
            
            InitializeComponent();
            btnShuffle.Tag = "Off";
            btnRepeat.Tag = "Off";
            InitializePlaySong();

            InitializeData();
        }

        #region Load
        public void InitializeData()
        {
            #region loadGUI
            panelLeft.Width = 223;
            panelPlay.Location = new Point(455, 21);
            btnRepeat.Iconimage = repeat;
            btnVolume.Iconimage = volume_up;
            btnPlay.Image = play;
            myMusic.BringToFront();
            labelTitle.Text = "My music";
            #endregion
            status = 0;
            LoadLocalFile();


            foreach (Control item in myMusic.listControl)
            {
                item.Width = panel.Width - 25;
            }

            //cần cập nhập lại playlistCurrent mỗi khi phát ở 1 playlist mới
        }


        public void LoadLocalFile()
        {
            myMusic.Clear();
            string[] listFile = MediaPlayer.Instance.LoadLocalFile();

            SongInfo info = new SongInfo();
            for (int i = 0; i < listFile.Length; i++)
            {
                MediaFile file = new MediaFile(listFile[i]);
                Song song = Song.CreateSong(file, info, Song_ButtonPlay_Click, i);
                songsFull.Add(song);
                songsLocalFile.Add(song);
                myMusic.AddSong(song);
            }
            CopyList(songsLocalFile, songsCurrent);
            if (songsLocalFile.Count > 0)
            {
                indexNow = 0;
                ShowInfoMeadia(songsCurrent[0]);
            }
            info = null;
            GC.Collect();
        }
        private void ShowInfoMeadia(Song songNow)
        {
            sliderDuration.MaximumValue = (int)songNow.Duration + 1;
            pictureBoxSong.Image = songNow.ImageSong;
            lblSongName.Text = songNow.SongName;
            lblArtistName.Text = songNow.ArtistName;
            labelTimeFrom.Text = "00:00";
            labelTimeTo.Text = songNow.TotalTime;
        }
        public void LoadCurrentMedia()
        {
            if (songsCurrent.Count == 0) return;
            Song song = songsCurrent[indexNow];

            pictureBoxSong.Image = song.ImageSong;
            lblSongName.Text = song.SongName;
            lblArtistName.Text = song.ArtistName;
            labelTimeFrom.Text = "00:00";
            labelTimeTo.Text = song.TotalTime;

            UISort.pathSongPlay = songsCurrent[indexNow].Path;
            try
            {
                if (status == 0)
                {
                    song = myMusic.listSong.FindAll(UISort.FindSongNamePlay)[0];
                    if (MediaPlayer.Instance.GetPlayState() == "wmppsPlaying")
                        song.ImageButton = Music.Properties.Resources.pause;
                    else
                    if (MediaPlayer.Instance.GetPlayState() == "wmppsPaused")
                        song.ImageButton = Music.Properties.Resources.play;
                    myMusic.ScrollControl = song;
                }
                if (status == 2)
                {
                    song = nowPlaying.listSong.FindAll(UISort.FindSongNamePlay)[0];
                    if (MediaPlayer.Instance.GetPlayState() == "wmppsPlaying")
                        song.ImageButton = Music.Properties.Resources.pause;
                    else
                    if (MediaPlayer.Instance.GetPlayState() == "wmppsPaused")
                        song.ImageButton = Music.Properties.Resources.play;
                    myMusic.ScrollControl = song;
                }
            }
            catch
            { }
        }
        public void LoadLyrics()
        {
            IWMPMedia media = MediaPlayer.Instance.GetCurrentMedia();
            string path = media.sourceURL;

            SongInfo info = new SongInfo(path);

            lyrics.SongImage = info.LoadImageSong;
            lyrics.LyricsText = info.Lyrics;
            lyrics.ArtistName = info.Artist;
            lyrics.SongName = info.Song;

            info = null;
            GC.Collect();
            //timer4.Start();
        }
        public void LoadNowPlaying()
        {
            nowPlaying.Clear();
            nowPlaying.AddSongs(songsNowPlaying.ToArray());
        }
        public void LoadListPlaylist()
        {
            List<string> listPlaylist = MediaPlayer.Instance.LoadListPlaylist();
            foreach (var item in listPlaylist)
            {
                Myplaylist myplaylist = new Myplaylist();
                myplaylist.PlaylistName = item;
                playlist.myplaylist = myplaylist;
            }
        }
        private void CopyList(List<Song> songsA, List<Song> songsB)
        {
            songsB.Clear();
            songsB.AddRange(songsA);
        }
        #endregion

        #region Next & Pre & play
        private void BtnForward_Click(object sender, EventArgs e)
        {
            //MediaPlayer.Instance.Next();
            if (indexNow == -1) return;
            songsCurrent[indexNow].ImageButton = play; // song pre
            nextSong(); // set index song next
            SetSong();
            LoadLyrics();
            timer2.Start();
            TimeLine.Start();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            //MediaPlayer.Instance.Previous();
            if (indexNow == -1) return;
            songsCurrent[indexNow].ImageButton = play; // song pre
            previousSong();// set index song pre
            SetSong(); // song back
            LoadLyrics();
            timer2.Start();
            TimeLine.Start();
        }
        private void SetSong()
        {
            Song song = songsCurrent[indexNow];
            song.ImageButton = pause; // song now
            MediaPlayer.Instance.Play(song.Path);
            ShowInfoMeadia(song);
            btnPlay.Image = pause;
            nowPlaying.ScrollControl = song;
            myMusic.ScrollControl = song;
        }
        private void Song_ButtonPlay_Click(object sender, EventArgs e)
        {
            if (indexNow == -1) return;
            Song song = sender as Song;
            if (indexNow != -1)
            {
                Song songPlay = songsCurrent[indexNow];
                songPlay.ImageButton = play;
            }
            indexNow = song.Index;
            song.ImageButton = pause;
            MediaPlayer.Instance.Play(song.Path);
            btnPlay.Image = pause;

            ShowInfoMeadia(song);
            TimeLine.Start();
            timer2.Start();
        }

        #endregion

        #region Click
        public void ChangeNormalColorOnPanel1(object sender)
        {
            BunifuFlatButton btn = sender as BunifuFlatButton;
            btn.Normalcolor = Color.FromArgb(239, 108, 1);
            //if (panelLeft.Width == 55)
            //    btn.Width = 40;
            //else
            //    btn.Width = 205;
            foreach (Control item in panel1.Controls)
            {
                if (item.Name != btn.Name && item.BackColor != Color.Transparent)
                {
                    BunifuFlatButton btn1 = item as BunifuFlatButton;
                    btn1.Normalcolor = Color.Transparent;

                    //if (panelLeft.Width == 55)
                    //    item.Width = 205;
                    //else
                    //    item.Width = 40;

                }
            }
        }
        private void BtnNavigationPanel_Click_1(object sender, EventArgs e)
        {
            if (panelLeft.Width == 223)
            {
                panelLeft.Width = 55;
            }
            else
            {
                panelLeft.Width = 223;
            }
        }
        private void BtnMyMusic_Click_1(object sender, EventArgs e)
        {
            status = 0;
            songsCurrent = songsLocalFile;
            labelTitle.Text = "My music";
            ChangeNormalColorOnPanel1(sender);
            myMusic.BringToFront();
            //LoadLocalFile();
            foreach (Control item in myMusic.listControl)
            {
                item.Width = panel.Width - 25;
            }
        }
        private void btnRecentPlays_Click_1(object sender, EventArgs e)
        {
            nowPlaying.Clear();
            ChangeNormalColorOnPanel1(sender);
        }
        private void btnNowPlaying_Click_1(object sender, EventArgs e)
        {
            labelTitle.Text = "Now playing";
            status = 2;
            ChangeNormalColorOnPanel1(sender);
            nowPlaying.BringToFront();
            LoadNowPlaying();
            for (int i = 0; i < songsNowPlaying.Count; i++)
            {
                songsNowPlaying[i].Width = panel.Width - 12;
            }
        }
        private void btnPlayList_Click_1(object sender, EventArgs e)
        {
            labelTitle.Text = "Playlist";
            LoadListPlaylist();

            playlist.BringToFront();
            ChangeNormalColorOnPanel1(sender);
        }
        private void btnSetting_Click_1(object sender, EventArgs e)
        {

            ChangeNormalColorOnPanel1(sender);
        }
        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            ChangeNormalColorOnPanel1(sender);
        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
                panelPlay.Location = new Point(601, 21);
                //1143  624
                //1135 thông số của panel 1143, 624 của panel lúc full
                //bunifuSlider1.Value = 50; cần cập nhật value cho control này khi maxmize để tránh làm nát form
            }
            else
            {
                WindowState = FormWindowState.Normal;
                panelPlay.Location = new Point(455, 21);
            }

        }
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLyric_Click(object sender, EventArgs e)
        {
            LoadLyrics();
            lyrics.BringToFront();
        }
        private void lyrics_btnBack_click(object sender, EventArgs e)
        {
            lyrics.SendToBack();
            timer4.Stop();
        }
        #endregion


        #region Shuffle Repeat play volume
        private void BtnShuffle_Click(object sender, EventArgs e)
        {
            //MediaPlayer.Instance.Shuffle();

            if ((string)btnShuffle.Tag == "Off")
            {
                Shuff();
                btnShuffle.Normalcolor = Color.FromArgb(239, 108, 1);
                btnShuffle.Tag = "On";
            }
            else
            {
                btnShuffle.Normalcolor = Color.Transparent;
                btnShuffle.Tag = "Off";
            }
        }
        private void BtnRepeat_Click(object sender, EventArgs e)
        {
            if ((string)btnRepeat.Tag == "Off")
            {
                btnRepeat.Normalcolor = Color.FromArgb(239, 108, 1);
                btnRepeat.Tag = "Repeate";
            }
            else
            {
                if ((string)btnRepeat.Tag == "Repeate")
                {
                    btnRepeat.Iconimage = repeat_one;
                    MediaPlayer.Instance.Repeat();
                    btnRepeat.Tag = "One";
                }
                else
                {
                    btnRepeat.Iconimage = repeat;
                    btnRepeat.Normalcolor = Color.Transparent;
                    btnRepeat.Tag = "Off";
                    MediaPlayer.Instance.RepeatOff();
                }
            }
        }
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            LoadCurrentMedia();

            if (btnPlay.Image == pause)
            {
                btnPlay.Image = play;
                songsCurrent[indexNow].ImageButton = play;
                MediaPlayer.Instance.Pause();
                TimeLine.Stop();
                timer2.Stop();
            }
            else
            {
                if(MediaPlayer.Instance.GetPlayState() == "wmppsPaused")
                {
                    MediaPlayer.Instance.Play();
                }
                else
                    MediaPlayer.Instance.PlayUrl(songsCurrent[indexNow].Path);
                btnPlay.Image = pause;
                songsCurrent[indexNow].ImageButton = pause;

                TimeLine.Start();
                timer2.Start();
            }
        }
        private void BtnVolume_Click(object sender, EventArgs e)
        {
            if (btnVolume.Iconimage == volume_up)
            {
                btnVolume.Iconimage = volume_off;
                MediaPlayer.Instance.Mute();
            }
            else
            {
                btnVolume.Iconimage = volume_up;
                MediaPlayer.Instance.MuteOff();
            }
        }
        #endregion


        private void fMusic_FormClosing(object sender, FormClosingEventArgs e)
        {

            //MediaPlayer.Instance.RemovePlaylist(playlistLocalFile);
            MediaPlayer.Instance.DeletePlaylist();
        }


        #region Timer
        private void TimeLine_Click(object sender, EventArgs e)
        {
            int minus = (int)MediaPlayer.Instance.GetCurrentPosition();
            if (minus <= sliderDuration.MaximumValue)
                sliderDuration.Value = minus;
            labelTimeFrom.Text = ConvertToMinute(MediaPlayer.Instance.GetCurrentPosition());
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (MediaPlayer.Instance.GetPlayState() == "wmppsStopped")
            {
                sliderDuration.Value = 0;
                BtnForward_Click(null, null);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //IWMPMedia media = MediaPlayer.Instance.GetCurrentMedia();
            //int result = (int)media.duration - (int)MediaPlayer.Instance.GetCurrentPosition();
            //if (result == 0)
            //    MediaPlayer.Instance.PlayMediaFormPlayList(playlistCurrent, indexPlay);
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            lyrics.SongImage = rotateImage(new Bitmap(lyrics.SongImage), 1);
        }

        #endregion

        #region event change value
        private void SliderDuration_ValueChanged(object sender, EventArgs e)
        {
            MediaPlayer.Instance.SetCurrentPosition(sliderDuration.Value);
        }

        private void sliderVolumn_ValueChanged(object sender, EventArgs e)
        {
            btnVolume.Iconimage = volume_up;
            MediaPlayer.Instance.MuteOff();
            MediaPlayer.Instance.SetVolumn(sliderVolumn.Value);
        }
        private void panel_SizeChanged(object sender, EventArgs e)
        {
            Thread thread = new Thread(SetSize);
            thread.IsBackground = true;
            thread.Start();
        }
        #endregion


        private void SetSize()
        {
            if (panel.InvokeRequired)
                panel.Invoke(new Action(SetSize));
            else
            {

                int x = panel.Width - 25;
                myMusic.listControl.ForEach((item) => { item.Width = x; });
                x = panel.Width - 12;
                nowPlaying.listControl.ForEach((item) => { item.Width = x; });
            }
        }

        public Bitmap rotateImage(Bitmap bitmap, float angle)
        {
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.TranslateTransform((float)bitmap.Width / 2, (float)bitmap.Height / 2);
                graphics.RotateTransform(angle);
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                graphics.TranslateTransform(-(float)bitmap.Width / 2, -(float)bitmap.Height / 2);
                graphics.DrawImage(bitmap, new Point(0, 0));
                graphics.Dispose();
            }
            return bitmap;
        }

        private void playlist_NewPlaylist_Click(object sender, EventArgs e)
        {
            fNewPlaylist fNewPlaylist = new fNewPlaylist();
            fNewPlaylist.ShowDialog();
            MediaPlayer.Instance.CreatePlaylist(fNewPlaylist.playlistName);
            LoadListPlaylist();
            
        }

        public static string ConvertToMinute(double Second)
        {
            int minute = (int)Second / 60;
            int second = (int)Second % 60;
            return minute.ToString("00") + ":" + second.ToString("00");
        }

    }
}
