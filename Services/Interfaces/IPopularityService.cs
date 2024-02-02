using WRA.Models;

namespace WRA.Services.Interfaces
{
    public interface IPopularityService
    {
        List<Tip> Calculate(List<Rate> winShowRates, List<Tip> tips);
    }
}