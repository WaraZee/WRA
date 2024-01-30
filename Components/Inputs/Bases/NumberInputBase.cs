using Microsoft.AspNetCore.Components;
using WRA.Models;

namespace WRA.Components.Inputs.Bases
{
    public class NumberInputBase : ComponentBase
    {
        [Parameter]
        public EventCallback<InputValue> OnValueChanged { get; set; }
        [Parameter]
        public int ColumnId { get; set; }
        [Parameter]
        public int HorseNumber { get; set; }

        public float Value
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

        private float _value;
    }
}