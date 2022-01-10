// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

#region Interface Segregation Violated

//this will break the interface segregation principal if we need to implement only Print Method

Document d = new Document();
OldFashionedPrinter ofp = new OldFashionedPrinter();

ofp.Fax(d);
ofp.Scan(d);

#endregion