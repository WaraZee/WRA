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
                        },
                        new Rate
                        {
                            WinOdds = 3.0f,
                            WinRate = 28.0f / 100,
                            OneTwoRate = 47.0f / 100,
                            ShowRate = 62.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 3.1f,
                            WinRate = 27.0f / 100,
                            OneTwoRate = 46.0f / 100,
                            ShowRate = 61.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 3.2f,
                            WinRate = 26.0f / 100,
                            OneTwoRate = 45.0f / 100,
                            ShowRate = 60.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 3.3f,
                            WinRate = 25.0f / 100,
                            OneTwoRate = 44.0f / 100,
                            ShowRate = 59.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 3.4f,
                            WinRate = 24.0f / 100,
                            OneTwoRate = 43.0f / 100,
                            ShowRate = 58.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 3.5f,
                            WinRate = 23.0f / 100,
                            OneTwoRate = 42.0f / 100,
                            ShowRate = 57.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 3.6f,
                            WinRate = 22.0f / 100,
                            OneTwoRate = 41.0f / 100,
                            ShowRate = 56.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 3.7f,
                            WinRate = 22.0f / 100,
                            OneTwoRate = 40.0f / 100,
                            ShowRate = 55.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 3.8f,
                            WinRate = 21.0f / 100,
                            OneTwoRate = 39.0f / 100,
                            ShowRate = 54.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 3.9f,
                            WinRate = 21.0f / 100,
                            OneTwoRate = 38.0f / 100,
                            ShowRate = 52.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 4.0f,
                            WinRate = 21.0f / 100,
                            OneTwoRate = 37.0f / 100,
                            ShowRate = 51.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 4.1f,
                            WinRate = 20.0f / 100,
                            OneTwoRate = 36.0f / 100,
                            ShowRate = 51.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 4.2f,
                            WinRate = 19.0f / 100,
                            OneTwoRate = 35.0f / 100,
                            ShowRate = 50.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 4.3f,
                            WinRate = 18.0f / 100,
                            OneTwoRate = 35.0f / 100,
                            ShowRate = 49.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 4.4f,
                            WinRate = 18.0f / 100,
                            OneTwoRate = 34.0f / 100,
                            ShowRate = 49.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 4.5f,
                            WinRate = 17.0f / 100,
                            OneTwoRate = 34.0f / 100,
                            ShowRate = 49.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 4.6f,
                            WinRate = 17.0f / 100,
                            OneTwoRate = 34.0f / 100,
                            ShowRate = 49.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 4.7f,
                            WinRate = 16.0f / 100,
                            OneTwoRate = 33.0f / 100,
                            ShowRate = 49.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 4.8f,
                            WinRate = 16.0f / 100,
                            OneTwoRate = 33.0f / 100,
                            ShowRate = 48.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 4.9f,
                            WinRate = 16.0f / 100,
                            OneTwoRate = 33.0f / 100,
                            ShowRate = 48.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 5.0f,
                            WinRate = 16.0f / 100,
                            OneTwoRate = 32.0f / 100,
                            ShowRate = 47.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 5.1f,
                            WinRate = 15.0f / 100,
                            OneTwoRate = 32.0f / 100,
                            ShowRate = 45.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 5.2f,
                            WinRate = 15.0f / 100,
                            OneTwoRate = 32.0f / 100,
                            ShowRate = 44.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 5.3f,
                            WinRate = 15.0f / 100,
                            OneTwoRate = 31.0f / 100,
                            ShowRate = 43.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 5.4f,
                            WinRate = 14.0f / 100,
                            OneTwoRate = 31.0f / 100,
                            ShowRate = 43.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 5.5f,
                            WinRate = 14.0f / 100,
                            OneTwoRate = 31.0f / 100,
                            ShowRate = 43.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 5.6f,
                            WinRate = 13.0f / 100,
                            OneTwoRate = 30.0f / 100,
                            ShowRate = 42.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 5.7f,
                            WinRate = 13.0f / 100,
                            OneTwoRate = 29.0f / 100,
                            ShowRate = 41.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 5.8f,
                            WinRate = 13.0f / 100,
                            OneTwoRate = 28.0f / 100,
                            ShowRate = 41.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 5.9f,
                            WinRate = 13.0f / 100,
                            OneTwoRate = 28.0f / 100,
                            ShowRate = 41.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 6.0f,
                            WinRate = 13.0f / 100,
                            OneTwoRate = 28.0f / 100,
                            ShowRate = 41.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 6.1f,
                            WinRate = 13.0f / 100,
                            OneTwoRate = 28.0f / 100,
                            ShowRate = 41.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 6.2f,
                            WinRate = 12.0f / 100,
                            OneTwoRate = 28.0f / 100,
                            ShowRate = 41.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 6.3f,
                            WinRate = 12.0f / 100,
                            OneTwoRate = 28.0f / 100,
                            ShowRate = 40.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 6.4f,
                            WinRate = 12.0f / 100,
                            OneTwoRate = 27.0f / 100,
                            ShowRate = 40.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 6.5f,
                            WinRate = 12.0f / 100,
                            OneTwoRate = 25.0f / 100,
                            ShowRate = 39.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 6.6f,
                            WinRate = 12.0f / 100,
                            OneTwoRate = 25.0f / 100,
                            ShowRate = 38.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 6.7f,
                            WinRate = 11.0f / 100,
                            OneTwoRate = 24.0f / 100,
                            ShowRate = 37.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 6.8f,
                            WinRate = 11.0f / 100,
                            OneTwoRate = 24.0f / 100,
                            ShowRate = 37.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 6.9f,
                            WinRate = 11.0f / 100,
                            OneTwoRate = 24.0f / 100,
                            ShowRate = 37.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 7.0f,
                            WinRate = 11.0f / 100,
                            OneTwoRate = 24.0f / 100,
                            ShowRate = 37.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 7.1f,
                            WinRate = 11.0f / 100,
                            OneTwoRate = 24.0f / 100,
                            ShowRate = 37.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 7.2f,
                            WinRate = 11.0f / 100,
                            OneTwoRate = 24.0f / 100,
                            ShowRate = 37.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 7.3f,
                            WinRate = 11.0f / 100,
                            OneTwoRate = 24.0f / 100,
                            ShowRate = 37.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 7.4f,
                            WinRate = 11.0f / 100,
                            OneTwoRate = 24.0f / 100,
                            ShowRate = 36.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 7.5f,
                            WinRate = 11.0f / 100,
                            OneTwoRate = 23.0f / 100,
                            ShowRate = 35.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 7.6f,
                            WinRate = 11.0f / 100,
                            OneTwoRate = 22.0f / 100,
                            ShowRate = 34.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 7.7f,
                            WinRate = 10.0f / 100,
                            OneTwoRate = 22.0f / 100,
                            ShowRate = 33.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 7.8f,
                            WinRate = 10.0f / 100,
                            OneTwoRate = 21.0f / 100,
                            ShowRate = 33.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 7.9f,
                            WinRate = 10.0f / 100,
                            OneTwoRate = 21.0f / 100,
                            ShowRate = 33.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 8.0f,
                            WinRate = 10.0f / 100,
                            OneTwoRate = 21.0f / 100,
                            ShowRate = 33.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 8.1f,
                            WinRate = 10.0f / 100,
                            OneTwoRate = 21.0f / 100,
                            ShowRate = 33.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 8.2f,
                            WinRate = 10.0f / 100,
                            OneTwoRate = 21.0f / 100,
                            ShowRate = 33.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 8.3f,
                            WinRate = 10.0f / 100,
                            OneTwoRate = 20.0f / 100,
                            ShowRate = 32.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 8.4f,
                            WinRate = 10.0f / 100,
                            OneTwoRate = 20.0f / 100,
                            ShowRate = 32.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 8.5f,
                            WinRate = 10.0f / 100,
                            OneTwoRate = 20.0f / 100,
                            ShowRate = 32.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 8.6f,
                            WinRate = 10.0f / 100,
                            OneTwoRate = 20.0f / 100,
                            ShowRate = 32.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 8.7f,
                            WinRate = 9.0f / 100,
                            OneTwoRate = 20.0f / 100,
                            ShowRate = 31.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 8.8f,
                            WinRate = 9.0f / 100,
                            OneTwoRate = 20.0f / 100,
                            ShowRate = 31.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 8.9f,
                            WinRate = 9.0f / 100,
                            OneTwoRate = 20.0f / 100,
                            ShowRate = 31.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 9.0f,
                            WinRate = 9.0f / 100,
                            OneTwoRate = 20.0f / 100,
                            ShowRate = 31.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 9.1f,
                            WinRate = 9.0f / 100,
                            OneTwoRate = 20.0f / 100,
                            ShowRate = 31.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 9.2f,
                            WinRate = 9.0f / 100,
                            OneTwoRate = 20.0f / 100,
                            ShowRate = 30.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 9.3f,
                            WinRate = 9.0f / 100,
                            OneTwoRate = 20.0f / 100,
                            ShowRate = 30.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 9.4f,
                            WinRate = 9.0f / 100,
                            OneTwoRate = 20.0f / 100,
                            ShowRate = 30.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 9.5f,
                            WinRate = 9.0f / 100,
                            OneTwoRate = 20.0f / 100,
                            ShowRate = 30.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 9.6f,
                            WinRate = 9.0f / 100,
                            OneTwoRate = 20.0f / 100,
                            ShowRate = 30.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 9.7f,
                            WinRate = 9.0f / 100,
                            OneTwoRate = 20.0f / 100,
                            ShowRate = 30.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 9.8f,
                            WinRate = 9.0f / 100,
                            OneTwoRate = 19.0f / 100,
                            ShowRate = 30.0f / 100
                        },
                        new Rate
                        {
                            WinOdds = 9.9f,
                            WinRate = 9.0f / 100,
                            OneTwoRate = 19.0f / 100,
                            ShowRate = 29.0f / 100
                        }
                    };
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 10.0f + (i / 10f),
                            WinRate = 7.0f / 100,
                            OneTwoRate = 18.0f / 100,
                            ShowRate = 29.0f / 100
                        });
                    }
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 11.0f + (i / 10f),
                            WinRate = 7.0f / 100,
                            OneTwoRate = 17.0f / 100,
                            ShowRate = 28.0f / 100
                        });
                    }
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 12.0f + (i / 10f),
                            WinRate = 7.0f / 100,
                            OneTwoRate = 16.0f / 100,
                            ShowRate = 25.0f / 100
                        });
                    }
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 13.0f + (i / 10f),
                            WinRate = 6.0f / 100,
                            OneTwoRate = 15.0f / 100,
                            ShowRate = 24.0f / 100
                        });
                    }
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 14.0f + (i / 10f),
                            WinRate = 6.0f / 100,
                            OneTwoRate = 14.0f / 100,
                            ShowRate = 23.0f / 100
                        });
                    }
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 15.0f + (i / 10f),
                            WinRate = 5.0f / 100,
                            OneTwoRate = 13.0f / 100,
                            ShowRate = 22.0f / 100
                        });
                    }
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 16.0f + (i / 10f),
                            WinRate = 5.0f / 100,
                            OneTwoRate = 12.0f / 100,
                            ShowRate = 21.0f / 100
                        });
                    }
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 17.0f + (i / 10f),
                            WinRate = 5.0f / 100,
                            OneTwoRate = 11.0f / 100,
                            ShowRate = 20.0f / 100
                        });
                    }
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 18.0f + (i / 10f),
                            WinRate = 5.0f / 100,
                            OneTwoRate = 11.0f / 100,
                            ShowRate = 19.0f / 100
                        });
                    }
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 19.0f + (i / 10f),
                            WinRate = 5.0f / 100,
                            OneTwoRate = 11.0f / 100,
                            ShowRate = 19.0f / 100
                        });
                    }
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 20.0f + (i / 10f),
                            WinRate = 4.0f / 100,
                            OneTwoRate = 10.0f / 100,
                            ShowRate = 18.0f / 100
                        });
                    }
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 21.0f + (i / 10f),
                            WinRate = 4.0f / 100,
                            OneTwoRate = 9.0f / 100,
                            ShowRate = 17.0f / 100
                        });
                    }
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 22.0f + (i / 10f),
                            WinRate = 4.0f / 100,
                            OneTwoRate = 9.0f / 100,
                            ShowRate = 17.0f / 100
                        });
                    }
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 23.0f + (i / 10f),
                            WinRate = 3.0f / 100,
                            OneTwoRate = 9.0f / 100,
                            ShowRate = 16.0f / 100
                        });
                    }
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 24.0f + (i / 10f),
                            WinRate = 3.0f / 100,
                            OneTwoRate = 8.0f / 100,
                            ShowRate = 15.0f / 100
                        });
                    }
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 25.0f + (i / 10f),
                            WinRate = 3.0f / 100,
                            OneTwoRate = 8.0f / 100,
                            ShowRate = 14.0f / 100
                        });
                    }
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 26.0f + (i / 10f),
                            WinRate = 3.0f / 100,
                            OneTwoRate = 8.0f / 100,
                            ShowRate = 14.0f / 100
                        });
                    }
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 27.0f + (i / 10f),
                            WinRate = 3.0f / 100,
                            OneTwoRate = 7.0f / 100,
                            ShowRate = 13.0f / 100
                        });
                    }
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 28.0f + (i / 10f),
                            WinRate = 3.0f / 100,
                            OneTwoRate = 7.0f / 100,
                            ShowRate = 13.0f / 100
                        });
                    }
                    for (float i = 0f; i < 10f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 29.0f + (i / 10f),
                            WinRate = 3.0f / 100,
                            OneTwoRate = 7.0f / 100,
                            ShowRate = 12.0f / 100
                        });
                    }
                    for (float i = 0f; i < 50f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 30.0f + (i / 10f),
                            WinRate = 3.0f / 100,
                            OneTwoRate = 6.0f / 100,
                            ShowRate = 11.0f / 100
                        });
                    }
                    for (float i = 0f; i < 50f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 35.0f + (i / 10f),
                            WinRate = 2.0f / 100,
                            OneTwoRate = 5.0f / 100,
                            ShowRate = 10.0f / 100
                        });
                    }
                    for (float i = 0f; i < 50f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 40.0f + (i / 10f),
                            WinRate = 2.0f / 100,
                            OneTwoRate = 5.0f / 100,
                            ShowRate = 10.0f / 100
                        });
                    }
                    for (float i = 0f; i < 50f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 45.0f + (i / 10f),
                            WinRate = 1.0f / 100,
                            OneTwoRate = 4.0f / 100,
                            ShowRate = 9.0f / 100
                        });
                    }
                    for (float i = 0f; i < 100f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 50.0f + (i / 10f),
                            WinRate = 1.0f / 100,
                            OneTwoRate = 4.0f / 100,
                            ShowRate = 8.0f / 100
                        });
                    }
                    for (float i = 0f; i < 100f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 60.0f + (i / 10f),
                            WinRate = 1.0f / 100,
                            OneTwoRate = 3.0f / 100,
                            ShowRate = 7.0f / 100
                        });
                    }
                    for (float i = 0f; i < 100f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 70.0f + (i / 10f),
                            WinRate = 1.0f / 100,
                            OneTwoRate = 3.0f / 100,
                            ShowRate = 6.0f / 100
                        });
                    }
                    for (float i = 0f; i < 100f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 80.0f + (i / 10f),
                            WinRate = 1.0f / 100,
                            OneTwoRate = 2.0f / 100,
                            ShowRate = 5.0f / 100
                        });
                    }
                    for (float i = 0f; i < 100f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 90.0f + (i / 10f),
                            WinRate = 1.0f / 100,
                            OneTwoRate = 2.0f / 100,
                            ShowRate = 5.0f / 100
                        });
                    }
                    for (float i = 0f; i < 1000f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 100.0f + (i / 10f),
                            WinRate = 0f / 100,
                            OneTwoRate = 1.0f / 100,
                            ShowRate = 3.0f / 100
                        });
                    }
                    for (float i = 0f; i < 2000f; i++)
                    {
                        rateByWinOddsRates.Add(new Rate
                        {
                            WinOdds = 200.0f + (i / 10f),
                            WinRate = 0f / 100,
                            OneTwoRate = 1.0f / 100,
                            ShowRate = 1.0f / 100
                        });
                    }
                    // 400.0 - 999.9 はすべて0%
                    return rateByWinOddsRates;
                default:
                    List<Rate> dummyRates = new List<Rate>();
                    return dummyRates;
            }
        }
    }
}