using System.Collections.Generic;

namespace Observer
{
    internal class Tweeter : ISubject
    {
        private readonly List<IObserver> _followers = new List<IObserver>();
        private Tweet _tweet;

        public void Subscribe(IObserver follower)
        {
            _followers.Add(follower);
        }

        public void Unsubscribe(IObserver follower)
        {
            _followers.Remove(follower);
        }

        public void Notify()
        {
            _followers.ForEach(f => f.Update());
        }

        public Tweet Tweet
        {
            get
            {
                return _tweet;
            }
            set
            {
                _tweet = value;
                this.Notify();
            }
        }

    }
}