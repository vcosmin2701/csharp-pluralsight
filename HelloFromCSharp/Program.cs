Console.WriteLine("Choose the action you want to do: ");
Console.WriteLine("1. Add employee");
Console.WriteLine("2. Update employee");
Console.WriteLine("3. Delete employee");
Console.WriteLine("99. Exit application");

string selectedAction = Console.ReadLine();
while (selectedAction != "99")
{
	switch (selectedAction)
	{
		case "1":
			Console.WriteLine("Adding new employee....");
			break;
		case "2":
			Console.WriteLine("Update employee..");
			break;
		case "3":
			Console.WriteLine("Deleting employee...");
			break;
		default:
			Console.WriteLine("Invalid input.");
			break;
	}
	Console.WriteLine("Choose the action you want to do: ");
	Console.WriteLine("1. Add employee");
	Console.WriteLine("2. Update employee");
	Console.WriteLine("3. Delete employee");
	Console.WriteLine("99. Exit application");
	selectedAction = Console.ReadLine();
}

Console.WriteLine("Closing application");

int i = 0;
int j = 0;

while(i < 10)
{
	while(j < 10)
	{
		Console.WriteLine("i: " + i + "    j: " + j);
		j++;
	}
	j = 0;
	i++;
}

while (true)
{
	Console.WriteLine(DateTime.Now);
}