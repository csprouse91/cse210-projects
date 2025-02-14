public class Order
{
    List<Product> _products = new List<Product>();
    Customer _customer;
    double _total;

    //Constructor
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    //Method to return packing label with product name and id and quantity of each item in the order
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += product.GetLabelInfo() + "\n";
        }
        return packingLabel;
    }
    //Method to return the total price of the order conditional of domestic or international
    public double GetTotal()
    {
        foreach (Product product in _products)
        {
            _total += product.ComputeSum();
        }
        if (_customer.IsInUSA())
        {
            return _total + 5;
        }
        else
        {
            return _total + 35;
        }
    }

}