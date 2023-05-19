Console.WriteLine("Enter a value");
int max = int.Parse(Console.ReadLine());

for(int i = 0; i < max; i++)
{
	if (i == 5)
	{
		Console.WriteLine("Bingo! " + i + " was found!");
		break;
	}
	Console.WriteLine(i);
}