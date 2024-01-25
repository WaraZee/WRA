namespace WRA.Store
{
    public class StateContainer
    {
        private string? savedCourseName;
        private bool savedMenuIsClicked;
        private int savedSelectedTicketTypeId;

        public string CourseName
        {
            get => savedCourseName ?? string.Empty;
            set
            {
                savedCourseName = value;
                NotifyStateChanged();
            }
        }

        public bool MenuIsClicked
        {
            get => savedMenuIsClicked;
            set
            {
                savedMenuIsClicked = value;
                NotifyStateChanged();
            }
        }

        public int TicketTypeId
        {
            get => savedSelectedTicketTypeId;
            set
            {
                savedSelectedTicketTypeId = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged()
        {
            OnChange?.Invoke();
        }
    }
}