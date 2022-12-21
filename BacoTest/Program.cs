// See https://aka.ms/new-console-template for more information
using Baco.HoliDay;

Console.WriteLine("Hello, World!");
Colombia col = new Colombia(2022);
var list = col.Run();

foreach(var r in list)
{
    Console.WriteLine(r.Key+":      "+ String.Format("{0:dddd, MMMM d, yyyy}", r.Value));
}

Console.WriteLine();