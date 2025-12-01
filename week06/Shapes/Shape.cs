public class Shape
{
    protected string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }
    public void setColor(string color)
    {
        _color = color;
    }
    public virtual double GetArea()
    {
        // default return
        return 1;
    }
}