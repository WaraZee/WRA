using WRA.Models;

namespace WRA.Services.Interfaces
{
    public interface ITrieceRateService
    {
        List<CalculationResult> Calculate(List<Tip> tips);
    }
}
