﻿using System.Text.RegularExpressions;
using CloudToolbox.Common.Data;
using CloudToolbox.Common.Types;

namespace CloudToolbox.Common.Models.Calculator
{
	public class CalculatorInput
	{
		public CalculatorInput(string id, Type type)
		{
			Id = id;
			Type = type;
			InputBool = false;
			UseLargeInput = false;
		}

		public string Id { get; }
		public Type Type { get; }

		#region Inputs
		public string? InputString { get; set; }
		public double? InputDouble
		{
			set
			{
				InputString = value.ToString();
			}
			get
			{
				if (string.IsNullOrEmpty(InputString))
				{
					return null;
				}

				InputString = Regex.Replace(InputString, "[^0-9\\.]", "");
				return double.TryParse(InputString, out double num) ? num : null;
			}
		}

		public DateTime? InputDateTime { get; set; }
		public TimeOnly? InputTimeOnly { get; set; }
		public bool InputBool { get; set; }
		#endregion

		/// <summary>
		/// If a larger input method is available, use it. e.g. <textarea> instead of <input \type="text">
		/// </summary>
		public bool UseLargeInput { get; set; }

		public string? Label;
		public string? StartInputGroupText { get; set; }
		public string? EndInputGroupText { get; set; }

		public bool IsValid => (HasValue);
		public string InvalidCssClass => "is-invalid";
		public bool IsStandardInput
		{
			get
			{
				return Type != typeof(Checkbox) &&
				Type != typeof(bool);
			}
		}
		private bool HasValue
		{
			get
			{
				if (Type == typeof(string))
				{
					return !string.IsNullOrWhiteSpace(InputString);
				}

				if (Type == typeof(Checkbox) || Type == typeof(bool))
				{
					return true;
				}

				if (Type == typeof(double))
				{
					return InputDouble.HasValue;
				}

				if (Type == typeof(DateTime))
				{
					return InputDateTime.HasValue;
				}

				if (Type == typeof(TimeOnly))
				{
					return InputTimeOnly.HasValue;
				}

				return false;
			}
		}

	}
}
