using Microsoft.AspNetCore.Components;

namespace WRA.Components.Buttons
{
    public partial class CourseButton
    {
        [Parameter]
        public string Course { get; set; } = "";

        protected override void OnInitialized()
        {
            StateContainer.OnChange += StateHasChanged;
        }

        private void ChangePropertyValue(string course)
        {
            StateContainer.CourseName = course;
        }

        public void Dispose()
        {
            StateContainer.OnChange -= StateHasChanged;
        }
    }
}