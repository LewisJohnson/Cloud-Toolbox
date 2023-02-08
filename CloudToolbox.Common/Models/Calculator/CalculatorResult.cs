namespace CloudToolbox.Common.Models.Calculator
{
    public class CalculatorResult
    {
        public string? Value;
        public string? StartInputGroupText;
        public string? EndInputGroupText;

        public CalculatorResult(string? value)
        {
            Value = value;
        }
    }
}
