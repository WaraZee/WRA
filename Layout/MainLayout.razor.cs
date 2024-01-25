namespace WRA.Layout
{
    public partial class MainLayout
    {
        protected override void OnInitialized()
        {
            StateContainer.CourseName = "turf";
            StateContainer.MenuIsClicked = false;
            StateContainer.OnChange += StateHasChanged;
        }

        public void Dispose()
        {
            StateContainer.OnChange -= StateHasChanged;
        }
    }
}