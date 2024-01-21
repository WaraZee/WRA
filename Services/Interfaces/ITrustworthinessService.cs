using WRA.Models;

namespace WRA.Services.Interfaces
{
    public interface ITrustworthinessService
    {
        List<Tip> CalculateTrustworthinessByOdds(List<WinShowRate> winShowRates, List<Tip> tips);
    }
}