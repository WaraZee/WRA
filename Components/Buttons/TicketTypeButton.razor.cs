using Microsoft.AspNetCore.Components;

namespace WRA.Components.Buttons
{
    public partial class TicketTypeButton
    {
        [Parameter]
        public int Type { get; set; }

        protected override void OnInitialized()
        {
            StateContainer.OnChange += StateHasChanged;
        }

        private void ChangePropertyValue(int typeId)
        {
            StateContainer.TicketTypeId = typeId;
        }

        public void Dispose()
        {
            StateContainer.OnChange -= StateHasChanged;
        }
    }
}