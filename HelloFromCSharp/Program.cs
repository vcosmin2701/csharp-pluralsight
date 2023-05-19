Console.WriteLine("Enter the age of the new canditate: ");
int age = int.Parse(Console.ReadLine());

if(age < 18)
{
	Console.WriteLine("Too young to apply");
}
else if(age > 65)
{
	Console.WriteLine("You need to rest old buddy! :D");
}
else
{
	Console.WriteLine("You can apply");
}

DateTime today = DateTime.Now;
bool endOfMonthPaymentStarted = false;

if(today.Date.Day == 20)
{
	Console.WriteLine("Please start end-of-month employee payments");
}
else if(today.Date.Day >= 25 && !endOfMonthPaymentStarted)
{
	Console.WriteLine("Payments will be late");
}
else
{
	Console.WriteLine("YOU DON'T NEED A JOB =))");
}