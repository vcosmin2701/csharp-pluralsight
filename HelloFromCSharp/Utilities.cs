using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFromCSharp
{
	internal class Utilities
	{

		public static void UsingExpressionBodiedSyntax()
		{
			int amount = 1234;
			int months = 12;
			int bonus = 500;

			int yearlyWageForEmployee = CalculateYearlyWageExpressionBodied(amount, months, bonus);

			Console.WriteLine($"Yearly wage for employee: {yearlyWageForEmployee}");
		}

		public static int CalculateYearlyWageExpressionBodied(int monthlyWage, int numberOfMonthsWorked, int bonus) => monthlyWage * numberOfMonthsWorked + bonus;

		public static void UsingNamedArguments()
		{
			int amount = 1234;
			int months = 12;
			int bonus = 500;

			int yearlyWageForEmployee = CalculateYearlyWageWithNamed(bonus: bonus, monthlyWage: amount, numberOfMonthsWorked: months);

			Console.WriteLine($"Yearly wage for employee: {yearlyWageForEmployee}");
		}

		public static int CalculateYearlyWageWithNamed(int monthlyWage, int numberOfMonthsWorked, int bonus)
		{
			Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
			return monthlyWage + numberOfMonthsWorked + bonus;
		}

		public static void UsingOptionalParameters()
		{
			int monthlyWage1 = 1234;
			int months1 = 12;

			int yearlyWageForEmployee1 = CalculateYearlyWageWithOptional(monthlyWage1, months1, 100);
			Console.WriteLine($"Yearly wage for employee 1 : {yearlyWageForEmployee1}");
		}

		public static int CalculateYearlyWageWithOptional(int monthlyWage, int numberOfMonthsWorked, int bonus = 0)
		{
			// int local = 100; local scope
			Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
			return monthlyWage + numberOfMonthsWorked + bonus;
		}

		public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
		{
			// int local = 100; local scope
			//Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
			if (numberOfMonthsWorked == 12)
			{
				return monthlyWage * (numberOfMonthsWorked + 1);
			}
			return monthlyWage * numberOfMonthsWorked;
		}

		public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
		{
			// int local = 100; local scope
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
