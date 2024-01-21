using WRA.Models;
using WRA.Services.Interfaces;

namespace WRA.Services
{
    public class TrioRateService : ITrioRateService
    {
        public List<CalculationResult> Calculate(List<Tip> tips)
        {
            List<CalculationResult> calculationResults = new List<CalculationResult>();

            foreach (Tip tip in tips)
            {
                calculationResults.Add(new CalculationResult
                {
                    HorseNumber = tip.HorseNumber,
                    RefundAmount = tip.TrioOdds * tip.Stake,
                    Trustworthiness = (1.0f / tip.WinRanking) * tip.ShowRate * 0.6f + (1 / tip.NumberOfRaces) * (tip.NumberOfFirstPlaces + tip.NumberOfSecondPlaces + tip.NumberOfThirdPlaces) * 0.4f
                }
                );
            }

            return calculationResults;
        }
    }
}