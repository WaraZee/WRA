using WRA.Models;

namespace WRA.Services.Interfaces
{
    public interface IWinRateService
    {
        List<CalculationResult> Calculate(List<Tip> tips);
    }
}