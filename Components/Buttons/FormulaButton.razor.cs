using Microsoft.AspNetCore.Components;

namespace WRA.Components.Buttons
{
    public partial class FormulaButton
    {
        [Parameter]
        public string Formula { get; set; } = "";

        protected override void OnInitialized()
        {
            StateContainer.OnChange += StateHasChanged;
        }

        private void ChangePropertyValue(string formula)
        {
            StateContainer.FormulaName = formula;
        }

        public void Dispose()
        {
            StateContainer.OnChange -= StateHasChanged;
        }
    }
}