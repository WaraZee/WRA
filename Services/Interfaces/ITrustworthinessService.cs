using WRA.Models;

namespace WRA.Services.Interfaces
{
    public interface ITrustworthinessService
    {
        List<Tip> CalculateTrustworthinessByOdds(List<Rate> winShowRates, List<Tip> tips);
    }
}