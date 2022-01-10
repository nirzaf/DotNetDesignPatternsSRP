public class Persistence
{
    public void SaveToFile(Journal journal, string filename, bool overwrite = false)
    {
        try
        {
            if (overwrite || !File.Exists(filename))
                File.WriteAllText(filename, journal.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}