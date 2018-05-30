using System;
using System.Collections.Generic;
using WMPLib;

namespace Music
{
    public partial class fMusic
    {
        private Action nextSong;
        private Action previousSong;
        private Action shuffle;
        private Action<int> playSong;

        private int countSongs = 0;
        private List<int> listIndex = new List<int>();
        private int iOfListIndex;

        private void Shuff()
        {
            iOfListIndex = 0;
            listIndex.Clear();
            for (int i = 0; i < songsNowPlaying.Count; i++)
                listIndex.Add(i);
            listIndex.Sort(UISort.iRanDom.Compare);
            GC.Collect();
        }
        private int CountSongs
        {
            get => countSongs;
            set
            {
                if (value != countSongs)
                {
                    countSongs = value;
                    listIndex.Clear();
                    for (int i = 0; i < countSongs; i++)
                        listIndex.Add(i);
                }
            }
        }
        public void UpdateCountSongs()
        {
            CountSongs = songsNowPlaying.Count;
        }
        private void InitializePlaySong()
        {
            nextSong = NextSong;
            previousSong = PreviousSong;
            shuffle = ShuffleOff;
            playSong = PlaySong;
        }
        private void NextSong()
        {
            //indexPlay = indexPlay < CountSongs - 1 ? indexPlay + 1 : 0; // if(indexPlay >= countSongs) indexplay = 0; else indexplay ++;
            //if (MediaPlayer.Instance.GetPlayState() != "wmppsPlaying")
            //    PlayOrStopSong(playlistCurrent, indexPlay, false);
            //else
            //    PlayOrStopSong(playlistCurrent, indexPlay, true);
            switch (btnShuffle.Tag as string)
            {
                case "On":
                    if(iOfListIndex + 1 >= listIndex.Count)
                    {
                        indexNow = listIndex[0];
                        iOfListIndex = 0;
                    }else
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
            //indexPlay = indexPlay > 0 ? indexPlay - 1 : CountSongs -1;
            //if (MediaPlayer.Instance.GetPlayState() != "wmppsPlaying")
            //    PlayOrStopSong(playlistCurrent, indexPlay, false);
            //else
            //    PlayOrStopSong(playlistCurrent, indexPlay, true);.            int tag = (int)btnShuffle.Tag;
            switch (btnShuffle.Tag as string)
            {
                case "On":
                    if (iOfListIndex -1 < 0)
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
        private void NextSongShuffle()
        {
            //indexPlay = indexPlay < CountSongs - 1 ? indexPlay + 1 : 0; // if(indexPlay >= countSongs) indexplay = 0; else indexplay ++;
            //if (MediaPlayer.Instance.GetPlayState() == "wmppsPaused")
            //    PlayOrStopSong(playlistCurrent, listIndex[indexPlay], false);
            //else
            //    PlayOrStopSong(playlistCurrent, listIndex[indexPlay], true);
        }
        private void PreviousSongShuffle()
        {
            //indexPlay = indexPlay > 0 ? indexPlay - 1 : CountSongs - 1;
            //if (MediaPlayer.Instance.GetPlayState() == "wmppsPaused")
            //    PlayOrStopSong(playlistCurrent, listIndex[indexPlay], false);
            //else
            //    PlayOrStopSong(playlistCurrent, listIndex[indexPlay], true);
        }
        private void ShuffleOff()
        {
            shuffle = ShuffleOn;
            previousSong = PreviousSong;
            nextSong = NextSong;
        }
        private void ShuffleOn()
        {
            shuffle = ShuffleOff;
            listIndex.Sort(UISort.iRanDom);
            previousSong = PreviousSongShuffle;
            nextSong = NextSongShuffle;
        }
        private void PlaySong(int index)
        {
            //MediaPlayer.Instance.PlayMediaFormPlayList(PlaylistCurrent, index);
        }
        private void PlayOrStopSong(IWMPPlaylist playlist, int index, bool play)
        {
            MediaPlayer.Instance.PlayMediaFormPlayList(playlist, index);
            if (play == false)
                MediaPlayer.Instance.Stop();
        }     
    }
}