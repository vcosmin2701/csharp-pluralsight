using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_training
{
	internal class Employee
	{
		public string firstName;
		public string lastName;
		public string email;

		public int numberOfHoursWorked;
		public double wage;
		public double hourlyRate;

		public DateTime birthday;
		const int minimalHoursWorkedUnit = 1;

		public void PerformWork()
		{
			PerformWork(minimalHoursWorkedUnit);
		}

		public void PerformWork(int numberOfHours)
		{
			numberOfHoursWorked += numberOfHours;
			Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hour(s)!");
		}

		public double ReceiveWage(bool resetHours = true)
		{
			wage = numberOfHoursWorked * hourlyRate;
			Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hours(s) of work.");
			if (resetHours)
			{
				numberOfHoursWorked = 0;
			}
			return wage;
		}

		public void DisplayEmployeeDetails()
		{
			Console.WriteLine($"\nFirst name: \t{firstName}\nLastName: \t{lastName}\nEmail: \t\t{email}\nBirthday: \t{birthday.ToShortDateString()}\n");
		}

	}
}
