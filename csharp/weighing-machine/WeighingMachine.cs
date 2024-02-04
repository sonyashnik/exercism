using System;
using System.Globalization;

class WeighingMachine
{
    private int _precision;
    private double _weight;
    public int Precision
    {
        get { return _precision; }
    }
    public double Weight
    {
        get { return _weight; }
        set
        {
            if (value >= 0)
            {
                _weight = value;
            }
            else
                throw new ArgumentOutOfRangeException("Weight can not be negative!");
        }
    }
    public double TareAdjustment { get; set; } = 5;

    public string DisplayWeight
    {
        get {
            var displayedWeight = (decimal)(Weight - TareAdjustment);
            var format = new NumberFormatInfo
            {
                NumberDecimalDigits = Precision
            };
            return $"{displayedWeight.ToString("N",format)} kg" ; }
    }
    public WeighingMachine(int precision)
    {
        _precision = precision;
    }
}
