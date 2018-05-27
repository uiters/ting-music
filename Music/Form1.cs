using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using WMPLib;

namespace Music
{
    public partial class fMusic : Form
    {
        private IWMPPlaylist playlistLocalFile;
        private IWMPPlaylist playlistCurrent;
        int status;
        Image pause;
        Image play;
        Image repeat;
        Image repeat_one;
        Image volume_off;
        Image volume_up;

        public IWMPPlaylist PlaylistLocalFile { get => playlistLocalFile; set => playlistLocalFile = value; }
        public IWMPPlaylist PlaylistCurrent { get => playlistCurrent; set { playlistCurrent = value; UpdateCountSongs(); } }

        public fMusic()
        {
            InitializeComponent();
            InitializePlaySong();
            LoadData();
            //this.DoubleBuffered = true;
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        public void LoadData()
        {
            #region loadGUI
            panelLeft.Width = 223;
            panelPlay.Location = new Point(455, 21);
            repeat = Music.Properties.Resources.repeat;
            repeat_one = Music.Properties.Resources.repeat_one;
            btnRepeat.Iconimage = repeat;
            volume_off = Music.Properties.Resources.volume_off;
            volume_up = Music.Properties.Resources.volume_up;
            btnVolume.Iconimage = volume_up;
            pause = Music.Properties.Resources.pause;
            play = Music.Properties.Resources.play;
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
            playlistCurrent = playlistLocalFile;

            //cần cập nhập lại playlistCurrent mỗi khi phát ở 1 playlist mới
        }
        public void LoadLocalFile()
        {
            myMusic.Clear();
            PlaylistLocalFile = MediaPlayer.Instance.CreatePlaylistForLocalFile();
            string[] listFile = MediaPlayer.Instance.LoadLocalFile();//PlaylistLocalFile);
            int i = 0;
            foreach (var item in listFile)
            {
                MediaFile file = new MediaFile(item);
                IWMPMedia media = MediaPlayer.Instance.CreateMedia(file.FilePath);
                PlaylistLocalFile.appendItem(media);

                Song song = new Song();
                song.index = i++;
                song.Path = file.FilePath;
                song.ButtonPlay_Click += Song_ButtonPlay_Click;

                song.ImageSong = SongInfo.Instance.LoadImageSong(file.FilePath);
                song.SongName = SongInfo.Instance.Song(file.FilePath);
                song.ArtistName = SongInfo.Instance.Artist(file.FilePath);
                song.CategoryName = SongInfo.Instance.Genrne(file.FilePath);
                song.TotalTime = ConvertToMinute(media.duration);
                media.name = song.SongName;

                if (i % 2 == 0)
                    song.BackColor = Color.Silver;
                else
                    song.BackColor = Color.Gainsboro;
                myMusic.song = song;

                GC.Collect();
            }
            myMusic.Tag = myMusic.listSong;
            myMusic.SetTag = myMusic.listSong;
            PlaylistCurrent = playlistLocalFile;
            MediaPlayer.Instance.SetCurrentMedia(playlistLocalFile.Item[0]);
            MediaPlayer.Instance.Stop();
            LoadCurrentMedia();
        }
        private void Song_ButtonPlay_Click(object sender, EventArgs e)
        {
            Song song = sender as Song;
            IWMPMedia media = MediaPlayer.Instance.GetCurrentMedia();

            song.ImageButton = pause;

            playSong(song.index);
            btnPlay.Image = pause;

            LoadCurrentMedia();
            timer1.Start();
            timer2.Start();
        }
        public void LoadCurrentMedia()
        {
            IWMPMedia media = MediaPlayer.Instance.GetCurrentMedia();
            


            string path = media.sourceURL;

            pictureBoxSong.Image = SongInfo.Instance.LoadImageSong(path);
            lblSongName.Text = SongInfo.Instance.Song(path);
            lblArtistName.Text = SongInfo.Instance.Artist(path);
            double duration = media.duration;

            labelTimeFrom.Text = "00:00";
            labelTimeTo.Text = ConvertToMinute(duration);

            UISort.pathSongPlay = path;
            try
            {
                if (status == 0)
                {
                    Song song = myMusic.listSong.FindAll(UISort.FindSongNamePlay)[0];
                    if (MediaPlayer.Instance.GetPlayState() == "wmppsPlaying")
                        song.ImageButton = Music.Properties.Resources.pause;
                    else
                    if (MediaPlayer.Instance.GetPlayState() == "wmppsPaused")
                        song.ImageButton = Music.Properties.Resources.play;
                    myMusic.ScrollControl = song;
                }
                if (status == 2)
                {
                    Song song = nowPlaying.listSong.FindAll(UISort.FindSongNamePlay)[0];
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
            GC.Collect();
        }
        public void LoadLyrics()
        {
            IWMPMedia media = MediaPlayer.Instance.GetCurrentMedia();
            string path = media.sourceURL;
            lyrics.SongImage = SongInfo.Instance.LoadImageSong(path);
            lyrics.LyricsText = SongInfo.Instance.Lyrics(path);
            lyrics.ArtistName = SongInfo.Instance.Artist(path);
            lyrics.SongName = SongInfo.Instance.Song(path);

            //timer4.Start();
        }
        public void LoadNowPlaying()
        {
            nowPlaying.Clear();

            List<string> listFile = MediaPlayer.Instance.LoadCurrentPlaylist(PlaylistCurrent);
            int i = 0;
            foreach (var item in listFile)
            {

                MediaFile file = new MediaFile(item);
                IWMPMedia media = MediaPlayer.Instance.CreateMedia(file.FilePath);

                Song song = new Song();
                song.index = i++;
                song.ButtonPlay_Click += Song_ButtonPlay_Click;
                song.ImageSong = SongInfo.Instance.LoadImageSong(file.FilePath);
                song.Path = file.FilePath;
                song.SongName = SongInfo.Instance.Song(file.FilePath);
                song.ArtistName = SongInfo.Instance.Artist(file.FilePath);
                song.CategoryName = SongInfo.Instance.Genrne(file.FilePath);
                song.TotalTime = ConvertToMinute(media.duration);
                media.name = song.SongName;

                if (i % 2 == 0)
                    song.BackColor = Color.Silver;
                else
                    song.BackColor = Color.Gainsboro;
                nowPlaying.song = song;
            }
            //MediaPlayer.Instance.SelectCurrentPlaylist(playlistCurrent);
            //LoadCurrentMedia();
            GC.Collect();
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

        public string ConvertToMinute(double Second)
        {
            int minute = (int)Second / 60;
            int second = (int)Second % 60;
            return minute.ToString("00") + ":" + second.ToString("00");
        }
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
        private void btnNavigationPanel_Click_1(object sender, EventArgs e)
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
        private void btnMyMusic_Click_1(object sender, EventArgs e)
        {
            status = 0;
            PlaylistCurrent = PlaylistLocalFile;
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
            foreach (Control item in nowPlaying.listControl)
            {
                item.Width = panel.Width - 12;
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
        private void btnForward_Click(object sender, EventArgs e)
        {
            //MediaPlayer.Instance.Next();
            nextSong();
            LoadCurrentMedia();
            LoadLyrics();
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            //MediaPlayer.Instance.Previous();
            previousSong();
            LoadCurrentMedia();
            LoadLyrics();
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
        #region Shuffle Repeat play volume
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            //MediaPlayer.Instance.Shuffle();

            if (btnShuffle.Normalcolor == Color.Transparent)
            {
                btnShuffle.Normalcolor = Color.FromArgb(239, 108, 1);
            }
            else
            {
                btnShuffle.Normalcolor = Color.Transparent;
            }
        }
        private void btnRepeat_Click(object sender, EventArgs e)
        {
            if (btnRepeat.Normalcolor == Color.Transparent)
            {
                btnRepeat.Normalcolor = Color.FromArgb(239, 108, 1);
                MediaPlayer.Instance.Repeat();
                timer3.Stop();
            }
            else
            {
                if (btnRepeat.Iconimage == repeat)
                {
                    btnRepeat.Iconimage = repeat_one;
                    timer3.Start();
                }
                else
                {
                    btnRepeat.Iconimage = repeat;
                    btnRepeat.Normalcolor = Color.Transparent;
                    timer3.Stop();
                }
            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (btnPlay.Image == pause)
            {
                btnPlay.Image = play;
                MediaPlayer.Instance.Pause();
                timer1.Stop();
                timer2.Stop();
            }
            else
            {
                btnPlay.Image = pause;
                MediaPlayer.Instance.Play();
                timer1.Start();
                timer2.Start();
            }
            LoadCurrentMedia();
        }
        private void btnVolume_Click(object sender, EventArgs e)
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            IWMPMedia media = MediaPlayer.Instance.GetCurrentMedia();
            sliderDuration.Value = (int)MediaPlayer.Instance.GetCurrentPosition();

            labelTimeFrom.Text = ConvertToMinute(MediaPlayer.Instance.GetCurrentPosition());
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if ((int)MediaPlayer.Instance.GetCurrentPosition() == 0 && MediaPlayer.Instance.GetPlayState() == "wmppsPlaying")
            {
                LoadCurrentMedia();
                LoadLyrics();
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            IWMPMedia media = MediaPlayer.Instance.GetCurrentMedia();
            int result = (int)media.duration - (int)MediaPlayer.Instance.GetCurrentPosition();
            if (result == 0)
                MediaPlayer.Instance.PlayMediaFormPlayList(playlistCurrent, indexPlay);
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            lyrics.SongImage = rotateImage(new Bitmap(lyrics.SongImage), 1);
        }

        #endregion


        private void sliderDuration_ValueChanged(object sender, EventArgs e)
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
            Thread thread = new Thread(() =>
            {
                int x = panel.Width - 25;
                myMusic.listControl.ForEach((item) => { item.Width = x; });
                x = panel.Width - 12;
                nowPlaying.listControl.ForEach((item) => { item.Width = x; });
            }
            );
            thread.IsBackground = true;
            thread.Start();
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
    }
}
