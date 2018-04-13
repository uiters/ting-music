using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    class UISort
    {
        public static ISortSongFromAToZ iCompareAToZ = new ISortSongFromAToZ();
        public static ISortSongFromZToA iCompareZToA = new ISortSongFromZToA();
        public static ISortSongArtist iCompareArtist = new ISortSongArtist();
        public static ISortSongAlbum iCompareAlbum = new ISortSongAlbum();
        public static string pathSongPlay;
        public static int index = 0;
        #region Sort Songs
        public class ISortSongFromAToZ : IComparer<Song>
        {
            public int Compare(Song x, Song y)
            {
                return x.SongName.CompareTo(y.SongName);
            }
        }
        public class ISortSongFromZToA : IComparer<Song>
        {
            public int Compare(Song a, Song b)
            {
                return b.SongName.CompareTo(a.SongName);
            }
        }
        public class ISortSongArtist : IComparer<Song>
        {
            public int Compare(Song a, Song b)
            {
                return a.ArtistName.CompareTo(b.ArtistName);
            }
        }
        public class ISortSongAlbum : IComparer<Song>
        {
            public int Compare(Song a, Song b)
            {
                //return a.AlbumName.CompareTo(b.AlbumName);
                return 0;
            }
        }
        #endregion

        public static bool Rock(Song song)
        {
            return song.CategoryName.ToLower().Contains("rock");
        }
        public static bool Pop(Song song)
        {
            return song.CategoryName.ToLower().Contains("pop");
        }
        public static bool Other(Song song)
        {
            return !(song.CategoryName.ToLower().Contains("rock") || song.CategoryName.ToLower().Contains("pop"));
        }

        public static bool FindSongNamePlay(Song song)
        { 
            bool ex = song.Path.Contains(pathSongPlay);

            if (song.ImageButton != Properties.Resources.play && !ex) // ex == true // curent play next
                song.ImageButton = Properties.Resources.play;
            return ex;
        }
        public static void SetNumberSong(Song song)
        {
            song.index = index;
            if (index++ % 2 == 0)
                song.BackColor = Color.Silver;
            else
                song.BackColor = Color.Gainsboro;
        }
    }
}
