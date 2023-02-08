using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Models.Calculator;
using CloudToolbox.Common.Types;
using Microsoft.AspNetCore.Components;

namespace CloudToolbox.Components.Shared
{
	public partial class SimpleCalculatorBase : ComponentBase
	{
		public List<CalculatorResult> Results { get; set; }

		[Parameter]
		public List<CalculatorInput> Inputs { get; set; }

		[Parameter]
		public List<CalculatorResult> ResultsTemplate { get; set; }

		[Parameter]
		public Func<List<CalculatorInput>, Task<List<CalculatorResult>>> OnChangeEvent { get; set; }

		public SimpleCalculatorBase()
		{
			Inputs = new List<CalculatorInput>();
			Results = new List<CalculatorResult>();
			ResultsTemplate = new List<CalculatorResult>();
		}

		protected override void OnInitialized()
		{
			SetResultTemplate();
		}

		protected async Task OnChange()
		{
			if (Validate())
			{
				Results = await OnChangeEvent(Inputs);
			}
		}

		private bool Validate()
		{
			Results.Clear();

			bool isValid = Inputs.All(x => x.IsValid);

			if (!isValid)
			{
				SetResultTemplate();
			}

			return isValid;
		}

		private void SetResultTemplate()
		{
			Results.Clear();

			foreach (var res in ResultsTemplate)
			{
				Results.Add(new CalculatorResult(null)
				{
					StartInputGroupText = res.StartInputGroupText,
					EndInputGroupText = res.EndInputGroupText
				});
			}
		}
	}
}
