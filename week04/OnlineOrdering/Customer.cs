using System.Net.Sockets;

public class Customer
{
    private string _name;
    Address _address;
    private bool _inUSA;

    //Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //Method to get the the value if it is domestic or international
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

}