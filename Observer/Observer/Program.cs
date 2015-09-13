using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var emily = new TweeterDelegate();

            emily.Tweeter += (s, e) =>
                Console.WriteLine("{0} tweeted: {1} at {2}", e.Author, e.Text, e.PublicationDate);

            //Follower worshiperOfAllThingsEmily = new Follower(emily);
            //Follower iWantToBeJustLikeEmilyWhenIGrowUp = new Follower(emily);
            //Follower ardentFollowerOfEmily = new Follower(emily);

            emily.NewTweet(new Tweet
            {
                Author = "Emily",
                PublicationTime = new DateTime(2015, 9, 14, 13, 30, 00),
                Text = "Words of great wisdom"
            });

            Console.ReadLine();

        }
    }
}