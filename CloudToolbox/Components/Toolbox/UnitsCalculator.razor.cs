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
		protected string? DisplayUnitFrom { get; set; }
		protected string? DisplayUnitFromDesc { get; set; }
		protected string? DisplayUnitTo { get; set; }
		protected string? DisplayUnitToDesc { get; set; }
		protected UnitCalculatorsEnum? FromUnitOf { get; set; }
		protected UnitCalculatorsEnum? ToUnitOf { get; set; }

		public UnitsCalculatorBase()
		{
			Inputs = new List<CalculatorInput>();
			ResultsTemplate = new List<CalculatorResult>();
		}

		protected override async Task OnParametersSetAsync()
		{
			FromUnitOf = null;
			ToUnitOf = null;
			DisplayUnitFrom = string.Empty;
			DisplayUnitTo = string.Empty;

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

			FromUnitOf = UnitCalculatorsEnum.MatchFromUri(unitFromParam);
			ToUnitOf = UnitCalculatorsEnum.MatchFromUri(unitToParam);

			if (FromUnitOf == null || ToUnitOf == null ||
				FromUnitOf.UnitType != ToUnitOf.UnitType)
			{
				NotFoundService.NotifyNotFound();
				return;
			}

			DisplayUnitFrom = FromUnitOf.Name;
			DisplayUnitTo = ToUnitOf.Name;
			DisplayUnitFromDesc = FromUnitOf.Name + (FromUnitOf.Abbreviation != FromUnitOf.Name ? $" ({FromUnitOf.Abbreviation})" : "");
			DisplayUnitToDesc = ToUnitOf.Name + (ToUnitOf.Abbreviation != ToUnitOf.Name ? $" ({ToUnitOf.Abbreviation})" : "");

			Inputs.Add(new("Number", typeof(string)) { EndInputGroupText = FromUnitOf.Abbreviation });

			ResultsTemplate.Add(new(null) { EndInputGroupText = ToUnitOf.Abbreviation });
		}

		protected async Task<List<CalculatorResult>> OnChange(List<CalculatorInput> inputs)
		{

			var returnRes = new List<CalculatorResult>();

			double? input = inputs[0].InputDouble;

			if (input != null &&
				FromUnitOf != null && ToUnitOf != null &&
				FromUnitOf.Unit != null && ToUnitOf.Unit != null)
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
