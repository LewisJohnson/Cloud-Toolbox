﻿using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Models.Calculator;
using CloudToolbox.Common.Types;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;

namespace CloudToolbox.Components.Shared
{
	public partial class SimpleCalculatorBase : ComponentBase
	{
		public bool IsValidating { get; set; }
		public List<CalculatorResult> Results { get; set; }

		[Parameter]
		public List<CalculatorInput> Inputs { get; set; }

		[Parameter]
		public int StartInputGroupWidth { get; set; }

		[Parameter]
		public int EndInputGroupWidth { get; set; }

		[Parameter]
		public int ResultStartInputGroupWidth { get; set; }

		[Parameter]
		public int ResultEndInputGroupWidth { get; set; }

		[Parameter]
		public List<CalculatorResult> ResultsTemplate { get; set; }

		[Parameter]
		public Func<List<CalculatorInput>, Task<List<CalculatorResult>>> OnChangeEvent { get; set; }

		public SimpleCalculatorBase()
		{
			Inputs = new List<CalculatorInput>();
			Results = new List<CalculatorResult>();
			ResultsTemplate = new List<CalculatorResult>();
			StartInputGroupWidth = 100;
			EndInputGroupWidth = 100;
			ResultStartInputGroupWidth = 120;
			ResultEndInputGroupWidth = 120;
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
			IsValidating = true;
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
			Results = ResultsTemplate.ToList();
		}
	}
}
