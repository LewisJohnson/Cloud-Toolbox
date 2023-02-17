using CloudToolbox.Calculators.Unit;
using CloudToolbox.Common.Data;
using CloudToolbox.Common.Enums.Units;
using CloudToolbox.Common.Models.Calculator;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox
{
	public partial class UnitsCalculatorBase : ComponentBase
	{

		[Parameter]
		public string? UriParam { get; set; }

		public List<CalculatorInput> Inputs { get; set; }
		public List<CalculatorResult> ResultsTemplate { get; set; }

		public UnitsCalculatorBase()
		{
			Inputs = new List<CalculatorInput>();
			ResultsTemplate = new List<CalculatorResult>();
		}

		public string? DisplayUnitFrom { get; set; }
		public string? DisplayUnitTo { get; set; }

		public string? DisplayUnitFromDesc { get; set; }
		public string? DisplayUnitToDesc { get; set; }

		public UnitCalculatorsEnum? FromUnitOf { get; set; }
		public UnitCalculatorsEnum? ToUnitOf { get; set; }

		[Inject]
		NavigationManager NavigationManager { get; set; }

		protected override void OnParametersSet()
		{
			FromUnitOf = null;
			ToUnitOf = null;
			DisplayUnitFrom = string.Empty;
			DisplayUnitTo = string.Empty;

			Inputs = new List<CalculatorInput>();
			ResultsTemplate = new List<CalculatorResult>();

			if (string.IsNullOrWhiteSpace(UriParam))
			{
				NavigationManager.NavigateTo("404", false);
			}
			try
			{
				var parts = UriParam.Split("-to-");
				var unitFromParam = parts[0] ?? null;
				var unitToParam = parts[1] ?? null;

				if (unitFromParam == null || unitToParam == null)
				{
					NavigationManager.NavigateTo("404", false);
				}

				FromUnitOf = UnitCalculatorsEnum.MatchFromUri(unitFromParam);
				ToUnitOf = UnitCalculatorsEnum.MatchFromUri(unitToParam);

				if (FromUnitOf == null || ToUnitOf == null)
				{
					NavigationManager.NavigateTo("404", false);
				}

				if (FromUnitOf.UnitType != ToUnitOf.UnitType)
				{
					NavigationManager.NavigateTo("500", false);
				}

				DisplayUnitFrom = FromUnitOf.Name;
				DisplayUnitTo = ToUnitOf.Name;
				DisplayUnitFromDesc = FromUnitOf.Name + (FromUnitOf.Abbreviation != FromUnitOf.Name ? $" ({FromUnitOf.Abbreviation})" : "");
				DisplayUnitToDesc = ToUnitOf.Name + (ToUnitOf.Abbreviation != ToUnitOf.Name ? $" ({ToUnitOf.Abbreviation})" : "");

				Inputs.Add(new("Number", typeof(string)) { EndInputGroupText = FromUnitOf.Abbreviation });

				ResultsTemplate.Add(new(null) { EndInputGroupText = ToUnitOf.Abbreviation });

				InvokeAsync(StateHasChanged);

			}
			catch (Exception _) { }
		}

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{

			var returnRes = new List<CalculatorResult>();

			double? input = inputs[0].InputDouble;

			if (input != null && FromUnitOf != null && ToUnitOf != null)
			{
				double converted = 0;

				switch (FromUnitOf.UnitType)
				{
					case UnitTypes.Area:
						converted = new UnitOfAreaConverter(((UnitOfArea)FromUnitOf.Unit, (UnitOfArea)ToUnitOf.Unit)).Convert(input.Value);
						break;

					case UnitTypes.DataTransfer:
						converted = new UnitOfDataTranserConverter(((UnitOfDataTranser)FromUnitOf.Unit, (UnitOfDataTranser)ToUnitOf.Unit)).Convert(input.Value);
						break;

					case UnitTypes.Energy:
						converted = new UnitOfEnergyConverter(((UnitOfEnergy)FromUnitOf.Unit, (UnitOfEnergy)ToUnitOf.Unit)).Convert(input.Value);
						break;

					case UnitTypes.Length:
						converted = new UnitOfLengthConverter(((UnitOfLength)FromUnitOf.Unit, (UnitOfLength)ToUnitOf.Unit)).Convert(input.Value);
						break;

					case UnitTypes.Mass:
						converted = new UnitOfMassConverter(((UnitOfMass)FromUnitOf.Unit, (UnitOfMass)ToUnitOf.Unit)).Convert(input.Value);
						break;

					case UnitTypes.Speed:
						converted = new UnitOfSpeedConverter(((UnitOfSpeed)FromUnitOf.Unit, (UnitOfSpeed)ToUnitOf.Unit)).Convert(input.Value);
						break;

					case UnitTypes.Time:
						converted = new UnitOfTimeConverter(((UnitOfTime)FromUnitOf.Unit, (UnitOfTime)ToUnitOf.Unit)).Convert(input.Value);
						break;
				}

				string res = converted < 1 ? converted.ToString("0.######") : converted.ToString(Constants.FRONTEND_NUMBER_FORMAT);

				returnRes.Add(new(res) { EndInputGroupText = ToUnitOf.Abbreviation });
			}

			return returnRes;
		}


	}
}
