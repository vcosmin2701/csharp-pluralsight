DateTime hireDate = new DateTime(2023, 5, 22, 15, 30, 0);
Console.WriteLine(hireDate);

DateTime exitDate = new DateTime(2030, 10, 11);
//DateTime invalidDate = new DateTime(2032, 15, 11);

DateTime startDate = hireDate.AddDays(3);
Console.WriteLine(startDate);

DateTime currentDate = DateTime.Now;
Console.WriteLine(currentDate);

bool areWeInDst = currentDate.IsDaylightSavingTime();
Console.WriteLine(areWeInDst);

DateTime startHour = DateTime.Now;
TimeSpan workTime = new TimeSpan(8, 35, 0);
DateTime endHour = startHour.Add(workTime);

Console.WriteLine("Start hour: " + startHour.ToLongDateString());
Console.WriteLine("End hour: " + endHour.ToLongDateString());