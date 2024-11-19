using Samples;

DateTime dateTime1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,9,21,0);
Console.WriteLine($"arrival time : {dateTime1.ToString("HH:mm")}");
var dateTime2 = dateTime1.AddHours(9).AddMinutes(15);
Console.WriteLine($"departure time : {dateTime2.ToString("HH:mm")} -- {dateTime2.ToShortTimeString()} -- {dateTime2.ToString("hh:m tt")}");

var d1 = DateTime.Now;
var d2 = DateTime.Now.Date;
var d3 = DateTime.Now.AddDays(-3).Date;
var d4 = new DateTime(2024,10, 24, 9, 20, 0).Date;

if (d4 > d3)
    Console.WriteLine("SQL");
else
    Console.WriteLine("ClickHouse");

TestClass testClass = new TestClass 
{
};

DtoClass dtoClass = new DtoClass
{
    InnerProp = testClass.InnerClassProp?.InnerProp,
};

Console.WriteLine(dtoClass.InnerProp?.ToString() ?? "Null");


IEnumerable<TestClass2> testClass2 = new List<TestClass2>
{
    new TestClass2 { count = 10 },
    new TestClass2 { count = 20 },
    new TestClass2 { count = 30 },
    new TestClass2 { count = 40 },
};

testClass2.ToList().ForEach(x => x.count++ );

foreach (var item in testClass2)
{
    Console.WriteLine(item.count);
}


Console.ReadLine();