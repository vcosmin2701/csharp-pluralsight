// C# Sprint learning

double ratePerHour = 12.34;
int numberOfHoursWorked = 165;
int bonus = 100;

double currentMonthWage = ratePerHour * numberOfHoursWorked+bonus;
Console.WriteLine(currentMonthWage);

ratePerHour += 3; //ratePerHour = ratePerHour + 3;

if(currentMonthWage > 2000)
{
	Console.WriteLine("Top paid employee");
}

int numberOfEmployees = 15;
numberOfEmployees--;

bool a;
int b;

int intMaxValue = int.MaxValue;
int intMinValue = int.MinValue;

char userSelection = 'a';
char upperVersion = char.ToUpper(userSelection);

bool isDigit = char.IsDigit(userSelection);
bool isLetter = char.IsLetter(userSelection);

Console.ReadLine();
 