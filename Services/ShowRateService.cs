using WRA.Models;
using WRA.Services.Interfaces;

namespace WRA.Services
{
    public class ShowRateService : IShowRateService
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
                    winningRate = (1 / tip.NumberOfRaces) * (tip.NumberOfFirstPlaces + tip.NumberOfSecondPlaces + tip.NumberOfThirdPlaces);
                }

                calculationResults.Add(new CalculationResult
                {
                    HorseNumber = tip.HorseNumber,
                    Ranking = tip.ShowRanking,
                    Odds = tip.ShowOdds,
                    Trustworthiness = (1.0f / tip.WinRanking) * tip.ShowRate * 60f + winningRate * 40f,
                    RefundAmount = tip.ShowOdds * tip.Stake
                }
                );
            }

            return calculationResults;
        }
    }
}