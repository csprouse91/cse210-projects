public class PromptGenerator
{
    //Member variable
    public List<string> _prompts = new List<string>();

    //Method to get a random prompt
    public string GetRandomPrompt()
    {
        //Create a random index
        int randomIndex = new Random().Next(0, _prompts.Count);
        //Return the prompt at the random index
        return _prompts[randomIndex];
    }

}