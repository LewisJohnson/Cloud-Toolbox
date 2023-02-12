﻿using CloudToolbox.Common.Enums.Units;

namespace CloudToolbox.Calculators.Unit
{
	public class UnitOfDataTranserConverter
	{
		private (UnitOfDataTranser, UnitOfDataTranser) Units;

		public UnitOfDataTranserConverter((UnitOfDataTranser, UnitOfDataTranser) units)
		{
			Units = units;
		}

		public double Convert(double val) => Units switch
		{
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 1,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Bit_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val * 1,

			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobit_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val * 1,

			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Kilobyte_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val * 1,

			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Kibibit_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val * 1,

			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabit_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val * 1,

			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Megabyte_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val * 1,

			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 1,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Mebibit_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val * 1,

			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabit_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val * 1,

			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Gigabyte_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val * 1,

			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Gibibit_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val * 1,

			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabit_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val * 1,

			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Terabyte_Per_Second, UnitOfDataTranser.Tebibit_Per_Second) => val * 1,

			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Bit_Per_Second) => val * 1,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Kilobit_Per_Second) => val * 1,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Kilobyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Kibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Megabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Megabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Mebibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Gigabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Gigabyte_Per_Second) => val * 1,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Gibibit_Per_Second) => val * 1,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Terabit_Per_Second) => val * 1,
			(UnitOfDataTranser.Tebibit_Per_Second, UnitOfDataTranser.Terabyte_Per_Second) => val * 1,
			_ => 1,
		};
	}
}