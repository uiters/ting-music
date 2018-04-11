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
        static MediaPlayer instance;
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        internal static MediaPlayer Instance {
            get { if (instance == null) instance = new MediaPlayer();return instance; }
            private set => instance = value; }

        public string[] LoadLocalFile(IWMPPlaylist playlist)
        {
            //update thêm list path
            string path = @"C:\Users\NguyễnDuyCương\Music";
            string[] listFiles = Directory.GetFiles(path, "*.mp3");
            foreach (var item in listFiles)
            {
                MediaFile file = new MediaFile(item);
                IWMPMedia media= player.newMedia(file.FilePath);
                playlist.appendItem(media);
            }
            return listFiles;
        }
        public Image LoadImageSong(string filePath)
        {
            Image image;
            TagLib.File file = TagLib.File.Create(filePath);
            var mStream = new MemoryStream();
            var firstPicture = file.Tag.Pictures.FirstOrDefault();
            if (firstPicture != null && firstPicture.Data.Data.Length!=0)
            {
                byte[] pData = firstPicture.Data.Data;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                var bm = new Bitmap(mStream,false);
                mStream.Dispose();
                image = bm;
            }
            else
            {
                image = new Bitmap(Application.StartupPath+ "\\icon_song.jpg");
                //image = new Bitmap(@"C:\Users\NguyễnDuyCương\Desktop\icon_song.jpg");
            }
            return image;
        }
        public string LoadLyrics(string filePath)
        {
            TagLib.File file = TagLib.File.Create(filePath);
            return file.Tag.Lyrics;
        }
        public List<string> LoadInfoSong(string filePath)
        {
            List<string> listInfo = new List<string>();
            TagLib.File file = TagLib.File.Create(filePath);
            listInfo.Add(file.Tag.Title);
            listInfo.Add(file.Tag.FirstArtist);
            listInfo.Add(file.Tag.FirstGenre);
            return listInfo;
        }
        public void CreatePlaylist(string name)
        {
            IWMPPlaylist playlist = player.playlistCollection.newPlaylist(name+"_TingMusic");
        }
        public IWMPPlaylist CreatePlaylistForLocalFile()
        {
            return player.playlistCollection.newPlaylist("LocalFile");
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
        public double GetCurrentPosition()
        {
            return player.controls.currentPosition;
        }
        public void SetCurrentPosition(int value)
        {
            player.controls.currentPosition = value;
        }
        public string GetPlayState()
        {
            return player.playState.ToString();
        }
        public void Play()
        {
            player.controls.play();
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
            if (player.settings.getMode("shuffle") == false)
                player.settings.setMode("shuffle", true);
            else player.settings.setMode("shuffle", false);
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
        public void SetVolumn(int volumn)
        {
            player.settings.volume = volumn;
        }
        public int GetVolumn()
        {
            return player.settings.volume;
        }
        public void PlayMediaFromPlaylist(IWMPPlaylist playlist, int index)
        {
            IWMPMedia med = player.currentPlaylist.get_Item(index);
            player.controls.playItem(med);
        }
        public void RemovePlaylist(IWMPPlaylist playlist)
        {
            player.playlistCollection.remove(playlist);
        }
    }
}
