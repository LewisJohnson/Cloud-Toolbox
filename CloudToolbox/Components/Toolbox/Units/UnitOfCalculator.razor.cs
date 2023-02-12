using Microsoft.AspNetCore.Components;
using CloudToolbox.Calculators.Unit;
using CloudToolbox.Common.Models.Calculator;
using CloudToolbox.Common.Enums.Units;
using CloudToolbox.Common.Data;
using CloudToolbox.Common.Data.DisplayCalculatorCollections;

namespace CloudToolbox.Components.Toolbox.Units
{
	public partial class UnitOfCalculatorBase : ComponentBase
	{

		[Parameter]
		public string? Units { get; set; }

		public List<CalculatorInput> Inputs { get; set; }
		public List<CalculatorResult> ResultsTemplate { get; set; }

		public UnitOfCalculatorBase()
		{
			Inputs = new List<CalculatorInput>();
			ResultsTemplate = new List<CalculatorResult>();
		}

		public string? DisplayUnitFrom { get; set; }
		public string? DisplayUnitTo { get; set; }

		public UnitOf? FromUnitOf { get; set; }
		public UnitOf? ToUnitOf { get; set; }

		[Inject]
		NavigationManager NavigationManager { get; set; }

		protected override void OnParametersSet()
		{
			FromUnitOf = null;
			ToUnitOf = null;
			DisplayUnitFrom = null;
			DisplayUnitTo = null;
			Inputs = new List<CalculatorInput>();
			ResultsTemplate = new List<CalculatorResult>();

			if (string.IsNullOrWhiteSpace(Units))
			{
				NavigationManager.NavigateTo("404", false);
			}
			try
			{
				var parts = Units.Split("-to-");
				var unitFromParam = parts[0] ?? null;
				var unitToParam = parts[1] ?? null;

				if (unitFromParam == null || unitToParam == null)
				{
					NavigationManager.NavigateTo("404", false);
				}

				FromUnitOf = UnitOf.Match(unitFromParam);
				ToUnitOf = UnitOf.Match(unitToParam);

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

				string res = converted.ToString(Constants.FRONTEND_NUMBER_FORMAT);

				returnRes.Add(new(res) { EndInputGroupText = ToUnitOf.Abbreviation });
			}

			return returnRes;
		}


	}
}
