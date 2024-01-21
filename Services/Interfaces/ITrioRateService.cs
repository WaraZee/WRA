using WRA.Models;

namespace WRA.Services.Interfaces
{
    public interface ITrioRateService
    {
        List<CalculationResult> Calculate(List<Tip> tips);
    }
}