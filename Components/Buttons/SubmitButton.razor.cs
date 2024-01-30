using Microsoft.AspNetCore.Components;

namespace WRA.Components.Buttons
{
    public partial class SubmitButton
    {
        [Parameter]
        public string Course { get; set; } = "";

        protected override void OnInitialized()
        {
            StateContainer.OnChange += StateHasChanged;
        }

        private void ChangePropertyValue(bool isLoading)
        {
            StateContainer.IsLoading = !isLoading;
        }

        public void Dispose()
        {
            StateContainer.OnChange -= StateHasChanged;
        }

        private async void OnClickAsync()
        {
            ChangePropertyValue(StateContainer.IsLoading);
            await OnClick.InvokeAsync();
            ChangePropertyValue(StateContainer.IsLoading);
        }
    }
}