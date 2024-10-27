DateTime dateTime1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,9,20,0);
Console.WriteLine($"arrival time : {dateTime1.ToString("HH:mm")}");
var dateTime2 = dateTime1.AddHours(9).AddMinutes(15);
Console.WriteLine($"departure time : {dateTime2.ToString("HH:mm")} -- {dateTime2.ToShortTimeString()} -- {dateTime2.ToString("hh:m tt")}");
Console.ReadLine();
