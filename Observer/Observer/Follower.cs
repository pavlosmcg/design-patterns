using System;

namespace Observer
{
    class Follower : IObserver
    {
        private readonly Tweeter _tweeter;
        private DateTime _publicationTime;
        private string _text;

        public Follower(Tweeter tweeter)
        {
            _tweeter = tweeter;
            _tweeter.Subscribe(this);
        }

        public void Update()
        {
            _publicationTime = _tweeter.Tweet.PublicationTime;
            _text = _tweeter.Tweet.Text;

            Display();
        }

        private void Display()
        {
            Console.WriteLine("{0} is so SO wise. She tweeted: {1} on {2}", _tweeter, _text, _publicationTime);
        }
    }
}
