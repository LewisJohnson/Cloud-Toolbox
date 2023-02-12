using CloudToolbox.Common.Data;
using CloudToolbox.Common.Enums;

namespace CloudToolbox.Common.Models.Calculator
{
    public class CalculatorResult
    {
        public string? Value { get; set; }
        public string? Label { get; set; }
        public string? StartInputGroupText { get; set; }
        public string? EndInputGroupText { get; set; }
        public CalculatorResultType Type { get; set; }

		public CalculatorResult(string? value)
        {
            Value = value;
        }
	}
}
