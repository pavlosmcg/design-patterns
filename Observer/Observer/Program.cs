using System;

namespace Observer
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
                PublicationTime = new DateTime(2015, 9, 14, 13, 30, 00),
                Text = "Words of great wisdom"
            };

            Console.ReadLine();

        }
    }
}