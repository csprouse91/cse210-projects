//Scripture Class will handle displaying the text to the user, and hiding words based on the number of words to be hidden given by the user. 
//
public class Scripture
{
    //Member variables (made private)
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private int _wordsToHide;

    //Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        //Split the text into a list of words
        string[] words = text.Split(" ");
        //Add each word to the list of Word objects List<Word> _words
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    //Method to display text "{reference} {text}"
    public string DisplayText()
    {
        string text = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            text += word + " ";
        }
        return text;
    }

    //Method to hide words
    public void HideWords(int wordsToHide)
    {
        _wordsToHide = wordsToHide;
        //Randomly select words to hide
        for (int i = 0; i < _wordsToHide; i++)
        {
            int randomIndex = new Random().Next(0, _words.Count);
            //Call the Hide method on the Word object at the random index
            _words[randomIndex].Hide();
        }
    }

    //Method to check if all words are hidden
    public bool AllWordsHidden()
    {
        bool _allWordsHidden = false;
        //loop through each word in List<Word> _words and return true if all words are hidden
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                _allWordsHidden = true;
            }
            else
            {
                _allWordsHidden = false;
            }
        }
        return _allWordsHidden;

    }
}
