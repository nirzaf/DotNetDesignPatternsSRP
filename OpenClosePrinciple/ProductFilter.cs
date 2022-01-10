public class ProductFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specs)
    {
        return items.Where(specs.IsSatisfied);
    }
}