using WRA.Models;
using Microsoft.AspNetCore.Components;

namespace WRA.Components.Tables
{
    public partial class CalculationResultTable
    {
        [Parameter]
        public List<CalculationResult> CalculationResults { get; set; } = new List<CalculationResult>();

        private async Task ThButtonOnClickAsync(int thId)
        {
            await Task.Run(() =>
            {
                switch (thId)
                {
                    case 1:
                        CalculationResults = CalculationResults.OrderBy(calcResult => calcResult.HorseNumber).ToList();
                        break;

                    case 2:
                        CalculationResults = CalculationResults.OrderByDescending(calcResult => calcResult.RefundAmount).ToList();
                        break;

                    case 3:
                        CalculationResults = CalculationResults.OrderByDescending(calcResult => calcResult.ExpectedValue).ToList();
                        break;

                    default:
                        break;
                }
            });
        }
    }
}