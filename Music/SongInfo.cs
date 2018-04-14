using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace Music
{
    public class SongInfo
    {
        private static SongInfo instance;

        public static SongInfo Instance { get { if (instance == null) instance = new SongInfo();return instance; }
            private set => instance = value; }

        public string Title(string filePath)
        {
            TagLib.File file = TagLib.File.Create(filePath);
            return file.Tag.Title;
        }
        public string Artist(string filePath)
        {
            TagLib.File file = TagLib.File.Create(filePath);
            return file.Tag.FirstArtist;
        }
        public string Song(string filePath)
        {
            TagLib.File file = TagLib.File.Create(filePath);
            return file.Tag.Title;
        }
        public string Album(string filePath)
        {
            TagLib.File file = TagLib.File.Create(filePath);
            return file.Tag.Album;
        }
        public string Genrne(string filePath)
        {
            TagLib.File file = TagLib.File.Create(filePath);
            return file.Tag.FirstGenre;
        }
        public string Lyrics(string filePath)
        {
            TagLib.File file = TagLib.File.Create(filePath);
            return file.Tag.Lyrics;
        }
        public System.Drawing.Image LoadImageSong(string filePath)
        {
            System.Drawing.Image image;
            TagLib.File file = TagLib.File.Create(filePath);
            var mStream = new MemoryStream();
            var firstPicture = file.Tag.Pictures.FirstOrDefault();
            if (firstPicture != null && firstPicture.Data.Data.Length != 0)
            {
                byte[] pData = firstPicture.Data.Data;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                var bm = new Bitmap(mStream, false);
                mStream.Dispose();
                image = bm;
            }
            else
            {
                image = new Bitmap(Music.Properties.Resources.myMusic);
            }
            return image;
        }
    }
}
