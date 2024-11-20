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


var date1 = DateTime.Now;
var date2 = DateTime.Now.AddMinutes(61);
var diff1 = (int)(date2 - date1).TotalMinutes;

var date3 = DateTime.Now;
var date4 = DateTime.Now.AddMilliseconds(100);
var diff2 = (int)(date3 - date4).TotalMinutes;



//should be 0
long l1 = 20240910153159565;
long l2 = 20240910153124586;

var l3 = (l1.ToDateTime() - l2.ToDateTime()).Minutes;

//should be 1
long l4 = 20240910153049546;
long l5 = 20240910153124586;
var l6 = (l4.ToDateTime() - l5.ToDateTime()).Minutes;
var l7 = (l5.ToDateTime() - l4.ToDateTime()).Minutes;

//should be 10
long l8 = 20240910154937458;
long l9 = 20240910153912053;
var l10 = (l8.ToDateTime() - l9.ToDateTime()).Minutes;

Console.ReadLine();

