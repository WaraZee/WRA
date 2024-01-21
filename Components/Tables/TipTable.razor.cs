using WRA.Models;
using Microsoft.AspNetCore.Components;

namespace WRA.Components.Tables
{
    public partial class TipTable
    {
        [Parameter]
        public List<Tip> Tips { get; set; } = new List<Tip>();

        private string _horseNumberHeader = "馬番";
        private string _winOddsHeader = "単勝";
        private string _showOddsHeader = "複勝";
        private string _trierceOddsHeader = "3連単";
        private string _trioOddsHeader = "3連複";
        private string _numberOfRacesHeader = "走数";
        private string _numberOfFirstPlacesHeader = "1着数";
        private string _numberOfSecondPlacesHeader = "2着数";
        private string _numberOfThirdPlacesHeader = "3着数";
        private string _stakeHeader = "賭け金";

        private async Task NumberInputOnChangeAsync(InputValue inputValue)
        {
            await Task.Run(() =>
            {
                switch (inputValue.ColumnId)
                {
                    case 1:
                        Tips[inputValue.HorseNumber].WinOdds = inputValue.Value;
                        break;
                    case 2:
                        Tips[inputValue.HorseNumber].ShowOdds = inputValue.Value;
                        break;
                    case 3:
                        Tips[inputValue.HorseNumber].TrierceOdds = inputValue.Value;
                        break;
                    case 4:
                        Tips[inputValue.HorseNumber].TrioOdds = inputValue.Value;
                        break;
                    case 5:
                        Tips[inputValue.HorseNumber].NumberOfRaces = inputValue.Value;
                        break;
                    case 6:
                        Tips[inputValue.HorseNumber].NumberOfFirstPlaces = inputValue.Value;
                        break;
                    case 7:
                        Tips[inputValue.HorseNumber].NumberOfSecondPlaces = inputValue.Value;
                        break;
                    case 8:
                        Tips[inputValue.HorseNumber].NumberOfThirdPlaces = inputValue.Value;
                        break;
                    case 9:
                        Tips[inputValue.HorseNumber].Stake = inputValue.Value;
                        break;
                    default:
                        break;
                }
            });
        }
    }
}