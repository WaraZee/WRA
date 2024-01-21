using WRA.Models;

namespace WRA.Pages
{
    public partial class Home
    {
        // 入力データ
        private List<Tip> _tips = new List<Tip>();
        // 単勝
        private List<CalculationResult>? _winCalculationResults;
        // 複勝
        private List<CalculationResult>? _showCalculationResults;
        // 3連単
        private List<CalculationResult>? _trierceCalculationResults;
        // 3連複
        private List<CalculationResult>? _trioCalculationResults;

        private List<WinShowRate> _turfWinShowRates = new List<WinShowRate>
        {
            new WinShowRate
            {
                WinRate = 33.1f / 100,
                ShowRate = 64.2f / 100
            },
            new WinShowRate
            {
                WinRate = 19.1f / 100,
                ShowRate = 52.4f / 100
            },
            new WinShowRate
            {
                WinRate = 13.8f / 100,
                ShowRate = 42.9f / 100
            },
            new WinShowRate
            {
                WinRate = 9.2f / 100,
                ShowRate = 33.2f / 100
            },
            new WinShowRate
            {
                WinRate = 7.1f / 100,
                ShowRate = 26.9f / 100
            },
            new WinShowRate
            {
                WinRate = 5.0f / 100,
                ShowRate = 21.3f / 100
            },
            new WinShowRate
            {
                WinRate = 3.9f / 100,
                ShowRate = 16.3f / 100
            },
            new WinShowRate
            {
                WinRate = 2.8f / 100,
                ShowRate = 12.5f / 100
            },
            new WinShowRate
            {
                WinRate = 2.0f / 100,
                ShowRate = 10.3f / 100
            },
            new WinShowRate
            {
                WinRate = 1.8f / 100,
                ShowRate = 7.9f / 100
            },
            new WinShowRate
            {
                WinRate = 1.1f / 100,
                ShowRate = 6.4f / 100
            },
            new WinShowRate
            {
                WinRate = 1.0f / 100,
                ShowRate = 5.3f / 100
            },
            new WinShowRate
            {
                WinRate = 0.8f / 100,
                ShowRate = 4.0f / 100
            },
            new WinShowRate
            {
                WinRate = 0.6f / 100,
                ShowRate = 2.9f / 100
            },
            new WinShowRate
            {
                WinRate = 0.3f / 100,
                ShowRate = 2.1f / 100
            },
            new WinShowRate
            {
                WinRate = 0.3f / 100,
                ShowRate = 1.5f / 100
            },
            new WinShowRate
            {
                WinRate = 0.1f / 100,
                ShowRate = 1.2f / 100
            },
            new WinShowRate
            {
                WinRate = 0.1f / 100,
                ShowRate = 0.8f / 100
            }
        };

        private int _tipIndex;

        protected override async Task OnInitializedAsync()
        {
            await InitializeTipAsync();
        }

        private async Task InitializeTipAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 18; i++)
                {
                    Tip tip = new Tip
                    {
                        HorseNumber = i
                    };
                    _tips.Add(tip);
                }
            });
        }

        private async Task NumberInputOnChangeAsync(InputValue inputValue)
        {
            await Task.Run(() =>
            {
                switch (inputValue.ColumnId)
                {
                    case 1:
                        _tips[inputValue.HorseNumber].WinOdds = inputValue.Value;
                        break;
                    case 2:
                        _tips[inputValue.HorseNumber].ShowOdds = inputValue.Value;
                        break;
                    case 3:
                        _tips[inputValue.HorseNumber].TrierceOdds = inputValue.Value;
                        break;
                    case 4:
                        _tips[inputValue.HorseNumber].TrioOdds = inputValue.Value;
                        break;
                    case 5:
                        _tips[inputValue.HorseNumber].NumberOfRaces = inputValue.Value;
                        break;
                    case 6:
                        _tips[inputValue.HorseNumber].NumberOfFirstPlaces = inputValue.Value;
                        break;
                    case 7:
                        _tips[inputValue.HorseNumber].NumberOfSecondPlaces = inputValue.Value;
                        break;
                    case 8:
                        _tips[inputValue.HorseNumber].NumberOfThirdPlaces = inputValue.Value;
                        break;
                    case 9:
                        _tips[inputValue.HorseNumber].Stake = inputValue.Value;
                        break;
                    default:
                        break;
                }
            });
        }

        private async Task SubmitButtonOnClickAsync()
        {
            await Task.Run(() =>
            {
                _tipIndex = 0;
                _tips = _tips.OrderBy(tip => tip.WinOdds).ToList();

                foreach (Tip tip in _tips)
                {
                    tip.WinRate = _turfWinShowRates[_tipIndex].WinRate;
                    _tipIndex++;
                }

                _tips = _tips.OrderBy(tip => tip.HorseNumber).ToList();

                // 単勝
                _winCalculationResults = new List<CalculationResult>();
                foreach (Tip tip in _tips)
                {
                    _winCalculationResults.Add(new CalculationResult
                    {
                        HorseNumber = tip.HorseNumber,
                        RefundAmount = tip.WinOdds * tip.Stake,
                        ExpectedValue = (tip.NumberOfFirstPlaces * 1 + tip.NumberOfSecondPlaces * 0.8f + tip.NumberOfThirdPlaces * 0.6f) / tip.NumberOfRaces * tip.WinOdds * tip.WinRate
                    }
                    );
                }

                _tipIndex = 0;
                _tips = _tips.OrderBy(tip => tip.ShowOdds).ToList();

                foreach (Tip tip in _tips)
                {
                    tip.ShowRate = _turfWinShowRates[_tipIndex].ShowRate;
                    _tipIndex++;
                }

                _tips = _tips.OrderBy(tip => tip.HorseNumber).ToList();

                // 複勝
                _showCalculationResults = new List<CalculationResult>();
                foreach (Tip tip in _tips)
                {
                    _showCalculationResults.Add(new CalculationResult
                    {
                        HorseNumber = tip.HorseNumber,
                        RefundAmount = tip.ShowOdds * tip.Stake,
                        ExpectedValue = (tip.NumberOfFirstPlaces * 1 + tip.NumberOfSecondPlaces * 1 + tip.NumberOfThirdPlaces * 1) / tip.NumberOfRaces * tip.ShowOdds * tip.ShowRate
                    }
                    );
                }

                _tipIndex = 0;
                _tips = _tips.OrderBy(tip => tip.TrierceOdds).ToList();

                foreach (Tip tip in _tips)
                {
                    tip.ShowRate = _turfWinShowRates[_tipIndex].ShowRate;
                    _tipIndex++;
                }

                _tips = _tips.OrderBy(tip => tip.HorseNumber).ToList();

                // 3連単
                _trierceCalculationResults = new List<CalculationResult>();
                foreach (Tip tip in _tips)
                {
                    _trierceCalculationResults.Add(new CalculationResult
                    {
                        HorseNumber = tip.HorseNumber,
                        RefundAmount = tip.TrierceOdds * tip.Stake,
                        ExpectedValue = (tip.NumberOfFirstPlaces * 1 + tip.NumberOfSecondPlaces * 0.9f + tip.NumberOfThirdPlaces * 0.8f) / tip.NumberOfRaces * tip.TrierceOdds * tip.ShowRate
                    }
                    );
                }

                _tipIndex = 0;
                _tips = _tips.OrderBy(tip => tip.TrierceOdds).ToList();

                foreach (Tip tip in _tips)
                {
                    tip.ShowRate = _turfWinShowRates[_tipIndex].ShowRate;
                    _tipIndex++;
                }

                _tips = _tips.OrderBy(tip => tip.HorseNumber).ToList();

                // 3連複
                _trioCalculationResults = new List<CalculationResult>();
                foreach (Tip tip in _tips)
                {
                    _trioCalculationResults.Add(new CalculationResult
                    {
                        HorseNumber = tip.HorseNumber,
                        RefundAmount = tip.TrioOdds * tip.Stake,
                        ExpectedValue = (tip.NumberOfFirstPlaces * 1 + tip.NumberOfSecondPlaces * 1 + tip.NumberOfThirdPlaces * 1) / tip.NumberOfRaces * tip.TrioOdds * tip.ShowRate
                    }
                    );
                }
            });
        }
    }
}