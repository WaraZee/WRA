using WRA.Models;
using WRA.Services.Interfaces;

namespace WRA.Services
{
    public class ShowRateService : IShowRateService
    {
        public List<CalculationResult> CalculateByCourse(List<Tip> tips)
        {
            List<CalculationResult> calculationResults = new List<CalculationResult>();
            float winningRate;

            foreach (Tip tip in tips)
            {
                if (tip.NumberOfRaces > 0)
                {
                    winningRate = (1.0f / tip.NumberOfRaces) * (tip.NumberOfFirstPlaces + tip.NumberOfSecondPlaces + tip.NumberOfThirdPlaces);
                }
                else
                {
                    winningRate = 0f;
                }

                calculationResults.Add(new CalculationResult
                {
                    HorseNumber = tip.HorseNumber,
                    Ranking = tip.ShowRanking,
                    Odds = tip.ShowOdds,
                    Trustworthiness = ((tips.Min(tip => tip.ShowOdds) / tip.ShowOdds) * tip.ShowRate * 60f) + (winningRate * 40f),
                    RefundAmount = tip.ShowOdds * tip.Stake
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
                    winningRate = (1.0f / tip.NumberOfRaces) * (tip.NumberOfFirstPlaces + tip.NumberOfSecondPlaces + tip.NumberOfThirdPlaces);
                }
                else
                {
                    winningRate = 0f;
                }

                // 単勝オッズを基準とした複勝率のため、WinOddsで探索
                float showRate = rates.FirstOrDefault(rate => rate.WinOdds == tip.WinOdds)?.ShowRate ?? 0;

                calculationResults.Add(new CalculationResult
                {
                    HorseNumber = tip.HorseNumber,
                    Ranking = tip.ShowRanking,
                    Odds = tip.ShowOdds,
                    Trustworthiness = (showRate * 60f) + (winningRate * 40f),
                    RefundAmount = tip.ShowOdds * tip.Stake
                }
                );
            }

            return calculationResults;
        }
    }
}