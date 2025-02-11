using System.Xml;

public class Comment
{
    //Tracks the author and the content of the comment//
    //Responsible for storing the author and content of a comment//

    private string _name;
    private string _text;

    //Constructor//
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    //Method to display text // {name}: {text} 
    public string DisplayText()
    {
        //Learned how to create newline in C# from https://stackoverflow.com/questions/2780359/creating-a-newline-in-c-sharp
        return _name + ": \n" + _text;
    }
}