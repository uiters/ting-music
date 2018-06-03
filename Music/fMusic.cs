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
        private List<Song> songsNowPlaying = new List<Song>();
        private List<Song> songsLocalFile = new List<Song>();
        private List<Song> songsRecent = new List<Song>();
        private List<Song> songsSelected = new List<Song>();
        private List<string> listPlaylist = new List<string>();
        private Action actionOpenLyric;
        private Bitmap imageSong;
        private Song songNow = null;
        private Song preSong = null;
        private int indexNow = -1;
        private int status;
        private float angles = 0;
        private bool isExchange;

        public fMusic()
        {
            InitializeComponent();
            btnShuffle.Tag = "Off";
            btnRepeat.Tag = "Off";
            InitializeData();
            actionOpenLyric = OpenLyric;
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
            //cần cập nhập lại playlistCurrent mỗi khi phát ở 1 playlist mới
        }
        #region Load
        public void LoadLocalFile()
        {
            myMusic.Clear();
            string[] listFile = MediaPlayer.Instance.LoadLocalFile();
            int width = panel.Width - 25;

            SongInfo info = new SongInfo();
            for (int i = 0; i < listFile.Length; i++)
            {
                MediaFile file = new MediaFile(listFile[i]);
                Song song = Song.CreateSong(file, info, Song_ButtonPlay_Click, i,contextMenuStripSong,Song_Mouse_Click);
                songsFull.Add(song);
                song.Width = width;
                songsLocalFile.Add(song);
                myMusic.AddSong(song);
            }
            CopyList(songsLocalFile, songsNowPlaying);
            if (songsLocalFile.Count > 0)
            {
                indexNow = 0;
                //songNow = songsNowPlaying[0];
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
            (contextMenuStripSong.Items[2] as ToolStripMenuItem).DropDownItems.Clear();
            playlist.Clear();
            listPlaylist.Clear();
            listPlaylist = MediaPlayer.Instance.LoadListPlaylist();
            foreach (var item in listPlaylist)
            {
                MediaFile mediaFile = new MediaFile(item);
                Myplaylist myplaylist = new Myplaylist();
                myplaylist.Tag = item;
                myplaylist.BtnImage_Click += Myplaylist_BtnImage_Click1;

                myplaylist.PlaylistName = MediaPlayer.Instance.GetTitlePlaylist(item);

                if (MediaPlayer.Instance.ReadPlaylist(item).Count > 0)
                    myplaylist.PlaylistImage = SongInfo.GetImageSong(MediaPlayer.Instance.ReadPlaylist(item)[0]);

                playlist.myplaylist = myplaylist;
                //ContextMenuStrip
                (contextMenuStripSong.Items[2] as ToolStripMenuItem).DropDownItems.Add(myplaylist.PlaylistName,null, MenuItem_Click);
            }
        }
        private void MenuItem_Click(object sender,EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            string playlistTitle = menuItem.Text;
            string playlistPath = MediaPlayer.Instance.GetPlaylistPath(playlistTitle, listPlaylist);
            foreach (var item in songsSelected)
            {
                MediaPlayer.Instance.AddMediaOnPlayList(playlistPath,item.Path);
            }
            MessageBox.Show("Add to playlist successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    song = Song.CreateSong(file, info, Song_ButtonPlay_Click, i,contextMenuStripSong,Song_Mouse_Click);
                else
                    song.BackColor = (i % 2 == 0) ? Color.Silver : Color.Gainsboro; // change color
                playlistDetail.AddSong(song);
                songsNowPlaying.Add(song);
                i++;
            }
            indexNow = 0;
            GC.Collect();
        }
        public void ChangeNormalColorOnPanelLeft(object sender)
        {
            BunifuFlatButton btn = sender as BunifuFlatButton;
            btn.Normalcolor = Color.FromArgb(239, 108, 1);
            foreach (Control item in panel1.Controls)
            {
                if (item.Name != btn.Name && item.BackColor != Color.Transparent)
                {
                    BunifuFlatButton btn1 = item as BunifuFlatButton;
                    btn1.Normalcolor = Color.Transparent;
                }
            }
        }
        public void ChangeIconListSong()
        {
            for (int i = 0; i < songsNowPlaying.Count; i++)
            {
                songsNowPlaying[i].ImageButton = play;
            }
        }
        public void ChangeColorLeftMouseButton(Song song=null)
        {
           
            for (int i = 0; i < songsNowPlaying.Count; i++)
            {
                songsNowPlaying[i].BackColor = (i % 2 == 0) ? Color.Silver : Color.Gainsboro;
            }
            if(isCtrl||isCtrlA)
            foreach (var item in songsSelected)
            {
                item.BackColor = Color.Gray;
            }
            if(!isCtrl)
                if(song!=null)
            song.BackColor = Color.Gray;
        }
        public void ChangeColorRightMouseButton(Song song)
        {
            song.BackColor = Color.Gray;
            System.Windows.Forms.Timer changeColorTimer = new System.Windows.Forms.Timer();
            changeColorTimer.Interval = 200;
            changeColorTimer.Start();
            changeColorTimer.Tick += ChangeColorTimer_Tick;
        }

        private void ChangeColorTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < songsNowPlaying.Count; i++)
            {
                songsNowPlaying[i].BackColor = (i % 2 == 0) ? Color.Silver : Color.Gainsboro;
            }
            if (songNow != null)
                songNow.BackColor = Color.Gray;
            System.Windows.Forms.Timer timer = sender as System.Windows.Forms.Timer;
            timer.Stop();
        }

        private void Myplaylist_BtnImage_Click1(object sender, EventArgs e)
        { 
            Myplaylist myplaylist = sender as Myplaylist;
            string playlistPath = myplaylist.Tag.ToString();

            playlistDetail.Tag = playlistPath;
            playlistDetail.PlaylistImage = myplaylist.PlaylistImage;
            playlistDetail.PlaylistName = myplaylist.PlaylistName;
            playlistDetail.totalSong = MediaPlayer.Instance.ReadPlaylist(playlistPath).Count;

            playlistDetail.Clear();

            LoadPlaylistDetails(playlistPath);
            isExchange = true;
            playlistDetail.BringToFront();
        }

        private static void CopyList(List<Song> songsA, List<Song> songsB)
        {
            songsB.Clear();
            songsB.AddRange(songsA);
        }
        public bool IsExistSong(Song song)
        {
            foreach (var item in songsSelected)
            {
                if (item == song)
                    return true;
            }
            return false;
        }
        #endregion
        
        #region Click
        private void Song_Mouse_Click(object sender, MouseEventArgs e)
        {
            preSong = contextMenuStripSong.Tag as Song;
            Song song = sender as Song;
            if (e.Button == MouseButtons.Right)
            {
                if (!isCtrlA && !isCtrl)
                    ChangeColorRightMouseButton(song);
            }
            if (e.Button == MouseButtons.Left)
            {
                if (isCtrl)
                {
                    if (song != preSong && preSong != null)
                    {
                        if (!IsExistSong(preSong))
                            songsSelected.Add(preSong);
                    }
                    if (!IsExistSong(song))
                        songsSelected.Add(song);
                }
                else
                {
                    songsSelected.Clear();
                    if (!IsExistSong(song))
                        songsSelected.Add(song);
                }

                ChangeColorLeftMouseButton(song);
            }
            contextMenuStripSong.Tag = song;
        }
        private void Song_ButtonPlay_Click(object sender, EventArgs e)
        {
            Song song = sender as Song;
            if (songNow != null)
                songNow.ImageButton = play;
            songNow = song;
            if (indexNow != -1)
            {
                if (isExchange)
                {
                    switch (status)
                    {
                        case 0:
                            songsNowPlaying = songsLocalFile;
                            Shuff();
                            break;
                        case 1:
                            PlaySongNow(song);
                            return;
                        case 3:
                            songsNowPlaying = playlistDetail.listSong;
                            Shuff();
                            break;
                        default:
                            break;
                    }
                    isExchange = false;
                }
                indexNow = songsNowPlaying.IndexOf(song); // playlist
            }
            PlaySongNow(song);
        }
        private void PlaySongNow(Song song)
        {
            song.ImageButton = pause;
            btnPlay.Image = pause;
            MediaPlayer.Instance.Play(song.Path);
            RecentAdd(song);
            ShowInfoMeadia(song);
            timeLine.Start();
            timer2.Start();
            //ChangeColorPlaySong(song);
        }
        public static string ConvertToMinute(double Second)
        {
            int minute = (int)Second / 60;
            int second = (int)Second % 60;
            return minute.ToString("00") + ":" + second.ToString("00");
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
            isExchange = true;
            labelTitle.Text = "My music";
            ChangeNormalColorOnPanelLeft(sender);
            myMusic.Clear();
            int width = panel.Width - 25;

            for (int i = 0; i < songsLocalFile.Count; i++)
            {
                songsLocalFile[i].Width = width;
                songsLocalFile[i].BackColor = (i % 2 == 0) ? Color.Silver : Color.Gainsboro;

                myMusic.AddSong(songsLocalFile[i]);
            }
            myMusic.ScrollControl = songNow;
            myMusic.BringToFront();

        }
        private void btnRecentPlays_Click_1(object sender, EventArgs e)
        {
            status = 1;
            isExchange = true;
            nowPlaying.Clear();
            ChangeNormalColorOnPanelLeft(sender);
            int width = panel.Width - 20;
            for (int i = 0; i < songsRecent.Count; ++i)
            {
                nowPlaying.AddSong(songsRecent[i]);
                songsRecent[i].Width = width;
                songsRecent[i].BackColor = (i % 2 == 0) ? Color.Silver : Color.Gainsboro;
            }
            nowPlaying.ScrollControl = songNow;
            nowPlaying.BringToFront();
        }
        private void btnNowPlaying_Click_1(object sender, EventArgs e)
        {
            labelTitle.Text = "Now playing";
            status = 2;
            isExchange = true;
            ChangeNormalColorOnPanelLeft(sender);
            nowPlaying.Clear();

            int width = panel.Width - 20;
            for (int i = 0; i < songsNowPlaying.Count; i++)
            {
                songsNowPlaying[i].BackColor = (i % 2 == 0) ? Color.Silver : Color.Gainsboro;
                songsNowPlaying[i].Width = width;
                nowPlaying.AddSong(songsNowPlaying[i]);
            }
            nowPlaying.ScrollControl = songNow;
            nowPlaying.BringToFront();
        }
        private void btnPlayList_Click_1(object sender, EventArgs e)
        {
            status = 3;
            labelTitle.Text = "Playlist";
            LoadListPlaylist();
            playlist.BringToFront();
            ChangeNormalColorOnPanelLeft(sender);
        }
        private void btnSetting_Click_1(object sender, EventArgs e)
        {

            ChangeNormalColorOnPanelLeft(sender);
        }
        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            ChangeNormalColorOnPanelLeft(sender);
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
                btnRepeat.Tag = "Repeat";
            }
            else
            {
                if ((string)btnRepeat.Tag == "Repeat")
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
            if (indexNow == -1) return;
            //LoadCurrentMedia();
            if (btnPlay.Image == pause)
            {
                btnPlay.Image = play;
                songNow.ImageButton = play;

                MediaPlayer.Instance.Pause();
                timeLine.Stop();
                timer2.Stop();
                timer4.Stop();
            }
            else
            {
                if (MediaPlayer.Instance.GetPlayState() == "wmppsPaused")
                {
                    MediaPlayer.Instance.Play();
                }
                else
                {
                    songNow = songsNowPlaying[indexNow];
                    RecentAdd(songNow);
                    ShowInfoMeadia(songNow);
                    MediaPlayer.Instance.PlayUrl(songNow.Path);
                }
                btnPlay.Image = pause;
                songNow.ImageButton = pause;
                timeLine.Start();
                timer2.Start();
                timer4.Start();
            }
            //ChangeColorPlaySong(songNow);
        }
        private void RecentAdd(Song song)
        {
            songsRecent.Remove(song);
            songsRecent.Insert(0, song);

            if (status == 1)
            {
                nowPlaying.AddHeadSong(song);
                song.Width = panel.Width - 20;
                song.BackColor = Color.Silver;

                for (int i = 1; i < songsRecent.Count; i++)
                {
                    songsRecent[i].BackColor = (i % 2 == 0) ? Color.Silver : Color.Gainsboro;
                }
                if (isExchange == false)
                    songsNowPlaying.Add(song);
            }
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
            // song pre
            NextSong(); // set index song next
            SetSong();
            LoadLyrics();
            timer2.Start();
            timeLine.Start();
            imageSong = new Bitmap(lyrics.SongImage);
            angles = 0;
            //ChangeColorPlaySong(songNow);
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            //MediaPlayer.Instance.Previous();
            if (indexNow == -1) return;
            PreviousSong(); // set index song next
            SetSong();
            LoadLyrics();
            timer2.Start();
            timeLine.Start();
            imageSong = new Bitmap(lyrics.SongImage);
            angles = 0;
            //ChangeColorPlaySong(songNow);
        }
        private void SetSong()
        {
            if (songNow != null)
                songNow.ImageButton = play;
            songNow = songsNowPlaying[indexNow]; // get song now

            songNow.ImageButton = pause; // song now
            btnPlay.Image = pause;

            MediaPlayer.Instance.Play(songNow.Path);
            ShowInfoMeadia(songNow);
            RecentAdd(songNow);
            switch (status)
            {
                case 0:
                    myMusic.ScrollControl = songNow;
                    break;
                case 3:
                    playlistDetail.ScrollControl = songNow;
                    break;
                default:
                    nowPlaying.ScrollControl = songNow;
                    break;
            }
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
                int indexPre = indexNow;
                NextSong();
                //ChangeColorPlaySong(songNow);
                if ((string)btnRepeat.Tag == "Off" && indexNow < indexPre)
                {
                    songNow.ImageButton = play;
                    songNow = null;
                    ShowInfoMeadia(songsNowPlaying[indexNow]);
                    btnPlay.Image = play;
                    timeLine.Stop();
                    timer2.Stop();
                    
                }
                else
                {
                    indexNow = indexPre;
                    BtnForward_Click(null, null);
                }
                imageSong = new Bitmap(lyrics.SongImage);
                angles = 0;
                sliderDuration.Value = 0;

                
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
            actionOpenLyric = CloseLyric;
        }
        private void CloseLyric()
        {
            timer4.Stop();
            lyrics.SendToBack();
            actionOpenLyric = OpenLyric;
        }
        private void btnLyric_Click(object sender, EventArgs e)
        {
            actionOpenLyric();
            imageSong = new Bitmap(lyrics.SongImage);
            angles = 0;
        }
        private void lyrics_btnBack_click(object sender, EventArgs e)
        {
            lyrics.SendToBack();
            actionOpenLyric = OpenLyric;
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
            fNewPlaylist fNewPlaylist = new fNewPlaylist();
            fNewPlaylist.ShowDialog();
            LoadListPlaylist();
        }

        #endregion

        private void pictureBoxSong_Click(object sender, EventArgs e)
        {
            actionOpenLyric();
            imageSong = new Bitmap(lyrics.SongImage);
            angles = 0;
        }

        private void playlistDetail_Rename_Click(object sender, EventArgs e)
        {
            fRenamePlaylist fRenamePlaylist = new fRenamePlaylist(playlistDetail.Tag.ToString());
            fRenamePlaylist.ShowDialog();
            playlistDetail.PlaylistName = fRenamePlaylist.txbNewPlaylist.Text;
        }

        private void playlistDetail_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this playlist?", "Quesition", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MediaPlayer.Instance.DeletePlaylist(playlistDetail.Tag.ToString());
                MessageBox.Show("Delete playlist successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playlist.BringToFront();
                LoadListPlaylist();
            }
        }

        private void menuItemPlay_Click(object sender, EventArgs e)
        {
            ChangeIconListSong();
            songNow = contextMenuStripSong.Tag as Song;
            RecentAdd(songNow);
            ShowInfoMeadia(songNow);
            MediaPlayer.Instance.PlayUrl(songNow.Path);
            btnPlay.Image = pause;
            songNow.ImageButton = pause;
            timeLine.Start();
            timer2.Start();
            timer4.Start();
            //ChangeColorPlaySong(songNow);
        }

        private void menuItemSelectAll_Click(object sender, EventArgs e)
        {
            if (indexNow == -1) return;
            // song pre
            NextSong(); // set index song next
            SetSong();
            LoadLyrics();
            timer2.Start();
            timeLine.Start();
            imageSong = new Bitmap(lyrics.SongImage);
            angles = 0;
            //ChangeColorPlaySong(songNow);
        }
        public void LoadInfoSong(Song song)
        {
            song.SongName = SongInfo.GetTitle(song.Path);
            song.ArtistName = SongInfo.GetArtist(song.Path);
            song.CategoryName = SongInfo.GetGenrne(song.Path);
        }
        private void menuItemProperties_Click(object sender, EventArgs e)
        {
            Song song = contextMenuStripSong.Tag as Song;
            fEditInfo fEditInfo = new fEditInfo(song.Path);
            fEditInfo.ShowDialog();
            LoadInfoSong(song);
        }

        private void menuItemProperties_Click_1(object sender, EventArgs e)
        {
            Song song = contextMenuStripSong.Tag as Song;
            fProperties fProperties = new fProperties(song.Path);
            fProperties.ShowDialog();
        }

        private void myMusic_Load(object sender, EventArgs e)
        {

        }
        bool isCtrl = false,isCtrlA=false;
        private void fMusic_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.ControlKey)
            {
                
                if (isCtrlA)
                    isCtrl = false;
                else
                    isCtrl = true;
            }
            if (e.KeyCode == Keys.A )
            {
                isCtrlA = true;
                isCtrl = false;
               if (!songsSelected.Count.Equals(songsNowPlaying.Count))
                {
                    songsSelected.Clear();
                    songsSelected.AddRange(songsNowPlaying);
                    ChangeColorLeftMouseButton();
                }
            }

            this.KeyUp += FMusic_KeyUp;
           
        }

        private void contextMenuStripSong_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            isCtrl = isCtrlA = false;
        }

        private void FMusic_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                isCtrl = false;

            }
            if (e.KeyCode == Keys.A)
            {
                isCtrlA = false;

            }
        }
    }
}
