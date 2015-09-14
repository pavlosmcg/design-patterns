using System;
using System.Collections.Generic;

namespace ObserverWithEventHandler
{
    internal class Tweeter
    {
        private Tweet _tweet;
        public event EventHandler<TweetEventArgs> TweetPublished;

        public Tweet Tweet
        {
            get
            {
                return _tweet;
            }
            set
            {
                _tweet = value;
                TweetPublished(this, new TweetEventArgs(_tweet));
            }
        }

    }
}