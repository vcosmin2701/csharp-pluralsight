using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFromCSharp
{
	internal class Utilities
	{
		public static void UsingEscapeCharacters()
		{
			string firstName = "Vladut";
			string lastName = "Cosmin";

			string greeting = $"Welcome!\n{firstName}\t{lastName}";
			Console.WriteLine(greeting);

			string filePath = "C:\\data\\employeelist.xlsx";
			string filePathVerbatim = @"C:\data\employeelist.xlsx"; // improves readbility
			string marketingTagLine = "Making the best \"software\" ever";

			Console.WriteLine($"{filePath}\n{filePathVerbatim}\n{marketingTagLine}");
		}
		public static string RemoveVowels(string input)
		{
			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] == 'a')
				{
					input = input.Replace(input[i], '\0');
				}
				else if (input[i] == 'e')
				{
					input = input.Replace(input[i], '\0');
				}
				else if (input[i] == 'i')
				{
					input = input.Replace(input[i], '\0');
				}
				else if (input[i] == 'o')
				{
					input = input.Replace(input[i], '\0');
				}
				else if (input[i] == 'u')
				{
					input = input.Replace(input[i], '\0');
				}
				else if (input[i] == 'y')
				{
					input = input.Replace(input[i], '\0');
				}
			}
			return input;
		}

		public static void ManipulatingStrings()
		{
			string firstName = "Vladut";
			string lastName = "Cosmin";

			string fullName = firstName + " " + lastName;
			string employeeIdentification = String.Concat(firstName, lastName);

			string empId = firstName.ToLower() + "-" + lastName.Trim().ToLower();

			int length = empId.Length;

			if (fullName.Contains("cosm") || (fullName.Contains("Cosm")))
			{
				Console.WriteLine("It's Cosmo right here");
			}

			string subString = fullName.Substring(1, 3);
			Console.WriteLine(subString);

			string userNameWithStringInterpolation = $"{firstName}-{lastName}";
			Console.WriteLine(userNameWithStringInterpolation);
		}

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
