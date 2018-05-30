using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Music
{
    public class SongInfo
    {
        #region constructor      
        private readonly Image imageDefault = Properties.Resources.myMusic;
        internal SongInfo(string filePath) { this.file = TagLib.File.Create(filePath); }
        internal SongInfo() { }
        #endregion

        #region Properties
        private TagLib.File file;

        public string Title { get => file.Tag.Title; }
        public string Artist { get => file.Tag.FirstPerformer; }
        public string Song { get => file.Tag.Title; }
        public string Album { get => file.Tag.Album; }
        public string Genrne { get => file.Tag.FirstGenre; }
        public string Lyrics { get => file.Tag.Lyrics; }
        public System.Drawing.Image LoadImageSong
        {
            get
            {
                TagLib.IPicture firstPicture = file.Tag.Pictures.FirstOrDefault();
                System.Drawing.Image image;

                if (firstPicture != null && firstPicture.Data.Data.Length != 0)
                {
                    var mStream = new MemoryStream();
                    byte[] pData = firstPicture.Data.Data;
                    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                    image = System.Drawing.Image.FromStream(mStream);
                    mStream.Dispose();
                }
                else
                {
                    image = imageDefault;// 
                }
                return image;
            }
        }
        public double Duration
        {
            get => file.Properties.Duration.TotalSeconds;
        }
        #endregion

        #region Method
        internal void SetPath(string filePath)
        {
            if (file != null)
                file.Dispose();
            this.file = TagLib.File.Create(filePath);
        }

        #endregion

        #region Method Static
        internal static string GetTitle(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.Title;
        }
        internal static string GetArtist(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.FirstPerformer;
        }
        internal static string GetSong(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.Title;
        }
        internal static string GetAlbum(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.Album;
        }
        internal static string GetGenrne(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.FirstGenre;
        }
        internal static string GetLyrics(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.Lyrics;
        }
        internal static System.Drawing.Image GetImageSong(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
            {
                TagLib.IPicture firstPicture = file.Tag.Pictures.FirstOrDefault();
                System.Drawing.Image image;

                if (firstPicture != null && firstPicture.Data.Data.Length != 0)
                {
                    var mStream = new MemoryStream();
                    byte[] pData = firstPicture.Data.Data;
                    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                    var bm = new Bitmap(mStream, false);
                    mStream.Dispose();
                    image = bm;
                }
                else
                {
                    image = Music.Properties.Resources.myMusic;
                }
                return image;
            }
        }
        #endregion

        #region Destructor
        ~SongInfo()
        {
            if (file != null)
                file.Dispose();
        }
        #endregion
    }
}
