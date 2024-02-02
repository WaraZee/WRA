using WRA.Models;
using WRA.Services.Interfaces;

namespace WRA.Services
{
    public class WinRateService : IWinRateService
    {
        public List<CalculationResult> CalculateByCourse(List<Tip> tips)
        {
            List<CalculationResult> calculationResults = new List<CalculationResult>();
            float winningRate;

            foreach (Tip tip in tips)
            {
                if (tip.NumberOfRaces > 0)
                {
                    winningRate = (1.0f / tip.NumberOfRaces) * (tip.NumberOfFirstPlaces * 1.0f + tip.NumberOfSecondPlaces * 0.8f + tip.NumberOfThirdPlaces * 0.6f);
                }
                else
                {
                    winningRate = 0f;
                }

                calculationResults.Add(new CalculationResult
                {
                    HorseNumber = tip.HorseNumber,
                    Ranking = tip.WinRanking,
                    Odds = tip.WinOdds,
                    Trustworthiness = (tips.Min(tip => tip.WinOdds) / tip.WinOdds) * tip.WinRate * 60f + winningRate * 40f,
                    RefundAmount = tip.WinOdds * tip.Stake
                }
                );
            }

            return calculationResults;
        }

        public List<CalculationResult> CalculateByWinOdds(List<Rate> rates, List<Tip> tips)
        {
            List<CalculationResult> calculationResults = new List<CalculationResult>();
            float winningRate;

            foreach (Tip tip in tips)
            {
                if (tip.NumberOfRaces > 0)
                {
                    winningRate = (1.0f / tip.NumberOfRaces) * (tip.NumberOfFirstPlaces * 1.0f + tip.NumberOfSecondPlaces * 0.8f + tip.NumberOfThirdPlaces * 0.6f);
                }
                else
                {
                    winningRate = 0f;
                }

                float winRate = rates.FirstOrDefault(rate => rate.WinOdds == tip.WinOdds)?.WinRate ?? 0;

                calculationResults.Add(new CalculationResult
                {
                    HorseNumber = tip.HorseNumber,
                    Ranking = tip.WinRanking,
                    Odds = tip.WinOdds,
                    Trustworthiness = (winRate * 60f) + (winningRate * 40f),
                    RefundAmount = tip.WinOdds * tip.Stake
                }
                );
            }

            return calculationResults;
        }
    }
}