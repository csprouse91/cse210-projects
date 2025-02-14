using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;
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
    //Method to get customer name and address
    public string GetCustomerInfo()
    {
        return _name + "\n" + _address.GetAddressText();
    }
}