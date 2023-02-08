using CloudToolbox.Common.Types;

namespace CloudToolbox.Common.Models.Calculator
{
    public class CalculatorInput
    {
        public CalculatorInput(string id, Type type)
        {
            Id = id;
            Type = type;
            InputBool = false;
        }

        public string Id { get; }
        public Type Type { get; }

        public string? InputString { get; set; }
        public DateTime? InputDateTime { get; set; }
        public TimeOnly? InputTimeOnly { get; set; }

        public bool InputBool { get; set; }

        private bool HasValue
        {
            get
            {
                if (Type == typeof(Checkbox) || Type == typeof(bool) || Type == typeof(string))
                {
                    return true;
                }

                if (Type == typeof(DateTime))
                {
                    return InputDateTime.HasValue;
                }

                if (Type == typeof(TimeOnly))
                {
                    return InputTimeOnly.HasValue;
                }

                return false;
            }
        }

        public string? StartInputGroupText { get; set; }
        public string? EndInputGroupText { get; set; }

        public bool IsValid => (HasValue);

        public string InvalidCssClass => "is-invalid";

        public bool IsStandardInput
        {
            get
            {
                return Type != typeof(Checkbox) &&
                Type != typeof(bool);
            }
        }
    }
}
