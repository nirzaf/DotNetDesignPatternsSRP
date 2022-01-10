public class ColorSpecification : ISpecification<Product>
{
    private Color _color;

    public ColorSpecification(Color color)
    {
        _color = color;
    }

    public bool IsSatisfied(Product t)
    {
        return t.Color == _color;
    }
}