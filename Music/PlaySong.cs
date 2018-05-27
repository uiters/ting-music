using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WMPLib;

namespace Music
{
    public partial class fMusic
    {
        private Action nextSong;
        private Action previousSong;
        private Action shuffle;
        private Action<int> playSong;
        private int indexPlay = 0;
        private int countSongs = 0;
        private List<int> listIndex;

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
            CountSongs = playlistCurrent.count;
        }
        private void InitializePlaySong()
        {
            listIndex = new List<int>();
            nextSong = NextSong;
            previousSong = PreviousSong;
            shuffle = ShuffleOff;
            playSong = PlaySong;
        }
        private void NextSong()
        {
            indexPlay = indexPlay < CountSongs - 1 ? indexPlay + 1 : 0; // if(indexPlay >= countSongs) indexplay = 0; else indexplay ++;
            if (MediaPlayer.Instance.GetPlayState() != "wmppsPlaying")
                PlayOrStopSong(playlistCurrent, indexPlay, false);
            else
                PlayOrStopSong(playlistCurrent, indexPlay, true);

        }
        private void PreviousSong()
        {
            indexPlay = indexPlay > 0 ? indexPlay - 1 : CountSongs -1;
            if (MediaPlayer.Instance.GetPlayState() != "wmppsPlaying")
                PlayOrStopSong(playlistCurrent, indexPlay, false);
            else
                PlayOrStopSong(playlistCurrent, indexPlay, true);



        }
        private void NextSongShuffle()
        {
            indexPlay = indexPlay < CountSongs - 1 ? indexPlay + 1 : 0; // if(indexPlay >= countSongs) indexplay = 0; else indexplay ++;
            if (MediaPlayer.Instance.GetPlayState() == "wmppsPaused")
                PlayOrStopSong(playlistCurrent, listIndex[indexPlay], false);
            else
                PlayOrStopSong(playlistCurrent, listIndex[indexPlay], true);
        }
        private void PreviousSongShuffle()
        {
            indexPlay = indexPlay > 0 ? indexPlay - 1 : CountSongs - 1;
            if (MediaPlayer.Instance.GetPlayState() == "wmppsPaused")
                PlayOrStopSong(playlistCurrent, listIndex[indexPlay], false);
            else
                PlayOrStopSong(playlistCurrent, listIndex[indexPlay], true);
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
            MediaPlayer.Instance.PlayMediaFormPlayList(PlaylistCurrent, index);
        }
        private void PlayOrStopSong(IWMPPlaylist playlist, int index, bool play)
        {
            MediaPlayer.Instance.PlayMediaFormPlayList(playlist, index);
            if (play == false)
                MediaPlayer.Instance.Stop();
        }     
    }
}