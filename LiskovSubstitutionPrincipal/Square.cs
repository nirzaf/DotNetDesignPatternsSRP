public class Square : Rectangle
{
    public override int Width // nasty side effects
    {
        set => base.Width = base.Height = value;
    }

    public override int Height
    {
        set => base.Width = base.Height = value;
    }
}