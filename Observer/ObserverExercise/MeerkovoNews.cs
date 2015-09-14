using System.Collections.Generic;

namespace ObserverExercise
{
    class MeerkovoNews
    {
        private readonly List<Meerkat> _loyalReadersOfBestNewsPaperInMeerkovo;

        public MeerkovoNews(List<Meerkat> loyalReadersOfBestNewsPaperInMeerkovo)
        {
            _loyalReadersOfBestNewsPaperInMeerkovo = loyalReadersOfBestNewsPaperInMeerkovo;
        }

        // decouple meerkat and add mongoose
        public void PublishNewsItem(string news)
        {
            foreach(var meerkat in _loyalReadersOfBestNewsPaperInMeerkovo)
            {
                meerkat.TellAllTheExciteNews(news);
            }   
        }
    }
}
