using System;

class Program
{
    static void Main(string[] args)
    {
        //Once you have created these classes, write a program that creates at least two orders with a 2-3 products each. 
        //Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.
        Order order1 = new Order(new Customer("Kasin Winess", new Address("123 Main St", "Bountiful", "UT", "USA")));
        
    }
}