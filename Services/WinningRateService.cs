using WRA.Models;
using WRA.Services.Interfaces;

namespace WRA.Services
{
    public class WinRateService : IWinningRateService
    {
        public async Task<List<WinningRate>> CreateAsync(string name)
        {
            return await Task.Run(() =>
            {
                switch (name)
                {
                    case "turf":
                        List<WinningRate> turfWinShowRates = new List<WinningRate>
                    {
                        new WinningRate
                        {
                            WinRate = 33.1f / 100f,
                            OneTwoRate = 51.5f / 100f,
                            ShowRate = 64.2f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 19.1f / 100f,
                            OneTwoRate = 38.2f / 100f,
                            ShowRate = 52.4f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 13.8f / 100f,
                            OneTwoRate = 28.9f / 100f,
                            ShowRate = 42.9f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 9.2f / 100f,
                            OneTwoRate = 21.2f / 100f,
                            ShowRate = 33.2f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 7.1f / 100f,
                            OneTwoRate = 16.0f / 100f,
                            ShowRate = 26.9f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 5.0f / 100f,
                            OneTwoRate = 12.4f / 100f,
                            ShowRate = 21.3f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 3.9f / 100f,
                            OneTwoRate = 9.2f / 100f,
                            ShowRate = 16.3f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 2.8f / 100f,
                            OneTwoRate = 6.9f / 100f,
                            ShowRate = 12.5f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 2.0f / 100f,
                            OneTwoRate = 5.3f / 100f,
                            ShowRate = 10.3f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 1.8f / 100f,
                            OneTwoRate = 4.6f / 100f,
                            ShowRate = 7.9f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 1.1f / 100f,
                            OneTwoRate = 3.2f / 100f,
                            ShowRate = 6.4f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 1.0f / 100f,
                            OneTwoRate = 2.7f / 100f,
                            ShowRate = 5.3f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 0.8f / 100f,
                            OneTwoRate = 2.0f / 100f,
                            ShowRate = 4.0f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 0.6f / 100f,
                            OneTwoRate = 1.4f / 100f,
                            ShowRate = 2.9f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 0.3f / 100f,
                            OneTwoRate = 1.0f / 100f,
                            ShowRate = 2.1f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 0.3f / 100f,
                            OneTwoRate = 0.6f / 100f,
                            ShowRate = 1.5f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 0.1f / 100f,
                            OneTwoRate = 0.5f / 100f,
                            ShowRate = 1.2f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 0.1f / 100f,
                            OneTwoRate = 0.3f / 100f,
                            ShowRate = 0.8f / 100f
                        }
                    };
                        return turfWinShowRates;
                    case "dirt":
                        List<WinningRate> dirtWinShowRates = new List<WinningRate>
                    {
                        new WinningRate
                        {
                            WinRate = 32.1f / 100f,
                            OneTwoRate = 50.8f / 100f,
                            ShowRate = 63.7f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 19.3f / 100f,
                            OneTwoRate = 37.3f / 100f,
                            ShowRate = 51.0f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 12.9f / 100f,
                            OneTwoRate = 27.4f / 100f,
                            ShowRate = 40.9f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 9.3f / 100f,
                            OneTwoRate = 20.3f / 100f,
                            ShowRate = 31.8f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 7.1f / 100f,
                            OneTwoRate = 16.0f / 100f,
                            ShowRate = 26.2f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 4.0f / 100f,
                            OneTwoRate = 13.2f / 100f,
                            ShowRate = 22.1f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 4.0f / 100f,
                            OneTwoRate = 10.0f / 100f,
                            ShowRate = 16.7f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 2.6f / 100f,
                            OneTwoRate = 7.3f / 100f,
                            ShowRate = 13.3f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 2.2f / 100f,
                            OneTwoRate = 5.5f / 100f,
                            ShowRate = 10.2f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 1.7f / 100f,
                            OneTwoRate = 4.4f / 100f,
                            ShowRate = 8.1f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 1.3f / 100f,
                            OneTwoRate = 3.2f / 100f,
                            ShowRate = 6.2f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 0.9f / 100f,
                            OneTwoRate = 2.5f / 100f,
                            ShowRate = 5.0f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 0.7f / 100f,
                            OneTwoRate = 1.8f / 100f,
                            ShowRate = 3.5f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 0.4f / 100f,
                            OneTwoRate = 1.3f / 100f,
                            ShowRate = 2.7f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 0.3f / 100f,
                            OneTwoRate = 0.9f / 100f,
                            ShowRate = 2.0f / 100f
                        },
                        new WinningRate
                        {
                            WinRate = 0.3f / 100f,
                            OneTwoRate = 0.7f / 100f,
                            ShowRate = 1.2f / 100f
                        }
                    };
                        return dirtWinShowRates;
                    default:
                        List<WinningRate> winShowRates = new List<WinningRate>();
                        return winShowRates;
                }
            });
        }

        public List<CalculationResult> Calculate(List<Tip> tips)
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

                var a = tips.Min(tip => tip.WinOdds);

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
    }
}