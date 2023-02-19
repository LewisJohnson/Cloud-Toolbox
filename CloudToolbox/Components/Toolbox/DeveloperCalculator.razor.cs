using CloudToolbox.Calculators;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Models.Calculator;
using CloudToolbox.Services;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox
{
	public partial class DeveloperCalculatorBase : ComponentBase
	{
		[Parameter] public string UriParam { get; set; }
		[Inject] public NotFoundService NotFoundService { get; set; }
		[Inject] public NavigationManager NavigationManager { get; set; }

		protected List<CalculatorInput> Inputs { get; set; }
		protected List<CalculatorResult> ResultsTemplate { get; set; }
		protected string? DisplayCalcType { get; set; }
		protected string? DisplayDirection { get; set; }
		protected DeveloperCalculatorsEnum? Calc { get; set; }
		protected DeveleoperCalculatorDirection Direction { get; set; }

		public DeveloperCalculatorBase()
		{
			Inputs = new List<CalculatorInput>();
			ResultsTemplate = new List<CalculatorResult>();
		}

		protected override async Task OnParametersSetAsync()
		{
			Calc = null;
			DisplayCalcType = null;
			Inputs = new List<CalculatorInput>();
			ResultsTemplate = new List<CalculatorResult>();

			if (string.IsNullOrWhiteSpace(UriParam))
			{
				NotFoundService.NotifyNotFound();
				return;
			}

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
