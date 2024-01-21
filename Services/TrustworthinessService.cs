using WRA.Models;
using WRA.Services.Interfaces;

namespace WRA.Services
{
    public class TrustworthinessService : ITrustworthinessService
    {
        private int _ranking;

        public List<Tip> CalculateTrustworthinessByOdds(List<WinShowRate> winShowRates, List<Tip> tips)
        {
            _ranking = 0;

            tips = tips.OrderBy(tip => tip.WinOdds).ToList();

            foreach (Tip tip in tips)
            {
                tip.Ranking = _ranking + 1;
                tip.WinRate = winShowRates[_ranking].WinRate;
                _ranking++;
            }

            _ranking = 0;

            tips = tips.OrderBy(tip => tip.ShowOdds).ToList();

            foreach (Tip tip in tips)
            {
                tip.Ranking = _ranking + 1;
                tip.ShowRate = winShowRates[_ranking].ShowRate;
                _ranking++;
            }

            tips = tips.OrderBy(tip => tip.HorseNumber).ToList();

            return tips;
        }
    }
}