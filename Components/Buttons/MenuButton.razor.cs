using Microsoft.JSInterop;

namespace WRA.Components.Buttons
{
    public partial class MenuButton
    {
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JSRuntime.InvokeVoidAsync("activeIndeterminate");
        }
    }
}