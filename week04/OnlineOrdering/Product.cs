public class Product
{
    //Member Variables (set to private)
    private string _name;
    private string _productId;
    private float _price;
    private int _quantity;

    //Constructor
    public Product(string name, string productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    //Methods
    public double ComputeSum()
    {
        return _price * _quantity;
    }
    //Method to return product information
    public string GetLabelInfo()
    {
        return _name + ": " + _productId + $" Quantity: {_quantity}";
    }
}