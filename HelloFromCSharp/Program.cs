Console.WriteLine("Choose the action you want to do: ");
Console.WriteLine("1. Add employee");
Console.WriteLine("2. Update employee");
Console.WriteLine("3. Delete employee");

string selectedAction = Console.ReadLine();

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
