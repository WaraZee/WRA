using Microsoft.AspNetCore.Components;

namespace WRA.Components.Labels.Bases
{
    public abstract class LabelBase : ComponentBase
    {
        [Parameter]
        public string Content { get; set; } = "Label";
    }
}