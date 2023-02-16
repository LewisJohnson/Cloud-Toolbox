using CloudToolbox.Calculators;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Enums.Units;
using CloudToolbox.Common.Models.Calculator;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox
{
	public partial class TextCalculatorBase : ComponentBase
	{

		[Parameter]
		public string? UriParam { get; set; }

		public List<CalculatorInput> Inputs { get; set; }
		public List<CalculatorResult> ResultsTemplate { get; set; }

		public TextCalculatorBase()
		{
			Inputs = new List<CalculatorInput>();
			ResultsTemplate = new List<CalculatorResult>();
		}

		public string? DisplayCalcType { get; set; }
		public string? DisplayDirection { get; set; }
		public TextCalculatorsEnum? Calc { get; set; }

		[Inject]
		NavigationManager NavigationManager { get; set; }


		protected override void OnParametersSet()
		{
			Calc = null;
			DisplayCalcType = null;
			Inputs = new List<CalculatorInput>();
			ResultsTemplate = new List<CalculatorResult>();

			if (string.IsNullOrWhiteSpace(UriParam))
			{
				NavigationManager.NavigateTo("404", false);
			}

			try
			{
				var parts = UriParam.Split("-");
				var directionParam = parts[0] ?? null;
				var calcTypeParam = parts[1] ?? null;

				if (directionParam == null || calcTypeParam == null)
				{
					NavigationManager.NavigateTo("404", false);
				}

				Calc = TextCalculatorsEnum.MatchFromUri(calcTypeParam);

				if (Calc == null)
				{
					NavigationManager.NavigateTo("404", false);
				}

				DisplayCalcType = Calc.Name;

				Inputs.Add(new("Text", typeof(string)) { Label = "Text", UseLargeInput = true });
				ResultsTemplate.Add(new(null) { Label = Calc.Name, Type = CalculatorResultType.TextArea });

				InvokeAsync(StateHasChanged);

			}
			catch (Exception _) { }
		}

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{

			var returnRes = new List<CalculatorResult>();

			string? input = inputs[0].InputString;

			if (input != null && Calc != null)
			{
				string converted = new TextConverter(Calc.CalcType).Convert(input);

				returnRes.Add(new(converted) { Label = Calc.Name, Type = CalculatorResultType.TextArea });

			}

			return returnRes;
		}
	}
}
