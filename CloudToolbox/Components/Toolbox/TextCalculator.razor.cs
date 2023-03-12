using CloudToolbox.Calculators;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Models.Calculator;
using CloudToolbox.Services;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox
{
	public partial class TextCalculatorBase : ComponentBase
	{

		[Parameter] public string UriParam { get; set; }

		[Inject] public NotFoundService NotFoundService { get; set; }
		[Inject] public NavigationManager NavigationManager { get; set; }

		public List<CalculatorInput> Inputs { get; set; }
		public List<CalculatorResult> ResultsTemplate { get; set; }
		public string? DisplayDirection { get; set; }
		public TextCalculatorsEnum? Calc { get; set; }

		public TextCalculatorBase()
		{
			Inputs = new List<CalculatorInput>();
			ResultsTemplate = new List<CalculatorResult>();
		}

		protected override async Task OnParametersSetAsync()
		{
			Calc = null;
			Inputs = new List<CalculatorInput>();
			ResultsTemplate = new List<CalculatorResult>();

			string[] uriParts = UriParam.Split("-");

			if (uriParts.Length != 2)
			{
				NotFoundService.NotifyNotFound();
				return;
			}

			string directionParam = uriParts[0];
			string calcTypeParam = uriParts[1];

			if (directionParam == null || calcTypeParam == null)
			{
				NotFoundService.NotifyNotFound();
				return;
			}

			Calc = TextCalculatorsEnum.MatchFromUri(calcTypeParam);

			if (Calc == null)
			{
				NotFoundService.NotifyNotFound();
				return;
			}

			Inputs.Add(new("Text", typeof(string)) { InputString = "The Quick Brown Fox Jumps over the Lazy Dog", Label = "Text", UseLargeInput = true });
			ResultsTemplate.Add(new(null) { Label = Calc.Name, Type = CalculatorResultType.TextArea });
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
