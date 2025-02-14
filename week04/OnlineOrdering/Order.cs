public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    double _total;

    //Constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }
    //Method to add a product object to the List<Product>
    public void AddProduct(Product product)
    {
        _products.Add(product);
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
    //Domestic shipping is $5 and international shipping is $35
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
    //Method to return a shipping label // name + address of the customer
    public string GetShippingLabel()
    {
        string shippingLabel = "";
        shippingLabel += _customer.GetCustomerInfo() + "\n";
        return shippingLabel;
    }
}