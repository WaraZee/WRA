using WRA.Models;

namespace WRA.Services.Interfaces
{
    public interface ITrustworthinessService
    {
        List<Tip> CalculateTrustworthinessByOdds(List<WinningRate> winShowRates, List<Tip> tips);
    }
}