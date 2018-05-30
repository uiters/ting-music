using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private List<Song> songsFull = new List<Song>();
        private List<Song> songsLocalFile = new List<Song>();//
        private List<Song> songsRecent = new List<Song>();
        private List<Song> songsNowPlaying = new List<Song>();//
        private int indexNow = -1;
        int status;
        Action func;

        public fMusic()
        {
            InitializeComponent();
            btnShuffle.Tag = "Off";
            btnRepeat.Tag = "Off";
            InitializePlaySong();

            InitializeData();
            func = OpenLyric;
        }

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
        #region Load
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
            CopyList(songsLocalFile, songsNowPlaying);
            if (songsLocalFile.Count > 0)
            {
                indexNow = 0;
                ShowInfoMeadia(songsNowPlaying[0]);
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
            if (songsNowPlaying.Count == 0) return;
            Song song = songsNowPlaying[indexNow];

            pictureBoxSong.Image = song.ImageSong;
            lblSongName.Text = song.SongName;
            lblArtistName.Text = song.ArtistName;
            labelTimeFrom.Text = "00:00";
            labelTimeTo.Text = song.TotalTime;

            UISort.pathSongPlay = songsNowPlaying[indexNow].Path;
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
            string path = songsNowPlaying[indexNow].Path;

            SongInfo info = new SongInfo(path);

            lyrics.SongImage = info.LoadImageSong;
            lyrics.LyricsText = info.Lyrics;
            lyrics.ArtistName = info.Artist;
            lyrics.SongName = info.Song;

            info = null;
            GC.Collect();
            //if (lyrics.LyricsText == string.Empty)
            //    lyrics.LyricsText=(string)Lyric.LyricSong.Instance.GetLyric(lyrics.ArtistName, lyrics.SongName)?? "";
            //timer4.Start();
        }
        public void LoadNowPlaying()
        {
            nowPlaying.Clear();
            nowPlaying.AddSongs(songsNowPlaying.ToArray());

        }
        public void LoadListPlaylist()
        {

            playlist.Clear();
            List<string> listPlaylist = MediaPlayer.Instance.LoadListPlaylist();
            foreach (var item in listPlaylist)
            {
                MediaFile mediaFile = new MediaFile(item);
                Myplaylist myplaylist = new Myplaylist();
                myplaylist.Tag = item;
                myplaylist.BtnImage_Click += Myplaylist_BtnImage_Click1;

                myplaylist.PlaylistName = MediaPlayer.Instance.GetTitlePlaylist(item);

                if(MediaPlayer.Instance.ReadPlaylist(item).Count>0)
                myplaylist.PlaylistImage = SongInfo.GetImageSong(MediaPlayer.Instance.ReadPlaylist(item)[0]);

                playlist.myplaylist = myplaylist;
            }
        }
        public Song GetMediaExists(string mediaPath)
        {
            for (int j = 0; j < songsFull.Count; j++)
            {
                if (songsFull[j].Path == mediaPath)
                {
                    return songsFull[j];
                }
            }
            return null;
        }
        public void LoadPlaylistDetails(string playlistPath)
        {
            List<string> listMediaPath = MediaPlayer.Instance.ReadPlaylist(playlistPath);

            SongInfo info = new SongInfo();
            int i = 0;
            songsNowPlaying.Clear();
            foreach (var item in listMediaPath)
            {
                MediaFile file = new MediaFile(item);

                Song song = GetMediaExists(item);
                if (song == null)
                    song = Song.CreateSong(file, info, Song_ButtonPlay_Click, i);
                else
                    song.Index = i;
                playlistDetail.AddSong(song);
                songsNowPlaying.Add(song);
                i++;
            }
            indexNow = 0;
            GC.Collect();
        }
        private void Myplaylist_BtnImage_Click1(object sender, EventArgs e)
        { 
            Myplaylist myplaylist = sender as Myplaylist;
            string playlistPath = myplaylist.Tag.ToString();

            playlistDetail.PlaylistImage = myplaylist.PlaylistImage;
            playlistDetail.PlaylistName = myplaylist.PlaylistName;
            playlistDetail.totalSong = MediaPlayer.Instance.ReadPlaylist(playlistPath).Count;

            playlistDetail.Clear();

            LoadPlaylistDetails(playlistPath);

            playlistDetail.BringToFront();
        }

        private void CopyList(List<Song> songsA, List<Song> songsB)
        {
            songsB.Clear();
            songsB.AddRange(songsA);
        }

        #endregion

        #region Click
        private void Song_ButtonPlay_Click(object sender, EventArgs e)
        {
            //Song song = sender as Song;
            //IWMPMedia media = MediaPlayer.Instance.GetCurrentMedia();
            //song.ImageButton = pause;
            //MediaPlayer.Instance.PlayMediaFromPlaylist(PlaylistCurrent, song.index);
            //btnPlay.Image = pause;
            //LoadCurrentMedia();
            //timeLine.Start();
            //timer2.Start();
            if (indexNow == -1) return;
            Song song = sender as Song;
            if (indexNow != -1)
            {
                Song songPlay = songsNowPlaying[indexNow];
                songPlay.ImageButton = play;
            }
            indexNow = song.Index;
            song.ImageButton = pause;
            MediaPlayer.Instance.Play(song.Path);
            btnPlay.Image = pause;
            RecentAdd(songsNowPlaying[indexNow]);
            ShowInfoMeadia(song);
            timeLine.Start();
            timer2.Start();
        }
        public static string ConvertToMinute(double Second)
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
        private void btnBack_Click(object sender, EventArgs e)
        {

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
            labelTitle.Text = "My music";
            ChangeNormalColorOnPanel1(sender);
            myMusic.BringToFront();
            int x = panel.Width - 25;
            songsNowPlaying.Clear();
            indexNow = 0;

            for (int i = 0; i < songsLocalFile.Count; i++)
            {
                songsNowPlaying.Add(songsLocalFile[i]);
                songsLocalFile[i].Width = x;
                myMusic.AddSong(songsLocalFile[i]);
            }

        }
        private void btnRecentPlays_Click_1(object sender, EventArgs e)
        {
            status = 1;
            nowPlaying.BringToFront();
            nowPlaying.Clear();
            ChangeNormalColorOnPanel1(sender);
            int x = panel.Width - 20;          
            for (int i = songsRecent.Count - 1; i >= 0; i--)
            {
                nowPlaying.AddSong(songsRecent[i]);
                songsRecent[i].Width = x;
            }
        }
        private void btnNowPlaying_Click_1(object sender, EventArgs e)
        {
            labelTitle.Text = "Now playing";
            status = 2;
            ChangeNormalColorOnPanel1(sender);
            
            LoadNowPlaying();
            int x = panel.Width - 20;
            for (int i = 0; i < nowPlaying.listControl.Count; i++)
            {
                nowPlaying.listControl[i].Width = x;
            }
            nowPlaying.BringToFront();
        }
        private void btnPlayList_Click_1(object sender, EventArgs e)
        {
            status = 3;
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
            //LoadCurrentMedia();
            if (btnPlay.Image == pause)
            {
                btnPlay.Image = play;
                songsNowPlaying[indexNow].ImageButton = play;
                MediaPlayer.Instance.Pause();
                timeLine.Stop();
                timer2.Stop();
            }
            else
            {
                if (MediaPlayer.Instance.GetPlayState() == "wmppsPaused")
                {
                    MediaPlayer.Instance.Play();
                }
                else
                {
                    RecentAdd(songsNowPlaying[indexNow]);
                    ShowInfoMeadia(songsNowPlaying[indexNow]);
                    MediaPlayer.Instance.PlayUrl(songsNowPlaying[indexNow].Path);
                }
                btnPlay.Image = pause;
                songsNowPlaying[indexNow].ImageButton = pause;
                timeLine.Start();
                timer2.Start();
            }
        }
        private void RecentAdd(Song song)
        {
            songsRecent.Add(song);
            if (songsRecent.Count > 50)
                songsRecent.RemoveAt(songsRecent.Count - 1);


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

        #region Next & Pre & play
        private void BtnForward_Click(object sender, EventArgs e)
        {
            if (indexNow == -1) return;
            songsNowPlaying[indexNow].ImageButton = play; // song pre
            NextSong(); // set index song next
            SetSong();
            LoadLyrics();
            timer2.Start();
            timeLine.Start();
            imageSong = new Bitmap(lyrics.SongImage);
            RecentAdd(songsNowPlaying[indexNow]);

            angles = 0;
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            //MediaPlayer.Instance.Previous();
            if (indexNow == -1) return;
            songsNowPlaying[indexNow].ImageButton = play; // song pre
            PreviousSong(); // set index song next
            SetSong();
            LoadLyrics();
            timer2.Start();
            timeLine.Start();
            RecentAdd(songsNowPlaying[indexNow]);
            imageSong = new Bitmap(lyrics.SongImage);
            angles = 0;
        }
        private void SetSong()
        {
            Song song = songsNowPlaying[indexNow];
            song.ImageButton = pause; // song now
            MediaPlayer.Instance.Play(song.Path);
            ShowInfoMeadia(song);
            btnPlay.Image = pause;
            nowPlaying.ScrollControl = song;
            myMusic.ScrollControl = song;
        }
        #endregion

        #region Timer
        private void TimeLine_Tick(object sender, EventArgs e)
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
                imageSong = new Bitmap(lyrics.SongImage);
                angles = 0;
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        { 
        //{
        //    IWMPMedia media = MediaPlayer.Instance.GetCurrentMedia();
        //    int result = (int)media.duration - (int)MediaPlayer.Instance.GetCurrentPosition();
        //    if (result == 0)
        //        foreach (Control item in myMusic.listSong)
        //            if ((item as Song).SongName == media.name)
        //                MediaPlayer.Instance.PlayMediaFromPlaylist(PlaylistCurrent, (item as Song).index);
        //}
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            lyrics.SongImage = rotateImage(1);
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
            //foreach (Control item in myMusic.listControl)
            //{
            //    item.Width = panel.Width - 25;
            //}
            //foreach (Control item in nowPlaying.listControl)
            //{
            //    item.Width = panel.Width - 20;
            //}
            //foreach (Control item in playlistDetail.listControl)
            //{
            //    item.Width = panel.Width - 20;
            //}
            Thread thread = new Thread(SetSize);
            thread.IsBackground = true;
            thread.Start();
        }
        private void SetSize()
        {
            if (panel.InvokeRequired)
                panel.Invoke(new Action(SetSize));
            else
            {

                int x = panel.Width - 25;
                myMusic.listControl.ForEach((item) => { item.Width = x; });
                x = panel.Width - 20;
                nowPlaying.listControl.ForEach((item) => { item.Width = x; });
                playlistDetail.listControl.ForEach((item) => { item.Width = x; });
            }
        }

        #endregion

        #region Method
        private void OpenLyric()
        {
            timer4.Start();
            LoadLyrics();
            lyrics.BringToFront();
            func = CloseLyric;
        }
        private void CloseLyric()
        {
            timer4.Stop();
            lyrics.SendToBack();
            func = OpenLyric;
        }
        private void btnLyric_Click(object sender, EventArgs e)
        {
            func();
            imageSong = new Bitmap(lyrics.SongImage);
            angles = 0;
        }
        Bitmap imageSong;
        private void lyrics_btnBack_click(object sender, EventArgs e)
        {
            lyrics.SendToBack();
            func = OpenLyric;
            timer4.Stop();
        }
        //public Bitmap rotateImage(Bitmap bitmap, float angle)
        //{
        //    Bitmap returnBitmap = new Bitmap(bitmap.Height, bitmap.Width);
        //    using (Graphics graphics = Graphics.FromImage(returnBitmap))
        //    {
        //        graphics.TranslateTransform((float)bitmap.Width / 2, (float)bitmap.Height / 2);
        //        graphics.RotateTransform(angle);
        //        graphics.TranslateTransform(-(float)bitmap.Width / 2, -(float)bitmap.Height / 2);
        //        graphics.DrawImage(bitmap,Point.Empty);
        //    }
        //    return returnBitmap;
        //}
        float angles = 0;
        public Bitmap rotateImage( float angle)
        {
            if (imageSong != null)
            {
                Bitmap returnBitmap = new Bitmap(imageSong.Height, imageSong.Width);
                if (angles < 360-angle)
                {
                    angles += angle;
                }
                else
                    angles = 0;
                using (Graphics graphics = Graphics.FromImage(returnBitmap))
                {
                    graphics.TranslateTransform((float)imageSong.Width / 2, (float)imageSong.Height / 2);
                    graphics.RotateTransform(angles);
                    graphics.TranslateTransform(-(float)imageSong.Width / 2, -(float)imageSong.Height / 2);
                    graphics.DrawImage(imageSong, Point.Empty);
                }
                return returnBitmap;
            }
            return null;
        }
        private void playlist_NewPlaylist_Click(object sender, EventArgs e)
        {
        //    fNewPlaylist fNewPlaylist = new fNewPlaylist();
        //    fNewPlaylist.ShowDialog();
        //    MediaPlayer.Instance.CreatePlaylist(fNewPlaylist.playlistName);
        //    LoadListPlaylist();
        }

        #endregion
    }
}
