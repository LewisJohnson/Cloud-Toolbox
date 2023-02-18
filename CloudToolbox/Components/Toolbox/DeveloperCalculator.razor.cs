using CloudToolbox.Calculators;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Enums.Units;
using CloudToolbox.Common.Models.Calculator;
using CloudToolbox.Services;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox
{
	public partial class DeveloperCalculatorBase : ComponentBase
	{

		[Parameter]
		public string? UriParam { get; set; }

		public List<CalculatorInput> Inputs { get; set; }
		public List<CalculatorResult> ResultsTemplate { get; set; }

		public DeveloperCalculatorBase()
		{
			Inputs = new List<CalculatorInput>();
			ResultsTemplate = new List<CalculatorResult>();
		}

		public string? DisplayCalcType { get; set; }
		public string? DisplayDirection { get; set; }
		public DeveloperCalculatorsEnum? Calc { get; set; }
		public DeveleoperCalculatorDirection Direction { get; set; }

		[Inject]
		public NavigationManager NavigationManager { get; set; }

		[Inject]
		public NotFoundService NotFoundService { get; set; }

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
					NotFoundService.NotifyNotFound();
					return;
				}

				Direction = directionParam.ToLower() == "from" ? DeveleoperCalculatorDirection.From : DeveleoperCalculatorDirection.To;
				Calc = DeveloperCalculatorsEnum.MatchFromUri(calcTypeParam);

				if (Calc == null)
				{
					NotFoundService.NotifyNotFound();
					return;
				}

				DisplayDirection = Direction.ToString();
				DisplayCalcType = Calc.Name;

				if (Direction == DeveleoperCalculatorDirection.From)
				{
					Inputs.Add(new("Text", typeof(string)) { Label = Calc.Name, UseLargeInput = true });
					ResultsTemplate.Add(new(null) { Label = "Text", Type = CalculatorResultType.TextArea });
				}
				else
				{
					Inputs.Add(new("Text", typeof(string)) { Label = "Text", UseLargeInput = true });
					ResultsTemplate.Add(new(null) { Label = Calc.Name, Type = CalculatorResultType.TextArea });
				}

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
				string converted = new DeveloperConverter((Direction, Calc.CalcType)).Convert(input);

				if (Direction == DeveleoperCalculatorDirection.From)
				{
					returnRes.Add(new(converted) { Label = "Text", Type = CalculatorResultType.TextArea });
				}
				else
				{
					returnRes.Add(new(converted) { Label = Calc.Name, Type = CalculatorResultType.TextArea });
				}
			}

			return returnRes;
		}


	}
}
