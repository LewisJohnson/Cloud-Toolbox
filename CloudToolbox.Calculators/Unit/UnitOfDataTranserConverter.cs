﻿using CloudToolbox.Calculators.Interfaces;
using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Calculators.Unit
{
	public class UnitOfDataTranserConverter : IUnitOfConverter
	{
		private (UnitOfDataTranser, UnitOfDataTranser) Units;

		public UnitOfDataTranserConverter((UnitOfDataTranser, UnitOfDataTranser) units)
		{
			Units = units;
		}

		public double Convert(double val) => Units switch
		{
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val / 8000,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val / 1000,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val / 1024,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val / 1e+6,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val / 8e+6,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val / 1.049e+6,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val / 1e+9,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val / 8e+9,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val / 1.074e+9,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val / 1e+12,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val / 8e+12,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val / 1.1e+12,

			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1000,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val / 8,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val / 1.024,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val / 1000,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val / 8000,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val / 1049,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val / 1e+6,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val / 8e+6,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val / 1.074e+6,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val / 1e+9,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val / 8e+9,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val / 1.1e+9,

			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 8000,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 8,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 7.812,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val / 125,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val / 1000,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val / 131.1,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val / 125000,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val / 1e+6,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val / 134200,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val / 1.25e+8,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val / 1e+9,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val / 1.374e+8,

			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1024,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 1.024,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val / 7.812,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val / 976.6,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val / 7813,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val / 1024,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val / 976600,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val / 7.813e+6,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val / 1.049e+6,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val / 9.766e+8,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val / 7.813e+9,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val / 1.074e+9,

			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1e+6,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 1000,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 125,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 976.6,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val / 8,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val / 1.049,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val / 1000,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val / 8000,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val / 1074,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val / 1e+6,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val / 8e+6,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val / 1.1e+6,

			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 8e+6,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 8000,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 1000,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 7813,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 8,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val * 7.629,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val / 125,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val / 1000,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val / 134.2,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val / 125000,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val / 1e+6,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val / 137400,

			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1.049e+6,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 1049,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 131.1,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 1024,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 1.049,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val / 7.629,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val / 953.7,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val / 7629,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val / 1024,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val / 953700,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val / 7.629e+6,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val / 1.049e+6,

			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1e+9,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 1e+6,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 125000,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 976600,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 1000,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val * 125,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val * 953.7,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val / 8,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val / 1.074,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val / 1000,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val / 8000,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val / 1100,

			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 8e+9,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 8e+6,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 1e+6,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 7.813e+6,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 8000,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val * 1000,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val * 7629,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val * 8,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val * 7.451,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val / 125,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val / 1000,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val / 137.4,

			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1.074e+9,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 1.074e+6,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 134200,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 1.049e+6,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 1074,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val * 134.2,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val * 1024,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val * 1.074,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val / 7.451,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val / 931.3,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val / 7451,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val / 1024,

			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val / 1.1,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1e+12,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 1e+9,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 1.25e+8,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 9.766e+8,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 1e+6,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val * 125000,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val * 953700,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val * 1000,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val * 125,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val * 931.3,

			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val * 7.276,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 8e+12,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 8e+9,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 1e+9,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 7.813e+9,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 8e+6,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val * 1e+6,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val * 7.629e+6,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val * 8000,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val * 1000,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val * 7451,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val * 8,

			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1.1e+12,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 1.1e+9,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 1.374e+8,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 1.074e+9,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 1.1e+6,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val * 137400,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val * 1.049e+6,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val * 1100,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val * 137.4,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val * 1024,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val * 1.1,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val / 7.276,
			_ => 1,
		};
	}
}
