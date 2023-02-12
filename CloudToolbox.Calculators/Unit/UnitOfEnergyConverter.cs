using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Calculators.Unit
{
	public class UnitOfEnergyConverter
	{
		private (UnitOfEnergy, UnitOfEnergy) Units;

		public UnitOfEnergyConverter((UnitOfEnergy, UnitOfEnergy) units)
		{
			Units = units;
		}

		public double Convert(double val) => Units switch
		{
			(UnitOfEnergy.Joule, UnitOfEnergy.Kilojoule) => val * 1,
			(UnitOfEnergy.Joule, UnitOfEnergy.Gramcalorie) => val * 1,
			(UnitOfEnergy.Joule, UnitOfEnergy.Kilocalorie) => val * 1,
			(UnitOfEnergy.Joule, UnitOfEnergy.WattHour) => val * 1,
			(UnitOfEnergy.Joule, UnitOfEnergy.Kilowatt_Hour) => val * 1,
			(UnitOfEnergy.Joule, UnitOfEnergy.Electronvolt) => val * 1,
			(UnitOfEnergy.Joule, UnitOfEnergy.British_Thermal_Unit) => val * 1,
			(UnitOfEnergy.Joule, UnitOfEnergy.US_Therm) => val * 1,
			(UnitOfEnergy.Joule, UnitOfEnergy.Foot_Pound) => val * 1,

			(UnitOfEnergy.Kilojoule, UnitOfEnergy.Joule) => val * 1,
			(UnitOfEnergy.Kilojoule, UnitOfEnergy.Gramcalorie) => val * 1,
			(UnitOfEnergy.Kilojoule, UnitOfEnergy.Kilocalorie) => val * 1,
			(UnitOfEnergy.Kilojoule, UnitOfEnergy.WattHour) => val * 1,
			(UnitOfEnergy.Kilojoule, UnitOfEnergy.Kilowatt_Hour) => val * 1,
			(UnitOfEnergy.Kilojoule, UnitOfEnergy.Electronvolt) => val * 1,
			(UnitOfEnergy.Kilojoule, UnitOfEnergy.British_Thermal_Unit) => val * 1,
			(UnitOfEnergy.Kilojoule, UnitOfEnergy.US_Therm) => val * 1,
			(UnitOfEnergy.Kilojoule, UnitOfEnergy.Foot_Pound) => val * 1,

			(UnitOfEnergy.Gramcalorie, UnitOfEnergy.Joule) => val * 1,
			(UnitOfEnergy.Gramcalorie, UnitOfEnergy.Kilojoule) => val * 1,
			(UnitOfEnergy.Gramcalorie, UnitOfEnergy.Kilocalorie) => val * 1,
			(UnitOfEnergy.Gramcalorie, UnitOfEnergy.WattHour) => val * 1,
			(UnitOfEnergy.Gramcalorie, UnitOfEnergy.Kilowatt_Hour) => val * 1,
			(UnitOfEnergy.Gramcalorie, UnitOfEnergy.Electronvolt) => val * 1,
			(UnitOfEnergy.Gramcalorie, UnitOfEnergy.British_Thermal_Unit) => val * 1,
			(UnitOfEnergy.Gramcalorie, UnitOfEnergy.US_Therm) => val * 1,
			(UnitOfEnergy.Gramcalorie, UnitOfEnergy.Foot_Pound) => val * 1,

			(UnitOfEnergy.Kilocalorie, UnitOfEnergy.Joule) => val * 1,
			(UnitOfEnergy.Kilocalorie, UnitOfEnergy.Kilojoule) => val * 1,
			(UnitOfEnergy.Kilocalorie, UnitOfEnergy.Gramcalorie) => val * 1,
			(UnitOfEnergy.Kilocalorie, UnitOfEnergy.WattHour) => val * 1,
			(UnitOfEnergy.Kilocalorie, UnitOfEnergy.Kilowatt_Hour) => val * 1,
			(UnitOfEnergy.Kilocalorie, UnitOfEnergy.Electronvolt) => val * 1,
			(UnitOfEnergy.Kilocalorie, UnitOfEnergy.British_Thermal_Unit) => val * 1,
			(UnitOfEnergy.Kilocalorie, UnitOfEnergy.US_Therm) => val * 1,
			(UnitOfEnergy.Kilocalorie, UnitOfEnergy.Foot_Pound) => val * 1,

			(UnitOfEnergy.WattHour, UnitOfEnergy.Joule) => val * 1,
			(UnitOfEnergy.WattHour, UnitOfEnergy.Kilojoule) => val * 1,
			(UnitOfEnergy.WattHour, UnitOfEnergy.Gramcalorie) => val * 1,
			(UnitOfEnergy.WattHour, UnitOfEnergy.Kilocalorie) => val * 1,
			(UnitOfEnergy.WattHour, UnitOfEnergy.Kilowatt_Hour) => val * 1,
			(UnitOfEnergy.WattHour, UnitOfEnergy.Electronvolt) => val * 1,
			(UnitOfEnergy.WattHour, UnitOfEnergy.British_Thermal_Unit) => val * 1,
			(UnitOfEnergy.WattHour, UnitOfEnergy.US_Therm) => val * 1,
			(UnitOfEnergy.WattHour, UnitOfEnergy.Foot_Pound) => val * 1,

			(UnitOfEnergy.Kilowatt_Hour, UnitOfEnergy.Joule) => val * 1,
			(UnitOfEnergy.Kilowatt_Hour, UnitOfEnergy.Kilojoule) => val * 1,
			(UnitOfEnergy.Kilowatt_Hour, UnitOfEnergy.Gramcalorie) => val * 1,
			(UnitOfEnergy.Kilowatt_Hour, UnitOfEnergy.Kilocalorie) => val * 1,
			(UnitOfEnergy.Kilowatt_Hour, UnitOfEnergy.WattHour) => val * 1,
			(UnitOfEnergy.Kilowatt_Hour, UnitOfEnergy.Electronvolt) => val * 1,
			(UnitOfEnergy.Kilowatt_Hour, UnitOfEnergy.British_Thermal_Unit) => val * 1,
			(UnitOfEnergy.Kilowatt_Hour, UnitOfEnergy.US_Therm) => val * 1,
			(UnitOfEnergy.Kilowatt_Hour, UnitOfEnergy.Foot_Pound) => val * 1,

			(UnitOfEnergy.Electronvolt, UnitOfEnergy.Joule) => val * 1,
			(UnitOfEnergy.Electronvolt, UnitOfEnergy.Kilojoule) => val * 1,
			(UnitOfEnergy.Electronvolt, UnitOfEnergy.Gramcalorie) => val * 1,
			(UnitOfEnergy.Electronvolt, UnitOfEnergy.Kilocalorie) => val * 1,
			(UnitOfEnergy.Electronvolt, UnitOfEnergy.WattHour) => val * 1,
			(UnitOfEnergy.Electronvolt, UnitOfEnergy.Kilowatt_Hour) => val * 1,
			(UnitOfEnergy.Electronvolt, UnitOfEnergy.British_Thermal_Unit) => val * 1,
			(UnitOfEnergy.Electronvolt, UnitOfEnergy.US_Therm) => val * 1,
			(UnitOfEnergy.Electronvolt, UnitOfEnergy.Foot_Pound) => val * 1,

			(UnitOfEnergy.British_Thermal_Unit, UnitOfEnergy.Joule) => val * 1,
			(UnitOfEnergy.British_Thermal_Unit, UnitOfEnergy.Kilojoule) => val * 1,
			(UnitOfEnergy.British_Thermal_Unit, UnitOfEnergy.Gramcalorie) => val * 1,
			(UnitOfEnergy.British_Thermal_Unit, UnitOfEnergy.Kilocalorie) => val * 1,
			(UnitOfEnergy.British_Thermal_Unit, UnitOfEnergy.WattHour) => val * 1,
			(UnitOfEnergy.British_Thermal_Unit, UnitOfEnergy.Kilowatt_Hour) => val * 1,
			(UnitOfEnergy.British_Thermal_Unit, UnitOfEnergy.Electronvolt) => val * 1,
			(UnitOfEnergy.British_Thermal_Unit, UnitOfEnergy.US_Therm) => val * 1,
			(UnitOfEnergy.British_Thermal_Unit, UnitOfEnergy.Foot_Pound) => val * 1,

			(UnitOfEnergy.US_Therm, UnitOfEnergy.Joule) => val * 1,
			(UnitOfEnergy.US_Therm, UnitOfEnergy.Kilojoule) => val * 1,
			(UnitOfEnergy.US_Therm, UnitOfEnergy.Gramcalorie) => val * 1,
			(UnitOfEnergy.US_Therm, UnitOfEnergy.Kilocalorie) => val * 1,
			(UnitOfEnergy.US_Therm, UnitOfEnergy.WattHour) => val * 1,
			(UnitOfEnergy.US_Therm, UnitOfEnergy.Kilowatt_Hour) => val * 1,
			(UnitOfEnergy.US_Therm, UnitOfEnergy.Electronvolt) => val * 1,
			(UnitOfEnergy.US_Therm, UnitOfEnergy.British_Thermal_Unit) => val * 1,
			(UnitOfEnergy.US_Therm, UnitOfEnergy.Foot_Pound) => val * 1,

			(UnitOfEnergy.Foot_Pound, UnitOfEnergy.Joule) => val * 1,
			(UnitOfEnergy.Foot_Pound, UnitOfEnergy.Kilojoule) => val * 1,
			(UnitOfEnergy.Foot_Pound, UnitOfEnergy.Gramcalorie) => val * 1,
			(UnitOfEnergy.Foot_Pound, UnitOfEnergy.Kilocalorie) => val * 1,
			(UnitOfEnergy.Foot_Pound, UnitOfEnergy.WattHour) => val * 1,
			(UnitOfEnergy.Foot_Pound, UnitOfEnergy.Kilowatt_Hour) => val * 1,
			(UnitOfEnergy.Foot_Pound, UnitOfEnergy.Electronvolt) => val * 1,
			(UnitOfEnergy.Foot_Pound, UnitOfEnergy.British_Thermal_Unit) => val * 1,
			(UnitOfEnergy.Foot_Pound, UnitOfEnergy.US_Therm) => val * 1,
			_ => 1,
		};
	}
}
