//Word Class to handle whether it is shown or hidden, and to return a new displaytext string
public class Word
{
    private string _text;
    private bool _isHidden;

    //Constructor to create a new Word object and SET the word to show
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //Method to GET the display text
    public string GetDisplayText()
    {
        //loop through each char in word and replace with '_' 
        if (_isHidden)
        {
            for (int i = 0; i < _text.Length; i++)
            {
                _text = _text.Replace(_text[i], '_');

            }
        }
        return _text;
    }
    //Method to SET the word to hidden
    public void Hide()
    {
        _isHidden = true;
    }
    //Method to SET the word to show
    public void Show()
    {
        _isHidden = false;
    }
    //Method to check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

}