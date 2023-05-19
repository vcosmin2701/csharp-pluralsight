using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFromCSharp
{
	internal class Utilities
	{
		public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
		{
			//Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
			if (numberOfMonthsWorked == 12)
			{
				return monthlyWage * (numberOfMonthsWorked + 1);
			}

			return monthlyWage * numberOfMonthsWorked;

		}

		public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
		{
			Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
			return monthlyWage + numberOfMonthsWorked + bonus;
		}

		public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
		{
			Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
			return monthlyWage + numberOfMonthsWorked + bonus;
		}
	}
}
