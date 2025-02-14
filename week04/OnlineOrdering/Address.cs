public class Address
{
    //Member Variables
    private string _streetAddress;
    private string _city;
    private string _state;//Province = state
    private string _country;

    //Constructor
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    //Method to check if country is USA or not
    public bool IsInUSA()
    {
        if (_country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES OF AMERICA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //Method for address label
    public string GetAddressText()
    {
        return _streetAddress + "\n" + _city + ", " + _state + " " + _country;
    }

}