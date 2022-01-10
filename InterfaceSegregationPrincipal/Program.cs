//Interface should not force the implementation when it is not required to implement 

Console.WriteLine("Hello, World!");

#region Interface Segregation Violated

//this will break the interface segregation principal if we need to implement only Print Method

Document d = new Document();
OldFashionedPrinter ofp = new OldFashionedPrinter();

ofp.Fax(d);
ofp.Scan(d);

#endregion