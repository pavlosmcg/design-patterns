using System;

namespace Observer
{
    public class TweetEventArgs : EventArgs
    {
        public TweetEventArgs (string author, DateTime publicationTime, string text)
        {
            this.Author = author;
            this.PublicationTime = publicationTime;
            this.Text = text;
        }

        public string Author { get; set; }
        public DateTime PublicationTime { get; set; }
        public string Text { get; set; }
    }
}
