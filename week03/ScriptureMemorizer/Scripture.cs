//Scripture Class will handle displaying the text to the user, and hiding words based on the number of words to be hidden given by the user. 
//
using System.Runtime.CompilerServices;

public class Scripture
{
    //Member variables (made private)
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private int _wordsToHide;
    private bool _allWordsHidden = false;

    //Constructor to create a new Scripture object and SET the reference and text
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
            text += word.GetDisplayText() + " ";
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
            if (_words[randomIndex].IsHidden() == false)
            {
                //Call the Hide method on the Word object at the random index
                _words[randomIndex].Hide();
                
            }
        }
    }

    //Method to check if all words are hidden
    public bool AllWordsHidden()
    {
        //loop through each word in List<Word> _words and return true if all words are hidden
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                _allWordsHidden = false;
                //break if any word is not hidden
                break;
            }
            else
            {
                _allWordsHidden = true;
            }
        }
        return _allWordsHidden;

    }

}

