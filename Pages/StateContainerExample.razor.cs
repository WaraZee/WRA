namespace WRA.Pages
{
    public partial class StateContainerExample
    {
        protected override void OnInitialized()
        {
            StateContainer.OnChange += StateHasChanged;
        }

        private void ChangePropertyValue()
        {
            StateContainer.Property = "New value set in the State " +
                $"Container Example component: {DateTime.Now}";
        }

        public void Dispose()
        {
            StateContainer.OnChange -= StateHasChanged;
        }
    }
}