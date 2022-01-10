public record Product(string Name, Color Color, Size Size)
{
    public Color Color { get; } = Color;
    public string Name { get; } = Name;
    public Size Size { get; set; } = Size;
}