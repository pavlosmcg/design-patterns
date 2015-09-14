using System;

namespace ObserverWithEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            var emily = new Tweeter();

            var worshiperOfAllThingsEmily = new Follower(emily);
            var iWantToBeJustLikeEmilyWhenIGrowUp = new Follower(emily);
            var ardentFollowerOfEmily = new Follower(emily);

            emily.Tweet = new Tweet
            {
                Author = "Emily",
                PublicationTime = DateTime.Now,
                Text = "Words of great wisdom"
            };

            Console.ReadLine();
        }
    }
}
