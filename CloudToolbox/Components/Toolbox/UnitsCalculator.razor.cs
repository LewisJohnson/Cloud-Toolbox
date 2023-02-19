using CloudToolbox.Calculators.Unit;
using CloudToolbox.Common.Data;
using CloudToolbox.Common.Enums.Units;
using CloudToolbox.Common.Models.Calculator;
using CloudToolbox.Services;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Toolbox
{
	public partial class UnitsCalculatorBase : ComponentBase
	{

		[Parameter] public string UriParam { get; set; }

		[Inject] public IHttpContextAccessor HttpContextAccessor { get; set; }
		[Inject] public NotFoundService NotFoundService { get; set; }

		protected List<CalculatorInput> Inputs { get; set; }
		protected List<CalculatorResult> ResultsTemplate { get; set; }
		protected string? DisplayUnitFromDesc { get; set; }
		protected string? DisplayUnitToDesc { get; set; }
		protected UnitCalculatorsEnum? FromCalc { get; set; }
		protected UnitCalculatorsEnum? ToCalc { get; set; }

		public UnitsCalculatorBase()
		{
			Inputs = new List<CalculatorInput>();
			ResultsTemplate = new List<CalculatorResult>();
		}

		protected override async Task OnParametersSetAsync()
		{
			FromCalc = null;
			ToCalc = null;

			Inputs = new List<CalculatorInput>();
			ResultsTemplate = new List<CalculatorResult>();

			string[] uriParts = UriParam.Split("-to-");

			if (uriParts.Length != 2)
			{
				NotFoundService.NotifyNotFound();
				return;
			}

			string unitFromParam = uriParts[0];
			string unitToParam = uriParts[1];

			FromCalc = UnitCalculatorsEnum.MatchFromUri(unitFromParam);
			ToCalc = UnitCalculatorsEnum.MatchFromUri(unitToParam);

			if (FromCalc == null || ToCalc == null ||
				FromCalc.UnitType != ToCalc.UnitType)
			{
				NotFoundService.NotifyNotFound();
				return;
			}

			DisplayUnitFromDesc = FromCalc.Name + (FromCalc.Abbreviation != FromCalc.Name ? $" ({FromCalc.Abbreviation})" : "");
			DisplayUnitToDesc = ToCalc.Name + (ToCalc.Abbreviation != ToCalc.Name ? $" ({ToCalc.Abbreviation})" : "");

			Inputs.Add(new("Number", typeof(string)) { EndInputGroupText = FromCalc.Abbreviation });

			ResultsTemplate.Add(new(null) { EndInputGroupText = ToCalc.Abbreviation });
		}

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{

			var returnRes = new List<CalculatorResult>();

			double? input = inputs[0].InputDouble;

			if (input != null &&
				FromCalc != null && ToCalc != null &&
				FromCalc.Unit != null && ToCalc.Unit != null)
			{
				double converted = 0;

				switch (FromCalc.UnitType)
				{
					case UnitTypes.Area:
						converted = new UnitOfAreaConverter(((UnitOfArea)FromCalc.Unit, (UnitOfArea)ToCalc.Unit)).Convert(input.Value);
						break;

					case UnitTypes.DataTransfer:
						converted = new UnitOfDataTranserConverter(((UnitOfDataTranser)FromCalc.Unit, (UnitOfDataTranser)ToCalc.Unit)).Convert(input.Value);
						break;

					case UnitTypes.Energy:
						converted = new UnitOfEnergyConverter(((UnitOfEnergy)FromCalc.Unit, (UnitOfEnergy)ToCalc.Unit)).Convert(input.Value);
						break;

					case UnitTypes.Length:
						converted = new UnitOfLengthConverter(((UnitOfLength)FromCalc.Unit, (UnitOfLength)ToCalc.Unit)).Convert(input.Value);
						break;

					case UnitTypes.Mass:
						converted = new UnitOfMassConverter(((UnitOfMass)FromCalc.Unit, (UnitOfMass)ToCalc.Unit)).Convert(input.Value);
						break;

					case UnitTypes.Speed:
						converted = new UnitOfSpeedConverter(((UnitOfSpeed)FromCalc.Unit, (UnitOfSpeed)ToCalc.Unit)).Convert(input.Value);
						break;

					case UnitTypes.Time:
						converted = new UnitOfTimeConverter(((UnitOfTime)FromCalc.Unit, (UnitOfTime)ToCalc.Unit)).Convert(input.Value);
						break;
				}

				string res = converted < 1 ? converted.ToString("0.######") : converted.ToString(Constants.FRONTEND_NUMBER_FORMAT);

				returnRes.Add(new(res) { EndInputGroupText = ToCalc.Abbreviation });
			}

			return returnRes;
		}


	}
}
