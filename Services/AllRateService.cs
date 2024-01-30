using WRA.Models;
using WRA.Services.Interfaces;

namespace WRA.Services
{
    public class AllRateService : IAllRateService
    {
        public List<Rate> GetRate(string name)
        {
            switch (name)
            {
                case "turf":
                    List<Rate> turfWinShowRates = new List<Rate>
                    {
                        new Rate
                        {
                            WinRate = 33.1f / 100,
                            OneTwoRate = 51.5f / 100,
                            ShowRate = 64.2f / 100
                        },
                        new Rate
                        {
                            WinRate = 19.1f / 100,
                            OneTwoRate = 38.2f / 100,
                            ShowRate = 52.4f / 100
                        },
                        new Rate
                        {
                            WinRate = 13.8f / 100,
                            OneTwoRate = 28.9f / 100,
                            ShowRate = 42.9f / 100
                        },
                        new Rate
                        {
                            WinRate = 9.2f / 100,
                            OneTwoRate = 21.2f / 100,
                            ShowRate = 33.2f / 100
                        },
                        new Rate
                        {
                            WinRate = 7.1f / 100,
                            OneTwoRate = 16.0f / 100,
                            ShowRate = 26.9f / 100
                        },
                        new Rate
                        {
                            WinRate = 5.0f / 100,
                            OneTwoRate = 12.4f / 100,
                            ShowRate = 21.3f / 100
                        },
                        new Rate
                        {
                            WinRate = 3.9f / 100,
                            OneTwoRate = 9.2f / 100,
                            ShowRate = 16.3f / 100
                        },
                        new Rate
                        {
                            WinRate = 2.8f / 100,
                            OneTwoRate = 6.9f / 100,
                            ShowRate = 12.5f / 100
                        },
                        new Rate
                        {
                            WinRate = 2.0f / 100,
                            OneTwoRate = 5.3f / 100,
                            ShowRate = 10.3f / 100
                        },
                        new Rate
                        {
                            WinRate = 1.8f / 100,
                            OneTwoRate = 4.6f / 100,
                            ShowRate = 7.9f / 100
                        },
                        new Rate
                        {
                            WinRate = 1.1f / 100,
                            OneTwoRate = 3.2f / 100,
                            ShowRate = 6.4f / 100
                        },
                        new Rate
                        {
                            WinRate = 1.0f / 100,
                            OneTwoRate = 2.7f / 100,
                            ShowRate = 5.3f / 100
                        },
                        new Rate
                        {
                            WinRate = 0.8f / 100,
                            OneTwoRate = 2.0f / 100,
                            ShowRate = 4.0f / 100
                        },
                        new Rate
                        {
                            WinRate = 0.6f / 100,
                            OneTwoRate = 1.4f / 100,
                            ShowRate = 2.9f / 100
                        },
                        new Rate
                        {
                            WinRate = 0.3f / 100,
                            OneTwoRate = 1.0f / 100,
                            ShowRate = 2.1f / 100
                        },
                        new Rate
                        {
                            WinRate = 0.3f / 100,
                            OneTwoRate = 0.6f / 100,
                            ShowRate = 1.5f / 100
                        },
                        new Rate
                        {
                            WinRate = 0.1f / 100,
                            OneTwoRate = 0.5f / 100,
                            ShowRate = 1.2f / 100
                        },
                        new Rate
                        {
                            WinRate = 0.1f / 100,
                            OneTwoRate = 0.3f / 100,
                            ShowRate = 0.8f / 100
                        }
                    };
                    return turfWinShowRates;
                case "dirt":
                    List<Rate> dirtWinShowRates = new List<Rate>
                    {
                        new Rate
                        {
                            WinRate = 32.1f / 100,
                            OneTwoRate = 50.8f / 100,
                            ShowRate = 63.7f / 100
                        },
                        new Rate
                        {
                            WinRate = 19.3f / 100,
                            OneTwoRate = 37.3f / 100,
                            ShowRate = 51.0f / 100
                        },
                        new Rate
                        {
                            WinRate = 12.9f / 100,
                            OneTwoRate = 27.4f / 100,
                            ShowRate = 40.9f / 100
                        },
                        new Rate
                        {
                            WinRate = 9.3f / 100,
                            OneTwoRate = 20.3f / 100,
                            ShowRate = 31.8f / 100
                        },
                        new Rate
                        {
                            WinRate = 7.1f / 100,
                            OneTwoRate = 16.0f / 100,
                            ShowRate = 26.2f / 100
                        },
                        new Rate
                        {
                            WinRate = 4.0f / 100,
                            OneTwoRate = 13.2f / 100,
                            ShowRate = 22.1f / 100
                        },
                        new Rate
                        {
                            WinRate = 4.0f / 100,
                            OneTwoRate = 10.0f / 100,
                            ShowRate = 16.7f / 100
                        },
                        new Rate
                        {
                            WinRate = 2.6f / 100,
                            OneTwoRate = 7.3f / 100,
                            ShowRate = 13.3f / 100
                        },
                        new Rate
                        {
                            WinRate = 2.2f / 100,
                            OneTwoRate = 5.5f / 100,
                            ShowRate = 10.2f / 100
                        },
                        new Rate
                        {
                            WinRate = 1.7f / 100,
                            OneTwoRate = 4.4f / 100,
                            ShowRate = 8.1f / 100
                        },
                        new Rate
                        {
                            WinRate = 1.3f / 100,
                            OneTwoRate = 3.2f / 100,
                            ShowRate = 6.2f / 100
                        },
                        new Rate
                        {
                            WinRate = 0.9f / 100,
                            OneTwoRate = 2.5f / 100,
                            ShowRate = 5.0f / 100
                        },
                        new Rate
                        {
                            WinRate = 0.7f / 100,
                            OneTwoRate = 1.8f / 100,
                            ShowRate = 3.5f / 100
                        },
                        new Rate
                        {
                            WinRate = 0.4f / 100,
                            OneTwoRate = 1.3f / 100,
                            ShowRate = 2.7f / 100
                        },
                        new Rate
                        {
                            WinRate = 0.3f / 100,
                            OneTwoRate = 0.9f / 100,
                            ShowRate = 2.0f / 100
                        },
                        new Rate
                        {
                            WinRate = 0.3f / 100,
                            OneTwoRate = 0.7f / 100,
                            ShowRate = 1.2f / 100
                        },
                        new Rate
                        {
                            WinRate = 0f,
                            OneTwoRate = 0f,
                            ShowRate = 0f
                        },
                        new Rate
                        {
                            WinRate = 0f,
                            OneTwoRate = 0f,
                            ShowRate = 0f
                        }
                    };
                    return dirtWinShowRates;
                case "rateByWinOdds":
                    List<Rate> rateByWinOddsRates = new List<Rate>
                    {
                        new Rate
                        {
                            WinOdds = 1.1f,
                            WinRate = 72.0f / 100,
                            OneTwoRate = 87.0f / 100,
                            ShowRate = 94.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 1.2f,
                            WinRate = 68.0f / 100,
                            OneTwoRate = 84.0f / 100,
                            ShowRate = 92.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 1.3f,
                            WinRate = 64.0f / 100,
                            OneTwoRate = 81.0f / 100,
                            ShowRate = 90.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 1.4f,
                            WinRate = 60.0f / 100,
                            OneTwoRate = 78.0f / 100,
                            ShowRate = 87.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 1.5f,
                            WinRate = 56.0f / 100,
                            OneTwoRate = 75.0f / 100,
                            ShowRate = 84.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 1.6f,
                            WinRate = 52.0f / 100,
                            OneTwoRate = 72.0f / 100,
                            ShowRate = 81.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 1.7f,
                            WinRate = 48.0f / 100,
                            OneTwoRate = 69.0f / 100,
                            ShowRate = 79.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 1.8f,
                            WinRate = 44.0f / 100,
                            OneTwoRate = 66.0f / 100,
                            ShowRate = 77.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 1.9f,
                            WinRate = 41.0f / 100,
                            OneTwoRate = 63.0f / 100,
                            ShowRate = 75.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 2.0f,
                            WinRate = 39.0f / 100,
                            OneTwoRate = 61.0f / 100,
                            ShowRate = 73.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 2.1f,
                            WinRate = 37.0f / 100,
                            OneTwoRate = 59.0f / 100,
                            ShowRate = 72.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 2.2f,
                            WinRate = 36.0f / 100,
                            OneTwoRate = 57.0f / 100,
                            ShowRate = 70.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 2.3f,
                            WinRate = 35.0f / 100,
                            OneTwoRate = 55.0f / 100,
                            ShowRate = 69.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 2.4f,
                            WinRate = 34.0f / 100,
                            OneTwoRate = 53.0f / 100,
                            ShowRate = 67.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 2.5f,
                            WinRate = 33.0f / 100,
                            OneTwoRate = 52.0f / 100,
                            ShowRate = 66.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 2.6f,
                            WinRate = 32.0f / 100,
                            OneTwoRate = 51.0f / 100,
                            ShowRate = 65.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 2.7f,
                            WinRate = 31.0f / 100,
                            OneTwoRate = 50.0f / 100,
                            ShowRate = 64.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 2.8f,
                            WinRate = 30.0f / 100,
                            OneTwoRate = 49.0f / 100,
                            ShowRate = 63.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 2.9f,
                            WinRate = 29.0f / 100,
                            OneTwoRate = 48.0f / 100,
                            ShowRate = 62.0f / 100
                        }
                    };
                    return rateByWinOddsRates;
                default:
                    List<Rate> dummyRates = new List<Rate>();
                    return dummyRates;
            }
        }
    }
}