public class OldFashionedPrinter : IMachine
{
    public void Print(Document d)
    {
        // yep
    }

    public void Fax(Document d)
    {
        throw new NotImplementedException();
    }

    public void Scan(Document d)
    {
        throw new NotImplementedException();
    }
}