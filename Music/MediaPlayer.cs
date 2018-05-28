using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Music
{
    
    class MediaPlayer
    {
        static MediaPlayer instance = new MediaPlayer();
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public static MediaPlayer Instance 
        {
            get { return instance; }
            private set => instance = value;
        }
        public WindowsMediaPlayer Player { get => player; }

        #region Method
        public double GetCurrentPosition()
        {
            return player.controls.currentPosition;
        }
        public void SetCurrentPosition(int value)
        {
            player.controls.currentPosition = value;
        }
        public void SetVolumn(int volumn)
        {
            player.settings.volume = volumn;
        }
        public int GetVolumn()
        {
            return player.settings.volume;
        }
        public string GetPlayState()
        {
            return player.playState.ToString();
        }
        public void Play()
        {
            player.controls.play();
        }
        public void Play(string path)
        {
            player.URL = path;
        }
        public void Pause()
        {
            player.controls.pause();
        }
        public void Stop()
        {
            player.controls.stop();
        }
        public void Next()
        {
            player.controls.next();
        }
        public void Previous()
        {
            player.controls.previous();
        }
        public void Shuffle()
        {
            player.settings.setMode("shuffle", !player.settings.getMode("shuffle"));
        }
        public void Repeat()
        {
            player.settings.setMode("loop", true);
            //if (player.settings.getMode("loop") == false)
            //    player.settings.setMode("loop", true);
            //else player.settings.setMode("loop", false);
        }
        public void RepeatOff()
        {
            player.settings.setMode("loop", false);
        }
        public void Mute()
        {
            player.settings.mute = true;
        }
        public void MuteOff()
        {
            player.settings.mute = false;
        }
        #endregion

        public string[] LoadLocalFile()//IWMPPlaylist playlist)
        {
            //string path = @"E:\test";
            string path = @"G:\the nho\Zing MP3";
            string[] listFile = Directory.GetFiles(path, "*.mp3");
            return listFile;
        }
        public List<string> LoadCurrentPlaylist(IWMPPlaylist currentPlaylist)
        {
            List<string> listFile = new List<string>();
            for (int i = 0; i < currentPlaylist.count; i++)
            {
                IWMPMedia media = currentPlaylist.Item[i];
                listFile.Add(media.sourceURL);
            }
            return listFile;
        }
        public IWMPPlaylist CreatePlaylist(string name)
        {
            IWMPPlaylist playlist = player.playlistCollection.newPlaylist(name+"_TingMusic");
            return playlist;
        }
        public IWMPMedia CreateMedia(string path)
        {
            return player.newMedia(path);
        }
        public void AddMediaToPlaylist(string[] listFile, IWMPPlaylist playlist)
        {
            IWMPMedia media;
            foreach (string item in listFile)
            {
                media = player.newMedia(item);
                playlist.appendItem(media);
            }
        }
        public void SelectCurrentPlaylist(IWMPPlaylist playlist)
        {
            player.currentPlaylist = playlist;
            Stop();
        }
        public IWMPMedia GetCurrentMedia()
        {
            return player.currentMedia;
        }
        public void SetCurrentMedia(IWMPMedia media)
        {
            player.currentMedia = media;
        }

        public void PlayUrl(string url)
        {
            player.URL = url;
        }


        public void PlayMediaFormPlayList(int index)
        {
            IWMPMedia med = player.currentPlaylist.get_Item(index);
            player.controls.playItem(med);
        }
        public void PlayMediaFormPlayList(IWMPPlaylist playlist, int index)
        {

            IWMPMedia med = playlist.Item[index];
            //Program.fMusicCurent.sliderDuration.MaximumValue = (int)med.duration + 1;
            player.URL = med.sourceURL;
        }
        public void RemovePlaylist(IWMPPlaylist playlist)
        {
            player.playlistCollection.remove(playlist);
        }
        public List<string> LoadListPlaylist()
        {
            //Demo thooi
            List<string> listMedia = new List<string>();
            IWMPPlaylistArray playlistArray = player.playlistCollection.getAll();
            for (int i = 0; i < playlistArray.count; i++)
            {
                if (playlistArray.Item(i).name.Contains("_TingMusic"))
                {
                    string media = playlistArray.Item(i).name.Split('_')[0];
                    listMedia.Add(media);
                }
                
            }
            return listMedia;
        }
        public void DeletePlaylist()
        {
            //IWMPPlaylistArray plCollection = player.playlistCollection.getByName("LocalFile");
            //if (plCollection.count > 0)
            //{
            //    IWMPPlaylist pl = plCollection.Item(0);
            //    player.playlistCollection.remove(pl);
            //}
            for (int i = 0; i < player.currentPlaylist.count; i++)
            {
                IWMPMedia med = player.currentPlaylist.get_Item(i);
                player.currentPlaylist.removeItem(med);
            }
        }
    }
}
