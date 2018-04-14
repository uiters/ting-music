namespace Lyric
{
    internal class Artist
    {
        public string name { get; set; }
    }

    internal class Lang
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    internal class Track
    {
        public string name { get; set; }
        public string text { get; set; }
        public Lang lang { get; set; }
    }

    internal class Copyright
    {
        public string notice { get; set; }
        public string artist { get; set; }
        public string text { get; set; }
    }

    internal class Result
    {
        public Artist artist { get; set; }
        public Track track { get; set; }
        public Copyright copyright { get; set; }
        public int probability { get; set; }
        public int similarity { get; set; }
    }
    internal class Root
    {
        public Result result;
    }
}
