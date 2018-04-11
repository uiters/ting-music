using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using WMPLib;

namespace Music
{
    public partial class fMusic : Form
    {
        IWMPPlaylist playlistLocalFile;
        IWMPPlaylist playlistCurrent;
        Image pause; 
        Image play;
        Image repeat;
        Image repeat_one;
        Image volume_off;
        Image volume_up;

        public fMusic()
        {
            InitializeComponent();
            LoadData();
           
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
            btnPlay.Image =play;
            #endregion
            LoadLocalFile();
            playlistCurrent = playlistLocalFile;
            //cần cập nhập lại playlistCurrent mỗi khi phát ở 1 playlist mới
        }
        public void LoadLocalFile()
        {
            playlistLocalFile = MediaPlayer.Instance.CreatePlaylistForLocalFile();
            string[] listFile = MediaPlayer.Instance.LoadLocalFile(playlistLocalFile);
            int i = 0;
            foreach (var item in listFile)
            {
                MediaFile file = new MediaFile(item);
                IWMPMedia media = MediaPlayer.Instance.CreateMedia(file.FilePath);
                playlistLocalFile.appendItem(media);
                Song song = new Song();
                song.index = i;
                media.name = i.ToString();
                song.ButtonPlay_Click += Song_ButtonPlay_Click;
                song.ImageSong= MediaPlayer.Instance.LoadImageSong(file.FilePath);
                List<string> listInfo=MediaPlayer.Instance.LoadInfoSong(file.FilePath);
                if (i % 2 == 0)
                    song.BackColor = Color.Silver;
                else
                    song.BackColor = Color.Gainsboro;
                song.SongName = listInfo[0];
                song.ArtistName = listInfo[1];
                song.CategoryName = listInfo[2];
                song.TotalTime = ConvertToMinute(media.duration);
                myMusic.song = song;
                i++;
            }
            MediaPlayer.Instance.SelectCurrentPlaylist(playlistLocalFile);
            LoadCurrentMedia();
        }
        private void Song_ButtonPlay_Click(object sender, EventArgs e)
        {
            Song song = sender as Song;
            IWMPMedia media = MediaPlayer.Instance.GetCurrentMedia();
            song.ImageButton = pause;
            MediaPlayer.Instance.PlayMediaFromPlaylist(playlistCurrent, song.index);
            btnPlay.Image = pause;
            LoadCurrentMedia();
            timer1.Start();
            timer2.Start();
        }

        public void LoadCurrentMedia()
        {
            IWMPMedia media = MediaPlayer.Instance.GetCurrentMedia();
            string path = media.sourceURL;
            pictureBoxSong.Image = MediaPlayer.Instance.LoadImageSong(path);
            List<string> listInfo = MediaPlayer.Instance.LoadInfoSong(path);
            lblSongName.Text = listInfo[0];
            lblArtistName.Text = listInfo[1];
            double duration = media.duration;
            labelTimeFrom.Text = "00:00";
            labelTimeTo.Text = ConvertToMinute(duration);
            foreach (Control item in myMusic.listSong)
            {
                if((item as Song).SongName==media.name)
                {
                    if (MediaPlayer.Instance.GetPlayState() == "wmppsPlaying")
                        (item as Song).ImageButton = Music.Properties.Resources.pause;
                    else
                        if (MediaPlayer.Instance.GetPlayState() == "wmppsPaused")
                        (item as Song).ImageButton = Music.Properties.Resources.play;
                    myMusic.ScrollControl = item;
                }
                else
                {
                    //if (MediaPlayer.Instance.GetPlayState() == "wmppsPlaying")
                    //    (item as Song).ImageButton = Music.Properties.Resources.pause;
                    //else
                    //    if (MediaPlayer.Instance.GetPlayState() == "wmppsPaused")
                        (item as Song).ImageButton = Music.Properties.Resources.play;
                }
            }
            
        }
        public string ConvertToMinute(double Second)
        {
            int minute = (int)Second / 60;
            int second= (int)Second % 60;
            return minute.ToString("00") + ":" + second.ToString("00");
        }
        public void ChangeNormalColorOnPanel1(object sender)
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
            ChangeNormalColorOnPanel1(sender);
        }

        private void btnRecentPlays_Click_1(object sender, EventArgs e)
        {
            ChangeNormalColorOnPanel1(sender);
        }

        private void btnNowPlaying_Click_1(object sender, EventArgs e)
        {
            ChangeNormalColorOnPanel1(sender);
        }

        private void btnPlayList_Click_1(object sender, EventArgs e)
        {
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

     

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            MediaPlayer.Instance.Shuffle();
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
                if(btnRepeat.Iconimage==repeat)
                {
                    IWMPMedia media = MediaPlayer.Instance.GetCurrentMedia();
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
            if(btnPlay.Image== pause)
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
            if(btnVolume.Iconimage==volume_up)
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

        private void myMusic1_Load(object sender, EventArgs e)
        {

        }

        private void fMusic_FormClosing(object sender, FormClosingEventArgs e)
        {
            MediaPlayer.Instance.RemovePlaylist(playlistLocalFile);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            MediaPlayer.Instance.Next();
            LoadCurrentMedia();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            MediaPlayer.Instance.Previous();
            LoadCurrentMedia();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IWMPMedia media = MediaPlayer.Instance.GetCurrentMedia();
            double duration = media.duration;
            sliderDuration.MaximumValue = (int)duration;
            sliderDuration.Value = (int)MediaPlayer.Instance.GetCurrentPosition();
            labelTimeFrom.Text = ConvertToMinute(MediaPlayer.Instance.GetCurrentPosition());
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //IWMPMedia media = MediaPlayer.Instance.GetCurrentMedia();
            //int result = (int)media.duration - (int)MediaPlayer.Instance.GetCurrentPosition();
            if ((int)MediaPlayer.Instance.GetCurrentPosition()==0)
            LoadCurrentMedia();
        }

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

        private void timer3_Tick(object sender, EventArgs e)
        {
            IWMPMedia media = MediaPlayer.Instance.GetCurrentMedia();
            int result = (int)media.duration - (int)MediaPlayer.Instance.GetCurrentPosition();
            if (result == 0)
            {
                MediaPlayer.Instance.PlayMediaFromPlaylist(playlistCurrent,int.Parse(media.name));
            }


        }
    }
}
