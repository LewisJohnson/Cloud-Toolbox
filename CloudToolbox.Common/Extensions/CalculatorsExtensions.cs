using CloudToolbox.Common.Data;
using CloudToolbox.Common.Enums;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Common.Extensions
{
	public static class CalculatorsExtensions
	{
		// TextCalculatorsEnum
		public static string GetCalculatorHeaderTitle(this TextCalculatorsEnum? calc) => calc == null ? string.Empty : $"To {calc.Name}";
		public static string GetMetaPageTitle(this TextCalculatorsEnum? calc) => calc == null ? string.Empty : $"Convert text to {calc.Name}";
		public static string GetMetaDescription(this TextCalculatorsEnum? calc) => calc == null ? string.Empty : $"Convert text to {calc.Name} in the cloud for free!";


		// DeveloperCalculatorsEnum
		public static string GetCalculatorHeaderTitle(this DeveloperCalculatorsEnum? calc, DeveleoperCalculatorDirection dir) => calc == null ? string.Empty : $"{dir} {calc.Name}";
		public static string GetMetaPageTitle(this DeveloperCalculatorsEnum? calc, DeveleoperCalculatorDirection dir)
		{
			if (calc == null)
			{
				return string.Empty;
			}

			return dir == DeveleoperCalculatorDirection.From ? 
				$"Convert {calc.Name} to text" : 
				$"Convert text to {calc.Name}";
		}

		public static string GetMetaDescription(this DeveloperCalculatorsEnum? calc, DeveleoperCalculatorDirection dir)
		{
			if (calc == null)
			{
				return string.Empty;
			}

			return dir == DeveleoperCalculatorDirection.From
				? $"Convert {calc.Name} to text in the cloud for free!"
				: $"Convert text to {calc.Name} in the cloud for free!";

		}

		// UnitCalculatorsEnum
		public static string GetCalculatorHeaderTitle(this UnitCalculatorsEnum? fromCalc, UnitCalculatorsEnum? toCalc)
		{
			if (fromCalc == null || toCalc == null)
			{
				return string.Empty;
			}

			return fromCalc.Name + " to " + toCalc.Name;
		}

		public static string GetMetaPageTitle(this UnitCalculatorsEnum? fromCalc, UnitCalculatorsEnum? toCalc)
		{
			if (fromCalc == null || toCalc == null)
			{
				return string.Empty;
			}


			return $"Convert {fromCalc.Name} {fromCalc.AbbreviationInBrackets} to {toCalc.Name}";
		}

		public static string GetMetaDescription(this UnitCalculatorsEnum? fromCalc, UnitCalculatorsEnum? toCalc)
		{
			if (fromCalc == null || toCalc == null)
			{
				return string.Empty;
			}

			return $"Convert {fromCalc.Name} {fromCalc.AbbreviationInBrackets} to {toCalc.Name} {toCalc.AbbreviationInBrackets} in the cloud for free!";
		}
	}
}

