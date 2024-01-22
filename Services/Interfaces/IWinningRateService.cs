using WRA.Models;

namespace WRA.Services.Interfaces
{
    public interface IWinningRateService
    {
        Task<List<WinningRate>> CreateAsync(string name);
        List<CalculationResult> Calculate(List<Tip> tips);
    }
}