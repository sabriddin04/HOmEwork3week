List<DateTime> dates = new List<DateTime>
{
new DateTime(2020, 10, 1),
new DateTime(2022, 8, 15),
new DateTime(2021, 4, 28)
};
dates.Sort();

Console.WriteLine("The sorted dates are:");
foreach(DateTime date in dates)
{
 Console.WriteLine(date.ToShortDateString());
}