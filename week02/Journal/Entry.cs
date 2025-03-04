using System.Net.NetworkInformation;
//A code template for a journal entry
//This class is used to store the date, prompt text, and entry text for a journal entry, and display it with a formatted string
public class Entry
{
    //Member variables
    public string _date = DateTime.Now.ToString("yyyy-MM-dd");
    public string _promptText;
    public string _entryText;

    //Display the journal entry with a formatted string
    public void Display()
    {
        Console.WriteLine($"Date: {_date} | Prompt: {_promptText} | \n{_entryText}\n");
    }
}