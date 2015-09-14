using System.Collections.Generic;

namespace ObserverExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var meerkats = new List<Meerkat>
            {
                new Meerkat(),
                new Meerkat(),
            };

            var bestMeerkatPaperOfNews = new MeerkovoNews(meerkats);

            bestMeerkatPaperOfNews.PublishNewsItem("Sergei congratulates Corbyn on his win for glorious workers party of Great Britains");
        }
    }
}
