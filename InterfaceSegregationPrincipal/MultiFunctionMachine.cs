public readonly struct MultiFunctionMachine : IMultiFunctionDevice
{
    // compose this out of several modules
    private readonly IPrinter _printer;
    private readonly IScanner _scanner;

    public MultiFunctionMachine(IPrinter printer, IScanner scanner)
    {
        _printer = printer ?? throw new ArgumentNullException(nameof(printer));
        _scanner = scanner ?? throw new ArgumentNullException(nameof(scanner));
    }

    public void Print(Document d)
    {
        _printer.Print(d);
    }

    public void Scan(Document d)
    {
        _scanner.Scan(d);
    }
}