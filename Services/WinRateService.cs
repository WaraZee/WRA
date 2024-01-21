using WRA.Models;
using WRA.Services.Interfaces;

namespace WRA.Services
{
    public class WinRateService : IWinRateService
    {
        public List<CalculationResult> Calculate(List<Tip> tips)
        {
            List<CalculationResult> calculationResults = new List<CalculationResult>();
            float winningRate;

            foreach (Tip tip in tips)
            {
                if (tip.NumberOfRaces == 0)
                {
                    winningRate = 0f;
                }
                else
                {
                    winningRate = (1 / tip.NumberOfRaces) * (tip.NumberOfFirstPlaces * 1.0f + tip.NumberOfSecondPlaces * 0.8f + tip.NumberOfThirdPlaces * 0.6f);
                }

                calculationResults.Add(new CalculationResult
                {
                    HorseNumber = tip.HorseNumber,
                    Ranking = tip.WinRanking,
                    Odds = tip.WinOdds,
                    Trustworthiness = (1.0f / tip.WinRanking) * tip.WinRate * 60f + winningRate * 40f,
                    RefundAmount = tip.WinOdds * tip.Stake
                }
                );
            }

            return calculationResults;
        }
    }
}