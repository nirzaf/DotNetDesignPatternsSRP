// There should be only a single reason to change a class

using System.Diagnostics;

try
{
    var j = new Journal();
    j.AddEntry("I cried today.");
    j.AddEntry("I ate a bug.");
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.WriteLine(j);

    var p = new Persistence();

    try
    {
        const string filename = @"F:\journal.txt";
        p.SaveToFile(j, filename);
        var process = new Process();
        process.StartInfo = new ProcessStartInfo(filename)
        {
            UseShellExecute = true
        };
        process.Start();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        Console.ReadLine();
    }
}
catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}