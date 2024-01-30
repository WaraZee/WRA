using WRA.Models;
using WRA.Services.Interfaces;

namespace WRA.Services
{
    public class TrustworthinessService : ITrustworthinessService
    {
        private int _ranking;

        public List<Tip> CalculateTrustworthinessByOdds(List<Rate> winShowRates, List<Tip> tips)
        {
            _ranking = 0;

            foreach (Tip tip in tips)
            {
                if (tip.WinOdds <= 0)
                {
                    tip.WinOdds = 1000f;
                }
                if (tip.ShowOdds <= 0)
                {
                    tip.ShowOdds = 1000f;
                }
                if (tip.TrierceOdds <= 0)
                {
                    tip.TrierceOdds = 1000f;
                }
                if (tip.TrioOdds <= 0)
                {
                    tip.TrioOdds = 1000f;
                }
            }

            tips = tips.OrderBy(tip => tip.WinOdds).ToList();

            foreach (Tip tip in tips)
            {
                tip.WinRanking = _ranking + 1;
                tip.WinRate = winShowRates[_ranking].WinRate;
                _ranking++;
            }

            _ranking = 0;

            tips = tips.OrderBy(tip => tip.ShowOdds).ToList();

            foreach (Tip tip in tips)
            {
                tip.ShowRanking = _ranking + 1;
                tip.ShowRate = winShowRates[_ranking].ShowRate;
                _ranking++;
            }

            tips = tips.OrderBy(tip => tip.HorseNumber).ToList();

            return tips;
        }
    }
}