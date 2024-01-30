namespace WRA.Store
{
    public class StateContainer
    {
        private string? _savedCourseName;
        private bool _savedIsLoading;
        private bool _savedMenuIsClicked;
        private int _savedSelectedTicketTypeId;

        public string CourseName
        {
            get => _savedCourseName ?? string.Empty;
            set
            {
                _savedCourseName = value;
                NotifyStateChanged();
            }
        }

        public bool IsLoading
        {
            get => _savedIsLoading;
            set
            {
                _savedIsLoading = value;
                NotifyStateChanged();
            }
        }

        public bool MenuIsClicked
        {
            get => _savedMenuIsClicked;
            set
            {
                _savedMenuIsClicked = value;
                NotifyStateChanged();
            }
        }

        public int TicketTypeId
        {
            get => _savedSelectedTicketTypeId;
            set
            {
                _savedSelectedTicketTypeId = value;
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