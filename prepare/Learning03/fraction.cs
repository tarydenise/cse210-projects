using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

public class Fraction 

{
    
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top) 
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string FractionFormat = $"{_top}/{_bottom}";
        return FractionFormat;
    }

    public double GetDecimalValue()
    {
        return  (double)_top / (double)_bottom;
    }
}