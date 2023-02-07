public class Fraction
{
    //my class needs some kind of varialbles.........
    private int _top;
    private int _bottom;

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

    //you need to add the get and sets to return the values.......
    public string GetTop()
    {
        return _top.ToString();
    }

    public void SetTop(int top)
    {   
        _top = top;
    }

    public string GetFraction()
    {
        string text = $"{_top}/{_bottom}";
        
        return text;
    }

    public double GetDecimal()
    {
        double fractionMath = (double)_top / (double)_bottom;

        return fractionMath;
    }
}
