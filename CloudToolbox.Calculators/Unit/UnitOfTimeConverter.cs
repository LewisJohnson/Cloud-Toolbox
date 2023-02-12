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
			(UnitOfTime.Nanosecond, UnitOfTime.Millisecond) => val / 100000,
			(UnitOfTime.Nanosecond, UnitOfTime.Second) => val / 1000000000,

			(UnitOfTime.Microsecond, UnitOfTime.Nanosecond) => val * 1,
			(UnitOfTime.Microsecond, UnitOfTime.Millisecond) => val * 1,
			(UnitOfTime.Microsecond, UnitOfTime.Second) => val * 1,
			(UnitOfTime.Microsecond, UnitOfTime.Minute) => val * 1,
			(UnitOfTime.Microsecond, UnitOfTime.Hour) => val * 1,
			(UnitOfTime.Microsecond, UnitOfTime.Day) => val * 1,
			(UnitOfTime.Microsecond, UnitOfTime.Week) => val * 1,
			(UnitOfTime.Microsecond, UnitOfTime.Month) => val * 1,
			(UnitOfTime.Microsecond, UnitOfTime.Year) => val * 1,
			(UnitOfTime.Microsecond, UnitOfTime.Decade) => val * 1,
			(UnitOfTime.Microsecond, UnitOfTime.Century) => val * 1,

			(UnitOfTime.Millisecond, UnitOfTime.Nanosecond) => val * 1,
			(UnitOfTime.Millisecond, UnitOfTime.Microsecond) => val * 1,
			(UnitOfTime.Millisecond, UnitOfTime.Second) => val * 1,
			(UnitOfTime.Millisecond, UnitOfTime.Minute) => val * 1,
			(UnitOfTime.Millisecond, UnitOfTime.Hour) => val * 1,
			(UnitOfTime.Millisecond, UnitOfTime.Day) => val * 1,
			(UnitOfTime.Millisecond, UnitOfTime.Week) => val * 1,
			(UnitOfTime.Millisecond, UnitOfTime.Month) => val * 1,
			(UnitOfTime.Millisecond, UnitOfTime.Year) => val * 1,
			(UnitOfTime.Millisecond, UnitOfTime.Decade) => val * 1,
			(UnitOfTime.Millisecond, UnitOfTime.Century) => val * 1,

			(UnitOfTime.Second, UnitOfTime.Nanosecond) => val * 1,
			(UnitOfTime.Second, UnitOfTime.Microsecond) => val * 1,
			(UnitOfTime.Second, UnitOfTime.Millisecond) => val * 1,
			(UnitOfTime.Second, UnitOfTime.Minute) => val * 1,
			(UnitOfTime.Second, UnitOfTime.Hour) => val * 1,
			(UnitOfTime.Second, UnitOfTime.Day) => val * 1,
			(UnitOfTime.Second, UnitOfTime.Week) => val * 1,
			(UnitOfTime.Second, UnitOfTime.Month) => val * 1,
			(UnitOfTime.Second, UnitOfTime.Year) => val * 1,
			(UnitOfTime.Second, UnitOfTime.Decade) => val * 1,
			(UnitOfTime.Second, UnitOfTime.Century) => val * 1,

			(UnitOfTime.Minute, UnitOfTime.Nanosecond) => val * 1,
			(UnitOfTime.Minute, UnitOfTime.Microsecond) => val * 1,
			(UnitOfTime.Minute, UnitOfTime.Millisecond) => val * 1,
			(UnitOfTime.Minute, UnitOfTime.Second) => val * 1,
			(UnitOfTime.Minute, UnitOfTime.Hour) => val * 1,
			(UnitOfTime.Minute, UnitOfTime.Day) => val * 1,
			(UnitOfTime.Minute, UnitOfTime.Week) => val * 1,
			(UnitOfTime.Minute, UnitOfTime.Month) => val * 1,
			(UnitOfTime.Minute, UnitOfTime.Year) => val * 1,
			(UnitOfTime.Minute, UnitOfTime.Decade) => val * 1,
			(UnitOfTime.Minute, UnitOfTime.Century) => val * 1,

			(UnitOfTime.Hour, UnitOfTime.Nanosecond) => val * 1,
			(UnitOfTime.Hour, UnitOfTime.Microsecond) => val * 1,
			(UnitOfTime.Hour, UnitOfTime.Millisecond) => val * 1,
			(UnitOfTime.Hour, UnitOfTime.Second) => val * 1,
			(UnitOfTime.Hour, UnitOfTime.Minute) => val * 1,
			(UnitOfTime.Hour, UnitOfTime.Day) => val * 1,
			(UnitOfTime.Hour, UnitOfTime.Week) => val * 1,
			(UnitOfTime.Hour, UnitOfTime.Month) => val * 1,
			(UnitOfTime.Hour, UnitOfTime.Year) => val * 1,
			(UnitOfTime.Hour, UnitOfTime.Decade) => val * 1,
			(UnitOfTime.Hour, UnitOfTime.Century) => val * 1,

			(UnitOfTime.Day, UnitOfTime.Nanosecond) => val * 1,
			(UnitOfTime.Day, UnitOfTime.Microsecond) => val * 1,
			(UnitOfTime.Day, UnitOfTime.Millisecond) => val * 1,
			(UnitOfTime.Day, UnitOfTime.Second) => val * 1,
			(UnitOfTime.Day, UnitOfTime.Minute) => val * 1,
			(UnitOfTime.Day, UnitOfTime.Hour) => val * 1,
			(UnitOfTime.Day, UnitOfTime.Week) => val * 1,
			(UnitOfTime.Day, UnitOfTime.Month) => val * 1,
			(UnitOfTime.Day, UnitOfTime.Year) => val * 1,
			(UnitOfTime.Day, UnitOfTime.Decade) => val * 1,
			(UnitOfTime.Day, UnitOfTime.Century) => val * 1,

			(UnitOfTime.Week, UnitOfTime.Nanosecond) => val * 1,
			(UnitOfTime.Week, UnitOfTime.Microsecond) => val * 1,
			(UnitOfTime.Week, UnitOfTime.Millisecond) => val * 1,
			(UnitOfTime.Week, UnitOfTime.Second) => val * 1,
			(UnitOfTime.Week, UnitOfTime.Minute) => val * 1,
			(UnitOfTime.Week, UnitOfTime.Hour) => val * 1,
			(UnitOfTime.Week, UnitOfTime.Day) => val * 1,
			(UnitOfTime.Week, UnitOfTime.Month) => val * 1,
			(UnitOfTime.Week, UnitOfTime.Year) => val * 1,
			(UnitOfTime.Week, UnitOfTime.Decade) => val * 1,
			(UnitOfTime.Week, UnitOfTime.Century) => val * 1,

			(UnitOfTime.Month, UnitOfTime.Nanosecond) => val * 1,
			(UnitOfTime.Month, UnitOfTime.Microsecond) => val * 1,
			(UnitOfTime.Month, UnitOfTime.Millisecond) => val * 1,
			(UnitOfTime.Month, UnitOfTime.Second) => val * 1,
			(UnitOfTime.Month, UnitOfTime.Minute) => val * 1,
			(UnitOfTime.Month, UnitOfTime.Hour) => val * 1,
			(UnitOfTime.Month, UnitOfTime.Day) => val * 1,
			(UnitOfTime.Month, UnitOfTime.Week) => val * 1,
			(UnitOfTime.Month, UnitOfTime.Year) => val * 1,
			(UnitOfTime.Month, UnitOfTime.Decade) => val * 1,
			(UnitOfTime.Month, UnitOfTime.Century) => val * 1,

			(UnitOfTime.Year, UnitOfTime.Nanosecond) => val * 1,
			(UnitOfTime.Year, UnitOfTime.Microsecond) => val * 1,
			(UnitOfTime.Year, UnitOfTime.Millisecond) => val * 1,
			(UnitOfTime.Year, UnitOfTime.Second) => val * 1,
			(UnitOfTime.Year, UnitOfTime.Minute) => val * 1,
			(UnitOfTime.Year, UnitOfTime.Hour) => val * 1,
			(UnitOfTime.Year, UnitOfTime.Day) => val * 1,
			(UnitOfTime.Year, UnitOfTime.Week) => val * 1,
			(UnitOfTime.Year, UnitOfTime.Month) => val * 1,
			(UnitOfTime.Year, UnitOfTime.Decade) => val * 1,
			(UnitOfTime.Year, UnitOfTime.Century) => val * 1,

			(UnitOfTime.Decade, UnitOfTime.Nanosecond) => val * 1,
			(UnitOfTime.Decade, UnitOfTime.Microsecond) => val * 1,
			(UnitOfTime.Decade, UnitOfTime.Millisecond) => val * 1,
			(UnitOfTime.Decade, UnitOfTime.Second) => val * 1,
			(UnitOfTime.Decade, UnitOfTime.Minute) => val * 1,
			(UnitOfTime.Decade, UnitOfTime.Hour) => val * 1,
			(UnitOfTime.Decade, UnitOfTime.Day) => val * 1,
			(UnitOfTime.Decade, UnitOfTime.Week) => val * 1,
			(UnitOfTime.Decade, UnitOfTime.Month) => val * 1,
			(UnitOfTime.Decade, UnitOfTime.Year) => val * 1,
			(UnitOfTime.Decade, UnitOfTime.Century) => val * 1,

			(UnitOfTime.Century, UnitOfTime.Nanosecond) => val * 1,
			(UnitOfTime.Century, UnitOfTime.Microsecond) => val * 1,
			(UnitOfTime.Century, UnitOfTime.Millisecond) => val * 1,
			(UnitOfTime.Century, UnitOfTime.Second) => val * 1,
			(UnitOfTime.Century, UnitOfTime.Minute) => val * 1,
			(UnitOfTime.Century, UnitOfTime.Hour) => val * 1,
			(UnitOfTime.Century, UnitOfTime.Day) => val * 1,
			(UnitOfTime.Century, UnitOfTime.Week) => val * 1,
			(UnitOfTime.Century, UnitOfTime.Month) => val * 1,
			(UnitOfTime.Century, UnitOfTime.Year) => val * 1,
			(UnitOfTime.Century, UnitOfTime.Decade) => val * 1,
			_ => 1,
		};
	}
}