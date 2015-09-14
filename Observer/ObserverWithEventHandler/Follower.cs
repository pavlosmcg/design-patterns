using System;

namespace ObserverWithEventHandler
{
    class Follower
    {
        public Follower(Tweeter tweeter)
        {
            tweeter.TweetPublished += Update;
        }

        public void Update(Object sender, TweetEventArgs tweetData)
        {
            Display(tweetData);
        }

        private void Display(TweetEventArgs tweetData)
        {
            Console.WriteLine("{0} is so SO wise, what an event!. She tweeted: {1} on {2}", tweetData.Author, tweetData.Text, tweetData.PublicationTime);
        }
    }
}
