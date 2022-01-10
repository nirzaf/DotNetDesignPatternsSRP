using static System.Console;

//Open for extension and closed for modification 

var apple = new Product("Apple", Color.Green, Size.Small);
var tree = new Product("Tree", Color.Blue, Size.Large);
var house = new Product("House", Color.Red, Size.Large);

Product[] products = { apple, tree, house };

var pf = new ProductFilter();

WriteLine("Green Products (new) : ");
foreach (var p in pf.Filter(products, new ColorSpecification(Color.Green)))
{
    WriteLine($" - {p.Name} is green ");
}

WriteLine("After Composition with Additional Filter ");

WriteLine("Large blue items : ");
foreach (var p in pf.Filter(products,
             new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))))
{
    WriteLine($" - {p.Name} is large and blue ");
}


//Console.WriteLine("Hello, World!");