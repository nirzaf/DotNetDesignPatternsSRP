using static System.Console;

namespace LiskovSubstitutionPrincipal;

//should be able to substitute a base type for a subtype
public class Program
{
    private static int Area(Rectangle r)
    {
        return r.Width * r.Height;
    }

    private static void Main(string[] args)
    {
        var rc = new Rectangle(2, 3);
        WriteLine($"{rc} has area {Area(rc)}");

        // should be able to substitute a base type for a subtype
        /*Square*/
        var sq = new Square
        {
            Width = 0,
            Height = 0
        };
        sq.Width = 4;
        WriteLine($"{sq} has area {Area(sq)}");
        ReadLine();
    }
}