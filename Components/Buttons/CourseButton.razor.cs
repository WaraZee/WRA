using Microsoft.AspNetCore.Components;

namespace WRA.Components.Buttons
{
    public partial class CourseButton
    {
        [Parameter]
        public string Content { get; set; } = "Button";
        [Parameter]
        public string Course
        {
            get => _course ?? string.Empty;
            set
            {
                _course = value;
                ChangeBackgroundColor(_course);
            }
        }

        private string _course = "truf";
        private string _backgroundColor = "rgba(56, 142, 60, 1)";

        protected override void OnInitialized()
        {
            StateContainer.OnChange += StateHasChanged;
            _backgroundColor = "rgba(56, 142, 60, 1)";
            if (StateContainer.CourseName == "turf")
            {
                _backgroundColor = "rgba(16, 43, 18, 1)";
            }
        }

        private void ChangePropertyValue(string course)
        {
            StateContainer.CourseName = course;
            Course = StateContainer.CourseName;
        }

        private void ChangeBackgroundColor(string course)
        {
            _backgroundColor = "rgba(56, 142, 60, 1)";
            if (StateContainer.CourseName == _course)
            {
                _backgroundColor = "rgba(16, 43, 18, 1)";
            }
        }

        public void Dispose()
        {
            StateContainer.OnChange -= StateHasChanged;
        }
    }
}