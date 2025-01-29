//Word Class to handle whether it is shown or hidden, and to return a new displaytext string
public class Word
{
    private string _text;
    private bool _isHidden;

    //Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //Method to return the display text
    public string GetDisplayText()
    {
        return _text;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

}