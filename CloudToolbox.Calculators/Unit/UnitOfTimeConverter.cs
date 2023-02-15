﻿using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Calculators.Unit
{
	public class UnitOfTimeConverter
	{
		private (UnitOfTime, UnitOfTime) Units;

		public UnitOfTimeConverter((UnitOfTime, UnitOfTime) units)
		{
			Units = units;
		}

		public double Convert(double val) => Units switch
		{
			(UnitOfTime.Nanosecond, UnitOfTime.Microsecond) => val / 1000,
			(UnitOfTime.Nanosecond, UnitOfTime.Millisecond) => val / 1e+6,
			(UnitOfTime.Nanosecond, UnitOfTime.Second) => val / 1e+9,
			(UnitOfTime.Nanosecond, UnitOfTime.Minute) => val / 6e+10,
			(UnitOfTime.Nanosecond, UnitOfTime.Hour) => val / 3.6e+12,
			(UnitOfTime.Nanosecond, UnitOfTime.Day) => val / 8.64e+13,
			(UnitOfTime.Nanosecond, UnitOfTime.Week) => val / 6.048e+14,
			(UnitOfTime.Nanosecond, UnitOfTime.Month) => val / 2.628e+15,
			(UnitOfTime.Nanosecond, UnitOfTime.Year) => val / 3.154e+16,
			(UnitOfTime.Nanosecond, UnitOfTime.Decade) => val / 3.154e+17,
			(UnitOfTime.Nanosecond, UnitOfTime.Century) => val / 3.154e+18,

			(UnitOfTime.Microsecond, UnitOfTime.Nanosecond) => val * 1000,
			(UnitOfTime.Microsecond, UnitOfTime.Millisecond) => val / 1000,
			(UnitOfTime.Microsecond, UnitOfTime.Second) => val / 1e+6,
			(UnitOfTime.Microsecond, UnitOfTime.Minute) => val / 6e+7,
			(UnitOfTime.Microsecond, UnitOfTime.Hour) => val / 3.6e+9,
			(UnitOfTime.Microsecond, UnitOfTime.Day) => val / 8.64e+10,
			(UnitOfTime.Microsecond, UnitOfTime.Week) => val / 6.048e+11,
			(UnitOfTime.Microsecond, UnitOfTime.Month) => val / 2.628e+12,
			(UnitOfTime.Microsecond, UnitOfTime.Year) => val / 3.154e+13,
			(UnitOfTime.Microsecond, UnitOfTime.Decade) => val / 3.154e+14,
			(UnitOfTime.Microsecond, UnitOfTime.Century) => val / 3.154e+15,

			(UnitOfTime.Millisecond, UnitOfTime.Nanosecond) => val * 1e+6,
			(UnitOfTime.Millisecond, UnitOfTime.Microsecond) => val * 1000,
			(UnitOfTime.Millisecond, UnitOfTime.Second) => val / 1000,
			(UnitOfTime.Millisecond, UnitOfTime.Minute) => val / 60000,
			(UnitOfTime.Millisecond, UnitOfTime.Hour) => val / 3.6e+6,
			(UnitOfTime.Millisecond, UnitOfTime.Day) => val / 8.64e+7,
			(UnitOfTime.Millisecond, UnitOfTime.Week) => val / 6.048e+8,
			(UnitOfTime.Millisecond, UnitOfTime.Month) => val / 2.628e+9,
			(UnitOfTime.Millisecond, UnitOfTime.Year) => val / 3.154e+10,
			(UnitOfTime.Millisecond, UnitOfTime.Decade) => val / 3.154e+11,
			(UnitOfTime.Millisecond, UnitOfTime.Century) => val / 3.154e+12,

			(UnitOfTime.Second, UnitOfTime.Nanosecond) => val * 1e+9,
			(UnitOfTime.Second, UnitOfTime.Microsecond) => val * 1e+6,
			(UnitOfTime.Second, UnitOfTime.Millisecond) => val * 1000,
			(UnitOfTime.Second, UnitOfTime.Minute) => val / 60,
			(UnitOfTime.Second, UnitOfTime.Hour) => val / 3600,
			(UnitOfTime.Second, UnitOfTime.Day) => val / 86400,
			(UnitOfTime.Second, UnitOfTime.Week) => val / 604800,
			(UnitOfTime.Second, UnitOfTime.Month) => val / 2.628e+6,
			(UnitOfTime.Second, UnitOfTime.Year) => val / 3.154e+7,
			(UnitOfTime.Second, UnitOfTime.Decade) => val / 3.154e+8,
			(UnitOfTime.Second, UnitOfTime.Century) => val / 3.154e+9,

			(UnitOfTime.Minute, UnitOfTime.Nanosecond) => val * 6e+10,
			(UnitOfTime.Minute, UnitOfTime.Microsecond) => val * 6e+7,
			(UnitOfTime.Minute, UnitOfTime.Millisecond) => val * 60000,
			(UnitOfTime.Minute, UnitOfTime.Second) => val * 60,
			(UnitOfTime.Minute, UnitOfTime.Hour) => val / 60,
			(UnitOfTime.Minute, UnitOfTime.Day) => val / 1440,
			(UnitOfTime.Minute, UnitOfTime.Week) => val / 10080,
			(UnitOfTime.Minute, UnitOfTime.Month) => val / 43800,
			(UnitOfTime.Minute, UnitOfTime.Year) => val / 525600,
			(UnitOfTime.Minute, UnitOfTime.Decade) => val / 5.256e+6,
			(UnitOfTime.Minute, UnitOfTime.Century) => val / 5.256e+7,

			(UnitOfTime.Hour, UnitOfTime.Nanosecond) => val * 3.6e+12,
			(UnitOfTime.Hour, UnitOfTime.Microsecond) => val * 3.6e+9,
			(UnitOfTime.Hour, UnitOfTime.Millisecond) => val * 3.6e+6,
			(UnitOfTime.Hour, UnitOfTime.Second) => val * 3600,
			(UnitOfTime.Hour, UnitOfTime.Minute) => val * 60,
			(UnitOfTime.Hour, UnitOfTime.Day) => val / 24,
			(UnitOfTime.Hour, UnitOfTime.Week) => val / 168,
			(UnitOfTime.Hour, UnitOfTime.Month) => val / 730,
			(UnitOfTime.Hour, UnitOfTime.Year) => val / 8760,
			(UnitOfTime.Hour, UnitOfTime.Decade) => val / 87600,
			(UnitOfTime.Hour, UnitOfTime.Century) => val / 876000,

			(UnitOfTime.Day, UnitOfTime.Nanosecond) => val * 8.64e+13,
			(UnitOfTime.Day, UnitOfTime.Microsecond) => val * 8.64e+10,
			(UnitOfTime.Day, UnitOfTime.Millisecond) => val * 8.64e+7,
			(UnitOfTime.Day, UnitOfTime.Second) => val * 86400,
			(UnitOfTime.Day, UnitOfTime.Minute) => val * 1440,
			(UnitOfTime.Day, UnitOfTime.Hour) => val * 24,
			(UnitOfTime.Day, UnitOfTime.Week) => val / 7,
			(UnitOfTime.Day, UnitOfTime.Month) => val / 30.417,
			(UnitOfTime.Day, UnitOfTime.Year) => val / 365,
			(UnitOfTime.Day, UnitOfTime.Decade) => val / 3650,
			(UnitOfTime.Day, UnitOfTime.Century) => val / 36500,

			(UnitOfTime.Week, UnitOfTime.Nanosecond) => val * 6.048e+14,
			(UnitOfTime.Week, UnitOfTime.Microsecond) => val * 6.048e+11,
			(UnitOfTime.Week, UnitOfTime.Millisecond) => val * 6.048e+8,
			(UnitOfTime.Week, UnitOfTime.Second) => val * 604800,
			(UnitOfTime.Week, UnitOfTime.Minute) => val * 10080,
			(UnitOfTime.Week, UnitOfTime.Hour) => val * 168,
			(UnitOfTime.Week, UnitOfTime.Day) => val * 7,
			(UnitOfTime.Week, UnitOfTime.Month) => val / 4.345,
			(UnitOfTime.Week, UnitOfTime.Year) => val / 52.143,
			(UnitOfTime.Week, UnitOfTime.Decade) => val / 521.4,
			(UnitOfTime.Week, UnitOfTime.Century) => val / 5214,

			(UnitOfTime.Month, UnitOfTime.Nanosecond) => val * 2.628e+15,
			(UnitOfTime.Month, UnitOfTime.Microsecond) => val * 2.628e+12,
			(UnitOfTime.Month, UnitOfTime.Millisecond) => val * 2.628e+9,
			(UnitOfTime.Month, UnitOfTime.Second) => val * 2.628e+6,
			(UnitOfTime.Month, UnitOfTime.Minute) => val * 43800,
			(UnitOfTime.Month, UnitOfTime.Hour) => val * 730,
			(UnitOfTime.Month, UnitOfTime.Day) => val * 30.417,
			(UnitOfTime.Month, UnitOfTime.Week) => val * 4.345,
			(UnitOfTime.Month, UnitOfTime.Year) => val / 12,
			(UnitOfTime.Month, UnitOfTime.Decade) => val / 120,
			(UnitOfTime.Month, UnitOfTime.Century) => val / 1200,

			(UnitOfTime.Year, UnitOfTime.Nanosecond) => val * 3.154e+16,
			(UnitOfTime.Year, UnitOfTime.Microsecond) => val * 3.154e+13,
			(UnitOfTime.Year, UnitOfTime.Millisecond) => val * 3.154e+10,
			(UnitOfTime.Year, UnitOfTime.Second) => val * 3.154e+7,
			(UnitOfTime.Year, UnitOfTime.Minute) => val * 525600,
			(UnitOfTime.Year, UnitOfTime.Hour) => val * 8760,
			(UnitOfTime.Year, UnitOfTime.Day) => val * 365,
			(UnitOfTime.Year, UnitOfTime.Week) => val * 52.143,
			(UnitOfTime.Year, UnitOfTime.Month) => val * 12,
			(UnitOfTime.Year, UnitOfTime.Decade) => val / 10,
			(UnitOfTime.Year, UnitOfTime.Century) => val / 100,

			(UnitOfTime.Decade, UnitOfTime.Nanosecond) => val * 3.154e+17,
			(UnitOfTime.Decade, UnitOfTime.Microsecond) => val * 3.154e+14,
			(UnitOfTime.Decade, UnitOfTime.Millisecond) => val * 3.154e+11,
			(UnitOfTime.Decade, UnitOfTime.Second) => val * 3.154e+8,
			(UnitOfTime.Decade, UnitOfTime.Minute) => val * 5.256e+6,
			(UnitOfTime.Decade, UnitOfTime.Hour) => val * 87600,
			(UnitOfTime.Decade, UnitOfTime.Day) => val * 3650,
			(UnitOfTime.Decade, UnitOfTime.Week) => val * 521.4,
			(UnitOfTime.Decade, UnitOfTime.Month) => val * 120,
			(UnitOfTime.Decade, UnitOfTime.Year) => val * 10,
			(UnitOfTime.Decade, UnitOfTime.Century) => val / 10,

			(UnitOfTime.Century, UnitOfTime.Nanosecond) => val * 3.154e+18,
			(UnitOfTime.Century, UnitOfTime.Microsecond) => val * 3.154e+15,
			(UnitOfTime.Century, UnitOfTime.Millisecond) => val * 3.154e+12,
			(UnitOfTime.Century, UnitOfTime.Second) => val * 3.154e+9,
			(UnitOfTime.Century, UnitOfTime.Minute) => val * 5.256e+7,
			(UnitOfTime.Century, UnitOfTime.Hour) => val * 876000,
			(UnitOfTime.Century, UnitOfTime.Day) => val * 36500,
			(UnitOfTime.Century, UnitOfTime.Week) => val * 5214,
			(UnitOfTime.Century, UnitOfTime.Month) => val * 1200,
			(UnitOfTime.Century, UnitOfTime.Year) => val * 100,
			(UnitOfTime.Century, UnitOfTime.Decade) => val * 10,
			_ => 1,
		};
	}
}
