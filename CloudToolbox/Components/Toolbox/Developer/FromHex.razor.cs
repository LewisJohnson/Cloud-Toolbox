using System.Text;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Models.Calculator;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox.Developer
{
	public partial class FromHexBase : ComponentBase
	{
		public List<CalculatorInput> Inputs => new()
		{
			new("FromHex", typeof(string)) { Label = "Hexadecimal", UseLargeInput = true },
		};

		public List<CalculatorResult> ResultsTemplate => new()
		{
			new CalculatorResult(null) { Label = "Text", Type = CalculatorResultType.TextArea },
		};

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{
			var results = new List<CalculatorResult>();

			string inputString = inputs[0].InputString ?? string.Empty;

			byte[] hexArray = Convert.FromHexString(inputString);
			string res = Encoding.UTF8.GetString(hexArray, 0, hexArray.Length);

			results.Add(new(res) { Label = "Text", Type = CalculatorResultType.TextArea });

			return results;
		}
	}
}
