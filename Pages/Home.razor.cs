using Microsoft.AspNetCore.Components;
using WRA.Models;
using WRA.Services.Interfaces;

namespace WRA.Pages
{
    public partial class Home : ComponentBase
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

        [Inject]
        protected ITrustworthinessService? TrustworthinessService { get; set; }
        [Inject]
        protected IWinRateService? WinRateService { get; set; }
        [Inject]
        protected IShowRateService? ShowRateService { get; set; }

        private List<WinShowRate> _turfWinShowRates = new List<WinShowRate>
        {
            new WinShowRate
            {
                WinRate = 33.1f / 100f,
                ShowRate = 64.2f / 100f
            },
            new WinShowRate
            {
                WinRate = 19.1f / 100f,
                ShowRate = 52.4f / 100f
            },
            new WinShowRate
            {
                WinRate = 13.8f / 100f,
                ShowRate = 42.9f / 100f
            },
            new WinShowRate
            {
                WinRate = 9.2f / 100f,
                ShowRate = 33.2f / 100f
            },
            new WinShowRate
            {
                WinRate = 7.1f / 100f,
                ShowRate = 26.9f / 100f
            },
            new WinShowRate
            {
                WinRate = 5.0f / 100f,
                ShowRate = 21.3f / 100f
            },
            new WinShowRate
            {
                WinRate = 3.9f / 100f,
                ShowRate = 16.3f / 100f
            },
            new WinShowRate
            {
                WinRate = 2.8f / 100f,
                ShowRate = 12.5f / 100f
            },
            new WinShowRate
            {
                WinRate = 2.0f / 100f,
                ShowRate = 10.3f / 100f
            },
            new WinShowRate
            {
                WinRate = 1.8f / 100f,
                ShowRate = 7.9f / 100f
            },
            new WinShowRate
            {
                WinRate = 1.1f / 100f,
                ShowRate = 6.4f / 100f
            },
            new WinShowRate
            {
                WinRate = 1.0f / 100f,
                ShowRate = 5.3f / 100f
            },
            new WinShowRate
            {
                WinRate = 0.8f / 100f,
                ShowRate = 4.0f / 100f
            },
            new WinShowRate
            {
                WinRate = 0.6f / 100f,
                ShowRate = 2.9f / 100f
            },
            new WinShowRate
            {
                WinRate = 0.3f / 100f,
                ShowRate = 2.1f / 100f
            },
            new WinShowRate
            {
                WinRate = 0.3f / 100f,
                ShowRate = 1.5f / 100f
            },
            new WinShowRate
            {
                WinRate = 0.1f / 100f,
                ShowRate = 1.2f / 100f
            },
            new WinShowRate
            {
                WinRate = 0.1f / 100f,
                ShowRate = 0.8f / 100f
            }
        };

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
                if (TrustworthinessService != null && WinRateService != null && ShowRateService != null)
                {
                    _tips = TrustworthinessService.CalculateTrustworthinessByOdds(_turfWinShowRates, _tips);
                    _winCalculationResults = WinRateService.Calculate(_tips);
                    _showCalculationResults = ShowRateService.Calculate(_tips);
                }
            });
        }
    }
}