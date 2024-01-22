using WRA.Store;

namespace WRA.Layout
{
    public partial class MainLayout
    {
        protected override void OnInitialized()
        {
            CourseStateContainer.Property = "turf";
            CourseStateContainer.OnChange += StateHasChanged;
        }

        public void Dispose()
        {
            CourseStateContainer.OnChange -= StateHasChanged;
        }
    }
}