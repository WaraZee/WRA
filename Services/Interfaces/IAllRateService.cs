using WRA.Models;

namespace WRA.Services.Interfaces
{
    public interface IAllRateService
    {
        List<Rate> GetRate(string name);
    }
}