using WRA.Models;

namespace WRA.Services.Interfaces
{
    public interface IAllRateService
    {
        List<Rate> GetRateByCourse(string name);
        List<Rate> GetRateByOdds(string name);
    }
}