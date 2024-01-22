using Microsoft.AspNetCore.Components;
using WRA.Store;

namespace WRA.Components.Buttons
{
    public partial class CourseButton
    {
        [Parameter]
        public string Content { get; set; } = "Button";
        [Parameter]
        public string Course { get; set; } = "";

        protected override void OnInitialized()
        {
            CourseStateContainer.OnChange += StateHasChanged;
        }

        private void ChangePropertyValue(string course)
        {
            CourseStateContainer.Property = course;
        }

        public void Dispose()
        {
            CourseStateContainer.OnChange -= StateHasChanged;
        }
    }
}