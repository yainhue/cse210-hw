/*
You need to create a class for a fraction that has:

    Attributes for the top and bottom numbers
    Constructors
    Getters and setters for the top and bottom numbers
    Methods to return representations of both the fractional and decimal views.
*/

public class Fraction
{
    // member attributes
    private int _top;
    private int _bottom;

    // constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // getters & setters

    public void GetTop()
    {
        Console.WriteLine(_top);
    }
    public void GetBottom()
    {
        Console.WriteLine(_bottom);
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public void SetBottom(int bottom)
    {
        _top = bottom;
    }

    // methods

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalvalue()
    {
        return (double)_top / (double)_bottom;
    }
}

