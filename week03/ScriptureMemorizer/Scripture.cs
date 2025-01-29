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

}