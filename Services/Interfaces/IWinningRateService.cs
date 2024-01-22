using WRA.Models;

namespace WRA.Services.Interfaces
{
    public interface IWinningRateService
    {
        List<WinningRate> Create(string name);
        List<CalculationResult> Calculate(List<Tip> tips);
    }
}