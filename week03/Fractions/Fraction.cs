public class Fraction
{
    // Private attributes
    private int _top;
    private int _bottom;

    // Constructor 1: No parameters (default to 1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2: One parameter (5/1)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor 3: Two parameters (3/4)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter and Setter for _top
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter and Setter for _bottom
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Method to return the fraction as a string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
