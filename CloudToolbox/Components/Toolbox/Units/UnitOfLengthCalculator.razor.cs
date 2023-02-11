using Microsoft.AspNetCore.Components;
using CloudToolbox.Calculators.Unit;
using CloudToolbox.Common.Models.Calculator;
using CloudToolbox.Common.Enums.Units;
using CloudToolbox.Common.Data;
using CloudToolbox.Common.Data.DisplayCalculatorCollections;

namespace CloudToolbox.Components.Toolbox.Units
{
	public partial class UnitOfLengthCalculatorBase : ComponentBase
	{

		[Parameter]
		public string Subarea { get; set; }

		[Parameter]
		public string? Units { get; set; }

		public List<CalculatorInput> Inputs { get; set; }
		public List<CalculatorResult> ResultsTemplate { get; set; }

		public UnitOfLengthCalculatorBase()
		{
			Inputs = new List<CalculatorInput>();
			ResultsTemplate = new List<CalculatorResult>();
		}

		public string? UnitFromParam { get; set; }
		public string? UnitToParam { get; set; }

		public string? DisplayUnitFrom { get; set; }
		public string? DisplayUnitTo { get; set; }

		[Inject]
		NavigationManager NavigationManager { get; set; }

		UnitsCalculatorCollection unitsDisplayCalculatorCollection { get; set; }


		protected override void OnParametersSet()
		{
			unitsDisplayCalculatorCollection = new UnitsCalculatorCollection();

			if (string.IsNullOrWhiteSpace(Units))
			{
				// Return 404
			}
			try
			{
				var parts = Units.Split("-to-");
				UnitFromParam = parts[0];
				UnitToParam = parts[1];

				if (Subarea.ToLower() == "length")
				{
					DisplayCalculator? unitFrom = unitsDisplayCalculatorCollection.MatchParamToCalculator(UnitFromParam);
					DisplayCalculator? unitTo = unitsDisplayCalculatorCollection.MatchParamToCalculator(UnitToParam);

					if (unitFrom == null || unitTo == null)
					{
						NavigationManager.NavigateTo("404", false);
					}

					DisplayUnitFrom = unitFrom.DisplayName;
					DisplayUnitTo = unitTo.DisplayName;

					Inputs.Add(new(unitFrom, "Number", typeof(string)) { EndInputGroupText = unitFrom.Abbreviation });

					ResultsTemplate.Add(new(unitTo, null) { EndInputGroupText = unitTo.Abbreviation });
				}
			}
			catch (Exception _) { }
		}


		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{

			var returnRes = new List<CalculatorResult>();

			double? input = inputs[0].InputDouble;

			if (input != null)
			{
				double converted = new UnitOfLengthConverter((
					(UnitOfLength)inputs[0].DisplayCalculator.UnitValue,
					(UnitOfLength)ResultsTemplate[0].DisplayCalculator.UnitValue))
					.Convert(input.Value);

				string res = converted.ToString(Constants.FRONTEND_NUMBER_FORMAT);

				returnRes.Add(new(res) { EndInputGroupText = ResultsTemplate[0].DisplayCalculator.Abbreviation });
			}

			return returnRes;
		}


	}
}
