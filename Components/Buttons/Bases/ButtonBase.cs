using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace WRA.Components.Buttons.Bases
{
    public abstract class ButtonBase : ComponentBase
    {
        [Parameter]
        public string Content { get; set; } = "Button";
        [Parameter]
        public bool IsSelected { get; set; }
        [Parameter]
        public EventCallback<MouseEventArgs> OnClick { get; set; }
    }
}