// See https://aka.ms/new-console-template for more information
using Baco.HoliDay;

static void PrintLine()
{
    Console.WriteLine(new string('-', 73));
}

static void PrintRow(params string[] columns)
{
    int width = (73 - columns.Length) / columns.Length;
    string row = "|";

    foreach (string column in columns)
    {
        row += AlignCentre(column, width) + "|";
    }

    Console.WriteLine(row);
}

static string AlignCentre(string text, int width)
{
    text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

    if (string.IsNullOrEmpty(text))
    {
        return new string(' ', width);
    }
    else
    {
        return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
    }
}

static void PrintConsole(Dictionary<string, DateTime> list, string tittle)
{
    PrintLine();
    PrintRow(tittle);
    PrintLine();
    PrintRow("Detail", "Date");
    PrintLine();
    foreach (var r in list)
    {
        PrintRow(r.Key, String.Format("{0: MMMM-d-yyyy}", r.Value));
    }
    PrintLine();
}



Colombia col = new Colombia(2022);
Venezuela ve = new Venezuela(2022);
PrintConsole(col.Run(), "Test Holidays Colombia");
PrintConsole(ve.Run(), "Test Holidays Venezuela");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine(col.isWorkingDay(new DateTime(2022,1,8)));

Console.ReadKey();