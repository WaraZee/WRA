using WRA.Models;
using WRA.Services.Interfaces;

namespace WRA.Services
{
    public class TrierceRateService : ITrieceRateService
    {
        public List<CalculationResult> Calculate(List<Tip> tips)
        {
            List<CalculationResult> calculationResults = new List<CalculationResult>();

            foreach (Tip tip in tips)
            {
                calculationResults.Add(new CalculationResult
                {
                    HorseNumber = tip.HorseNumber,
                    RefundAmount = tip.TrierceOdds * tip.Stake,
                    Trustworthiness = (1.0f / tip.WinRanking) * tip.ShowRate * 0.6f + (1 / tip.NumberOfRaces) * (tip.NumberOfFirstPlaces * 1.0f + tip.NumberOfSecondPlaces * 0.9f + tip.NumberOfThirdPlaces * 0.8f) * 0.4f
                }
                );
            }

            return calculationResults;
        }
    }
}