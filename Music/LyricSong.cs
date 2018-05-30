
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyric
{
    public class Lyric
    {
        private static Lyric instance = new Lyric();
        private HtmlAgilityPack.HtmlDocument document;
        HtmlWeb html;
        public Lyric()
        {
            html = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8
            };
        }

        public static Lyric Instance
        {
            get
            {
                return instance;
            }
        }

        public string GetLyric(string songName, string artist = null)
        {
            document = html.LoadFromBrowser("https://mp3.zing.vn/tim-kiem/bai-hat.html?q=" + songName);
            string link = null;
            try
            {
                if (artist == null)
                {
                    var data = document.DocumentNode.QuerySelector(".fl .title-song h3 a");
                    link = @"https://mp3.zing.vn" + data.Attributes["href"].DeEntitizeValue;
                    document = html.LoadFromBrowser(link);
                }
                else
                {
                    var data = document.DocumentNode.QuerySelectorAll(".fl .title-song h3 a");
                    foreach (var item in data)
                    {
                        if (item.InnerText.Contains(artist))
                        {
                            link = @"https://mp3.zing.vn" + item.Attributes["href"].DeEntitizeValue;
                            document = html.LoadFromBrowser(link);
                            break;
                        }
                    }
                    if (link == null)
                    {
                        document = null;
                        return null;
                    }

                }
                var lyric = document.DocumentNode.QuerySelector(".fn-container [id] p");
                document = null;
                if (lyric == null)
                    return null;
                else
                {
                    return lyric.InnerHtml.Replace("<br>", "\n");
                }
            }
            catch
            {
                document = null;
                return null;
            }
        }

    }
}
