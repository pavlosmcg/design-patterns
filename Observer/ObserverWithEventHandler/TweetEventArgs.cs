using System;

namespace ObserverWithEventHandler
{
    public class TweetEventArgs : EventArgs
    {
        public TweetEventArgs (Tweet tweet)
        {
            this.Author = tweet.Author;
            this.PublicationTime = tweet.PublicationTime;
            this.Text = tweet.Text;
        }

        public string Author { get; set; }
        public DateTime PublicationTime { get; set; }
        public string Text { get; set; }
    }
}
