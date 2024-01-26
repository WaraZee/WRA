using Microsoft.AspNetCore.Components;

namespace WRA.Components.Buttons
{
    public partial class MenuButton
    {
        [Parameter]
        public int TicketType { get; set; }

        protected override void OnInitialized()
        {
            StateContainer.OnChange += StateHasChanged;
        }

        private void ChangePropertyValue(bool isClicked)
        {
            StateContainer.MenuIsClicked = !isClicked;
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