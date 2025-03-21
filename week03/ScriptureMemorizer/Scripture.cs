class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        this._reference = reference;
        char[] delimiters = new char[] { ' ', ',', '!', '.', '?' };

        string[] individualWords = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in individualWords)
        {
            this._words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int randomWord = random.Next(0, _words.Count);
            if (!_words[randomWord].CanBeHidden())
            {
                if (IsCompletelyHidden())
                {
                    break;
                }
                else
                {
                    i--;
                }
            }
            else
            {
                _words[randomWord].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string text = string.Join(" ", _words.Select(word => word.GetDisplayText()));

        return $"{referenceText} {text}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.GetDisplayText()[0] != '_')
            {
                return false;
            }
        }

        return true;
    }
}