using System;

namespace Observer
{
    public class TweeterDelegate
    {
        public event EventHandler<TweetEventArgs> Tweeting;

        protected virtual void OnNewTweet(string author, DateTime publicationTime, string text)
        {
            if (Tweeting != null)
            {
                Tweeter(this, new TweetEventArgs(author, publicationTime, text));
            }
        }

        public void NewTweet(Tweet tweet)
        {
            OnNewTweet(tweet.Author, tweet.PublicationTime, tweet.Text);
        }
    }
}