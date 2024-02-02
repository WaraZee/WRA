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
                _winShowRates = AllRateService.GetRate(StateContainer.CourseName);
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