using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Lyric
{
    public class LyricSong
    {
        private static LyricSong instance = new LyricSong();
        private string api;
        private string link = @"https://orion.apiseeds.com/api/music/lyric/";
        private Root root;
        public LyricSong()
        {
            Api = "nnMi4Zxn0Z7IqGvTN9MjsbLifWXrARCWw69OA9AFuUCwNDU9izfhZqysevpZ5Q9u";
            root = null;
        }
        public object GetLyric(string artist, string songName)
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    string json = web.DownloadString(link + artist + @"/" + songName + "?apikey=" + api);
                    root = JsonConvert.DeserializeObject<Root>(json);
                    return root.result.track.text;
                }
                catch
                {
                    return null;
                }
            }
        }


        public static LyricSong Instance { get => instance;}
        public string Api {set => api = value; }
        public string lyrics
        {
            get
            {
                if (root != null)
                    return root.result.track.text;
                else
                    return null;
            }
        }
    }
}
