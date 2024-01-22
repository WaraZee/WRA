using WRA.Models;

namespace WRA.Components.Inputs
{
    public partial class StakeInput
    {
        public new float Value
        {
            get => _value;
            set
            {
                if (_value != value)
                {
                    _value = value;
                    InputValue inputValue = new()
                    {
                        ColumnId = ColumnId,
                        HorseNumber = HorseNumber,
                        Value = value
                    };
                    _ = OnValueChanged.InvokeAsync(inputValue);
                }
            }
        }

        private float _value = 100f;
    }
}