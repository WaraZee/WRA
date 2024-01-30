﻿using WRA.Models;

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

        private List<Rate>? _winShowRates;

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
                        HorseNumber = i,
                        Stake = 100f
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
                //_winShowRates = AllRateService.GetRate(StateContainer.CourseName);
                _winShowRates = AllRateService.GetRate("rateByWinOdds");
                if (_winShowRates != null)
                {
                    _tips = TrustworthinessService.CalculateTrustworthinessByOdds(_winShowRates, _tips);
                }
                _winCalculationResults = WinRateService.Calculate(_tips);
                _showCalculationResults = ShowRateService.Calculate(_tips);
            });
        }
    }
}