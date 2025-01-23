//Class to hold fraction 
//2 Attributes: top and bottom
//Ensure attributes are private
public class Fraction
{
    private int _top;
    private int _bottom;

    //Constructor to initialize the fraction set to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    //Constructor that has one parameter for top
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    //Constructor that has two parameters for top and bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //Getter and Setter for top
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    //Getter and Setter for bottom
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    //Method that returns the fraction in string format (top/bottom)
    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }
    //Method that returns the fraction as a decimal
    public double GetDecimalValue()
    {
        // double decimalValue = _top / _bottom;
        // return decimalValue;
        //Changed to match the Sample Solution
        return (double)_top / _bottom;
    }

}