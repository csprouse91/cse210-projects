using System;

class Program
{
    static void Main(string[] args)
    {
        //Once you have created these classes, write a program that creates at least two orders with a 2-3 products each. 
        //Order 1
        Order order1 = new Order(new Customer("Kasin Winess", new Address("123 Main St", "Bountiful", "UT", "United States of America")));
        //Add products to order1 //name, productId, price, quantity
        order1.AddProduct(new Product("Laptop", "HP12345", 999.99f, 1));
        order1.AddProduct(new Product("Gaming Chair", "GT987", 129.99f, 1));
        order1.AddProduct(new Product("Pilot Pen", "G-2", 1.99f, 10));
        //Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.
        string packingLabel1 = order1.GetPackingLabel();
        string shippingLabel1 = order1.GetShippingLabel();
        float total1 = (float)Math.Round(order1.GetTotal(), 2);
        Console.WriteLine(packingLabel1);
        Console.WriteLine(shippingLabel1);
        Console.WriteLine($"Total: ${total1:F2}");//1154.88
        //Order 2
        Order order2 = new Order(new Customer("Raiden Criess", new Address("456 Center St", "San Bernardino", "CA", "USA")));
        //Add products to order2 //name, productId, price, quantity
        order2.AddProduct(new Product("Chocolate Bar", "Hershey123", 2.99f, 5));
        order2.AddProduct(new Product("Marbles", "00123", .29f, 99));
        //Call methods packing label, shipping label, and total price of the order
        string packingLabel2 = order2.GetPackingLabel();
        Console.WriteLine($"\n{packingLabel2}");
        string shippingLabel2 = order2.GetShippingLabel();
        Console.WriteLine(shippingLabel2);
        float total2 = (float)Math.Round(order2.GetTotal(), 2);
        Console.WriteLine($"Total: ${total2:F2}");//48.66

        //Order 3
        Order order3 = new Order(new Customer("Keisha Preggo", new Address("789 South 1000 East", "Toronto", "Ontario", "Canada")));
        //Add products to order3 //name, productId, price, quantity
        order3.AddProduct(new Product("Water Bottle", "Glacier Rain", 1.99f, 24));
        order3.AddProduct(new Product("Milk", "SmithsWM", 3.99f, 2));
        //Call methods packing label, shipping label, and total price of the order
        string packingLabel3 = order3.GetPackingLabel();
        Console.WriteLine($"\n{packingLabel3}");
        string shippingLabel3 = order3.GetShippingLabel();
        Console.WriteLine(shippingLabel3);
        float total3 = (float)Math.Round(order3.GetTotal(), 2);//90.74
        Console.WriteLine($"Total: ${total3:F2}");
    }
}