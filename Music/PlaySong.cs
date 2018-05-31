using System;
using System.Collections.Generic;
using WMPLib;

namespace Music
{
    public partial class fMusic
    {
        #region Properties
        private List<int> listIndex = new List<int>();
        private int iOfListIndex;
        #endregion

        #region Method
        private void Shuff()
        {
            iOfListIndex = 0;
            listIndex.Clear();
            for (int i = 0; i < songsNowPlaying.Count; i++)
                listIndex.Add(i);
            listIndex.Sort(UISort.iRanDom.Compare);
            GC.Collect();
        }
        private void NextSong()
        {
            switch (btnShuffle.Tag as string)
            {
                case "On":
                    if (iOfListIndex + 1 >= listIndex.Count)
                    {
                        indexNow = listIndex[0];
                        iOfListIndex = 0;
                    }
                    else
                    {
                        indexNow = listIndex[++iOfListIndex];
                    }
                    break;
                default:
                        indexNow = (indexNow + 1 >= songsNowPlaying.Count) ? 0 : indexNow + 1;
                    break;
            }
        }
        private void PreviousSong()
        {
            switch (btnShuffle.Tag as string)
            {
                case "On":
                    if (iOfListIndex - 1 < 0)
                    {
                        iOfListIndex = listIndex.Count - 1;
                        indexNow = listIndex[iOfListIndex];

                    }
                    else
                    {
                        indexNow = listIndex[--iOfListIndex];
                    }
                    break;
                default:
                        indexNow = (indexNow - 1 < 0) ? songsNowPlaying.Count - 1 : indexNow - 1;
                    break;
            }
        }
    }
}