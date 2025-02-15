//Assignment SuperClass 
public class Assignment
{
    private string _name;
    private string _topic;

    //Constructor 
    public Assignment(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }

    //Method to return name and topic
    public string GetSummary()
    {
        return _name + " - " + _topic;
    }
    //Method to return name
    public string GetName()
    {
        return _name;
    }
    //Method to return topic
    public string GetTopic()
    {
        return _topic;
    }
}