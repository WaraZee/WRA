using WRA.Models;

namespace WRA.Services.Interfaces
{
    public interface IWinRateService
    {
        List<CalculationResult> CalculateByCourse(List<Tip> tips);
        List<CalculationResult> CalculateByWinOdds(List<Rate> rates, List<Tip> tips);
    }
}