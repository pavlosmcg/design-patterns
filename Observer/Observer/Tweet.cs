using System;

namespace Observer
{
    public class Tweet
    {
        public string Author { get; set; }
        public DateTime PublicationTime { get; set; }
        public string Text { get; set; }

        public Tweet(string author, DateTime publicationTime, string text)
        {
            Author = author;
            PublicationTime = publicationTime;
            Text = text;
        }
    }
}