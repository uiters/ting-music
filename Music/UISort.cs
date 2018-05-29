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
        public static readonly ISortSongFromAToZ iCompareAToZ = new ISortSongFromAToZ();
        public static readonly ISortSongFromZToA iCompareZToA = new ISortSongFromZToA();
        public static readonly ISortSongArtist iCompareArtist = new ISortSongArtist();
        public static readonly ISortSongAlbum iCompareAlbum = new ISortSongAlbum();
        public static string pathSongPlay;
        public static int index = 0;
        public static readonly ISortRanDom iRanDom = new ISortRanDom();
        private static Random random = new Random();
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
        public class ISortRanDom : IComparer<int>
        {
            public int Compare(int a, int b)
            {

                int x = random.Next(0, 40);
                if (x < 10)
                    return 1;
                else
                    if (x < 20)
                    return 0;
                else
                    return -1;
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
            song.Index = index;
            if (index++ % 2 == 0)
                song.BackColor = Color.Silver;
            else
                song.BackColor = Color.Gainsboro;
        }
    }
}
