int amount = 1234;
int months = 12;

int yearlyWage = CalculateYearlyWage(amount, months);
Console.WriteLine($"Yearly wage: {yearlyWage}");

static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
{
	//Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
	if(numberOfMonthsWorked == 12)
	{
		return monthlyWage * (numberOfMonthsWorked + 1);
	}
	
	return monthlyWage * numberOfMonthsWorked;

}