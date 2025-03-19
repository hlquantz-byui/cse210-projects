class Fraction
{
    private int _top, _bottom;

    public Fraction()
    {
        this._top = 1;
        this._bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        this._top = wholeNumber;
        this._bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void setTop(int wholeNumber)
    {
        this._top = wholeNumber;
    }

    public int getTop()
    {
        return this._top;
    }

    public void setBottom(int wholeNumber)
    {
        this._bottom = wholeNumber;
    }

    public int getBottom()
    {
        return this._bottom;
    }

    public string getFractionString()
    {
        return $"{this._top}/{this._bottom}";
    }

    public double getDecimalValue()
    {
        return (double)this._top / (double)this._bottom;
    }
}