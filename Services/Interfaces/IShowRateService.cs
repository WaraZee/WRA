using WRA.Models;

namespace WRA.Services.Interfaces
{
    public interface IShowRateService
    {
        List<CalculationResult> Calculate(List<Tip> tips);
    }
}