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
        #region Properties static
        public static readonly ISortSongFromAToZ iCompareAToZ = new ISortSongFromAToZ();
        public static readonly ISortSongFromZToA iCompareZToA = new ISortSongFromZToA();

        public static readonly ISortArtistAtoZ iCompareArtistAtoZ = new ISortArtistAtoZ();
        public static readonly ISortArtistZtoA iCompareArtistZtoA = new ISortArtistZtoA();

        public static readonly ISortAlbumAtoZ iCompareAlbumAtoZ = new ISortAlbumAtoZ();
        public static readonly ISortAlbumZtoA iCompareAlbumZtoA = new ISortAlbumZtoA();

        public static readonly ISortRanDom iRanDom = new ISortRanDom();
        private static readonly Random random = new Random();

        #endregion


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
        #endregion

        #region Artist
        public class ISortArtistAtoZ : IComparer<Myplaylist>
        {
            public int Compare(Myplaylist a, Myplaylist b)
            {
                return a.PlaylistName.CompareTo(b.PlaylistName);
            }
        }
        public class ISortArtistZtoA : IComparer<Myplaylist>
        {
            public int Compare(Myplaylist a, Myplaylist b)
            {
                return b.PlaylistName.CompareTo(a.PlaylistName);
            }
        }
        #endregion

        #region Albums
        public class ISortAlbumAtoZ : IComparer<Myplaylist>
        {
            public int Compare(Myplaylist a, Myplaylist b)
            {
                return a.PlaylistName.CompareTo(b.PlaylistName);
            }
        }
        public class ISortAlbumZtoA : IComparer<Myplaylist>
        {
            public int Compare(Myplaylist a, Myplaylist b)
            {
                return b.PlaylistName.CompareTo(a.PlaylistName);
            }
        }
        #endregion

        #region Random
        public class ISortRanDom : IComparer<int>
        {
            public int Compare(int a, int b)
            {

                int x = random.Next(0, 40);
                if (x % 5 < 2)
                    return 1;
                else
                    if (x % 11 < 7)
                    return -1;
                else
                    return 0;
            }
        }
        #endregion
    }
}
