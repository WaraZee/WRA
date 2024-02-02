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

        private async Task SubmitButtonOnClickAsync()
        {
            await Task.Run(() =>
            {
                // "rateByCourse" で判断しているが、ボタンは "人気" と表示されている。理由は、コース別レートが人気別になっているため。
                if (StateContainer.FormulaName == "rateByCourse")
                {
                    _winShowRates = AllRateService.GetRateByCourse(StateContainer.CourseName);
                }
                else if (StateContainer.FormulaName == "rateByWinOdds")
                {
                    _winShowRates = AllRateService.GetRateByOdds(StateContainer.FormulaName);
                }

                if (_winShowRates != null)
                {
                    _tips = PopularityService.Calculate(_winShowRates, _tips);

                    if (StateContainer.FormulaName == "rateByCourse")
                    {
                        _winCalculationResults = WinRateService.CalculateByCourse(_tips);
                    }
                    else if (StateContainer.FormulaName == "rateByWinOdds")
                    {
                        _winCalculationResults = WinRateService.CalculateByWinOdds(_winShowRates, _tips);
                    }

                    // yet
                    if (StateContainer.FormulaName == "rateByCourse")
                    {
                        _showCalculationResults = ShowRateService.CalculateByCourse(_tips);
                    }
                    else if (StateContainer.FormulaName == "rateByWinOdds")
                    {
                        _showCalculationResults = ShowRateService.CalculateByWinOdds(_winShowRates, _tips);
                    }
                }
            });
        }
    }
}