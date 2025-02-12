using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        //create the customers and their address
        Address address1 = new Address("3116 4th St", "Lubbock", "Tx", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        //create Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 1000, 1));
        order1.AddProduct(new Product("Mouse", 102, 20, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", 103, 500, 3));
        order2.AddProduct(new Product("Headphones", 104, 80, 4));


        //Disyplaying the Order details 
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Price: ${order1.TotalPrice()}");

        Console.WriteLine();

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Price: ${order2.TotalPrice()}");
    }
}