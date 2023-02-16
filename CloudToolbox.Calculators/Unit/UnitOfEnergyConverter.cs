using System.Drawing;
using CloudToolbox.Calculators.Interfaces;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Calculators.Unit
{
	public class UnitOfEnergyConverter : IConverter<double>
	{
		private (UnitOfEnergy, UnitOfEnergy) Units;

		public UnitOfEnergyConverter((UnitOfEnergy, UnitOfEnergy) units)
		{
			Units = units;
		}

		public double Convert(double val) => Units switch
		{
			(UnitOfEnergy.Joule, UnitOfEnergy.Kilojoule) => val / 1000,
			(UnitOfEnergy.Joule, UnitOfEnergy.Gramcalorie) => val / 4.184,
			(UnitOfEnergy.Joule, UnitOfEnergy.Kilocalorie) => val / 4184,
			(UnitOfEnergy.Joule, UnitOfEnergy.Watt_Hour) => val / 3600,
			(UnitOfEnergy.Joule, UnitOfEnergy.Kilowatt_Hour) => val / 3.6e+6,
			(UnitOfEnergy.Joule, UnitOfEnergy.Electronvolt) => val * 6.242e+18,
			(UnitOfEnergy.Joule, UnitOfEnergy.British_Thermal_Unit) => val / 1055,
			(UnitOfEnergy.Joule, UnitOfEnergy.US_Therm) => val / 1.055e+8,
			(UnitOfEnergy.Joule, UnitOfEnergy.Foot_Pound) => val / 1.356,

			(UnitOfEnergy.Kilojoule, UnitOfEnergy.Joule) => val * 1000,
			(UnitOfEnergy.Kilojoule, UnitOfEnergy.Gramcalorie) => val * 239,
			(UnitOfEnergy.Kilojoule, UnitOfEnergy.Kilocalorie) => val / 4.184,
			(UnitOfEnergy.Kilojoule, UnitOfEnergy.Watt_Hour) => val / 3.6,
			(UnitOfEnergy.Kilojoule, UnitOfEnergy.Kilowatt_Hour) => val / 3600,
			(UnitOfEnergy.Kilojoule, UnitOfEnergy.Electronvolt) => val * 6.242e+21,
			(UnitOfEnergy.Kilojoule, UnitOfEnergy.British_Thermal_Unit) => val / 1.055,
			(UnitOfEnergy.Kilojoule, UnitOfEnergy.US_Therm) => val / 105500,
			(UnitOfEnergy.Kilojoule, UnitOfEnergy.Foot_Pound) => val * 737.6,

			(UnitOfEnergy.Gramcalorie, UnitOfEnergy.Joule) => val * 4.184,
			(UnitOfEnergy.Gramcalorie, UnitOfEnergy.Kilojoule) => val / 239,
			(UnitOfEnergy.Gramcalorie, UnitOfEnergy.Kilocalorie) => val / 1000,
			(UnitOfEnergy.Gramcalorie, UnitOfEnergy.Watt_Hour) => val / 860.4,
			(UnitOfEnergy.Gramcalorie, UnitOfEnergy.Kilowatt_Hour) => val / 860400,
			(UnitOfEnergy.Gramcalorie, UnitOfEnergy.Electronvolt) => val * 2.611e+19,
			(UnitOfEnergy.Gramcalorie, UnitOfEnergy.British_Thermal_Unit) => val / 252.2,
			(UnitOfEnergy.Gramcalorie, UnitOfEnergy.US_Therm) => val / 2.521e+7,
			(UnitOfEnergy.Gramcalorie, UnitOfEnergy.Foot_Pound) => val * 3.086,

			(UnitOfEnergy.Kilocalorie, UnitOfEnergy.Joule) => val * 4184,
			(UnitOfEnergy.Kilocalorie, UnitOfEnergy.Kilojoule) => val * 4.184,
			(UnitOfEnergy.Kilocalorie, UnitOfEnergy.Gramcalorie) => val * 1000,
			(UnitOfEnergy.Kilocalorie, UnitOfEnergy.Watt_Hour) => val * 1.162,
			(UnitOfEnergy.Kilocalorie, UnitOfEnergy.Kilowatt_Hour) => val / 860.4,
			(UnitOfEnergy.Kilocalorie, UnitOfEnergy.Electronvolt) => val * 2.611e+22,
			(UnitOfEnergy.Kilocalorie, UnitOfEnergy.British_Thermal_Unit) => val * 3.966,
			(UnitOfEnergy.Kilocalorie, UnitOfEnergy.US_Therm) => val / 25210,
			(UnitOfEnergy.Kilocalorie, UnitOfEnergy.Foot_Pound) => val * 3086,

			(UnitOfEnergy.Watt_Hour, UnitOfEnergy.Joule) => val * 3600,
			(UnitOfEnergy.Watt_Hour, UnitOfEnergy.Kilojoule) => val * 3.6,
			(UnitOfEnergy.Watt_Hour, UnitOfEnergy.Gramcalorie) => val * 860.4,
			(UnitOfEnergy.Watt_Hour, UnitOfEnergy.Kilocalorie) => val / 1.162,
			(UnitOfEnergy.Watt_Hour, UnitOfEnergy.Kilowatt_Hour) => val / 1000,
			(UnitOfEnergy.Watt_Hour, UnitOfEnergy.Electronvolt) => val * 2.247e+22,
			(UnitOfEnergy.Watt_Hour, UnitOfEnergy.British_Thermal_Unit) => val * 3.412,
			(UnitOfEnergy.Watt_Hour, UnitOfEnergy.US_Therm) => val / 29300,
			(UnitOfEnergy.Watt_Hour, UnitOfEnergy.Foot_Pound) => val * 2655,

			(UnitOfEnergy.Kilowatt_Hour, UnitOfEnergy.Joule) => val * 3.6e+6,
			(UnitOfEnergy.Kilowatt_Hour, UnitOfEnergy.Kilojoule) => val * 3600,
			(UnitOfEnergy.Kilowatt_Hour, UnitOfEnergy.Gramcalorie) => val * 860400,
			(UnitOfEnergy.Kilowatt_Hour, UnitOfEnergy.Kilocalorie) => val * 860.4,
			(UnitOfEnergy.Kilowatt_Hour, UnitOfEnergy.Watt_Hour) => val * 1000,
			(UnitOfEnergy.Kilowatt_Hour, UnitOfEnergy.Electronvolt) => val * 2.247e+25,
			(UnitOfEnergy.Kilowatt_Hour, UnitOfEnergy.British_Thermal_Unit) => val * 3412,
			(UnitOfEnergy.Kilowatt_Hour, UnitOfEnergy.US_Therm) => val / 29.3,
			(UnitOfEnergy.Kilowatt_Hour, UnitOfEnergy.Foot_Pound) => val * 2.655e+6,

			(UnitOfEnergy.Electronvolt, UnitOfEnergy.Joule) => val / 6.242e+18,
			(UnitOfEnergy.Electronvolt, UnitOfEnergy.Kilojoule) => val / 6.242e+21,
			(UnitOfEnergy.Electronvolt, UnitOfEnergy.Gramcalorie) => val / 2.611e+19,
			(UnitOfEnergy.Electronvolt, UnitOfEnergy.Kilocalorie) => val / 2.611e+22,
			(UnitOfEnergy.Electronvolt, UnitOfEnergy.Watt_Hour) => val / 2.247e+22,
			(UnitOfEnergy.Electronvolt, UnitOfEnergy.Kilowatt_Hour) => val / 2.247e+25,
			(UnitOfEnergy.Electronvolt, UnitOfEnergy.British_Thermal_Unit) => val / 6.585e+21,
			(UnitOfEnergy.Electronvolt, UnitOfEnergy.US_Therm) => val / 6.584e+26,
			(UnitOfEnergy.Electronvolt, UnitOfEnergy.Foot_Pound) => val / 8.462e+18,

			(UnitOfEnergy.British_Thermal_Unit, UnitOfEnergy.Joule) => val * 1055,
			(UnitOfEnergy.British_Thermal_Unit, UnitOfEnergy.Kilojoule) => val * 1.055,
			(UnitOfEnergy.British_Thermal_Unit, UnitOfEnergy.Gramcalorie) => val * 252.2,
			(UnitOfEnergy.British_Thermal_Unit, UnitOfEnergy.Kilocalorie) => val / 3.966,
			(UnitOfEnergy.British_Thermal_Unit, UnitOfEnergy.Watt_Hour) => val / 3.412,
			(UnitOfEnergy.British_Thermal_Unit, UnitOfEnergy.Kilowatt_Hour) => val / 3412,
			(UnitOfEnergy.British_Thermal_Unit, UnitOfEnergy.Electronvolt) => val * 6.585e+21,
			(UnitOfEnergy.British_Thermal_Unit, UnitOfEnergy.US_Therm) => val / 99980,
			(UnitOfEnergy.British_Thermal_Unit, UnitOfEnergy.Foot_Pound) => val * 778.2,

			(UnitOfEnergy.US_Therm, UnitOfEnergy.Joule) => val * 1.055e+8,
			(UnitOfEnergy.US_Therm, UnitOfEnergy.Kilojoule) => val * 105500,
			(UnitOfEnergy.US_Therm, UnitOfEnergy.Gramcalorie) => val * 2.521e+7,
			(UnitOfEnergy.US_Therm, UnitOfEnergy.Kilocalorie) => val * 25210,
			(UnitOfEnergy.US_Therm, UnitOfEnergy.Watt_Hour) => val * 29300,
			(UnitOfEnergy.US_Therm, UnitOfEnergy.Kilowatt_Hour) => val * 29.3,
			(UnitOfEnergy.US_Therm, UnitOfEnergy.Electronvolt) => val * 6.584e+26,
			(UnitOfEnergy.US_Therm, UnitOfEnergy.British_Thermal_Unit) => val * 99980,
			(UnitOfEnergy.US_Therm, UnitOfEnergy.Foot_Pound) => val * 7.78e+7,

			(UnitOfEnergy.Foot_Pound, UnitOfEnergy.Joule) => val * 1.356,
			(UnitOfEnergy.Foot_Pound, UnitOfEnergy.Kilojoule) => val / 737.6,
			(UnitOfEnergy.Foot_Pound, UnitOfEnergy.Gramcalorie) => val / 3.086,
			(UnitOfEnergy.Foot_Pound, UnitOfEnergy.Kilocalorie) => val / 3086,
			(UnitOfEnergy.Foot_Pound, UnitOfEnergy.Watt_Hour) => val / 2655,
			(UnitOfEnergy.Foot_Pound, UnitOfEnergy.Kilowatt_Hour) => val / 2.655e+6,
			(UnitOfEnergy.Foot_Pound, UnitOfEnergy.Electronvolt) => val * 8.462e+18,
			(UnitOfEnergy.Foot_Pound, UnitOfEnergy.British_Thermal_Unit) => val / 778.2,
			(UnitOfEnergy.Foot_Pound, UnitOfEnergy.US_Therm) => val / 7.78e+7,
			_ => 1,
		};
	}
}
