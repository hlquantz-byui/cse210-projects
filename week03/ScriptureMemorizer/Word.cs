class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string text)
    {
        this._text = text;
    }

    public void Hide()
    {
        this._isHidden = true;
    }

    public void Show()
    {
        this._isHidden = false;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', this._text.Length);
        }
        else
        {
            return this._text;
        }
    }

    public bool CanBeHidden()
    {
        return !_isHidden;
    }


}