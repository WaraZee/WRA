using Microsoft.AspNetCore.Components;

namespace WRA.Components.Navs
{
    public partial class Nav
    {
        [Parameter]
        public RenderFragment? Item1 { get; set; }
        [Parameter]
        public RenderFragment? Item2 { get; set; }
    }
}