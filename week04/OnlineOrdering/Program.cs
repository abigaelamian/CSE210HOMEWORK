using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Alice Johnson", address1);
        Customer customer2 = new Customer("Bob Smith", address2);

        Product prod1 = new Product("Laptop", "LAP123", 999.99, 1);
        Product prod2 = new Product("Mouse", "MOU456", 25.50, 2);
        Product prod3 = new Product("Keyboard", "KEY789", 49.99, 1);
        Product prod4 = new Product("Monitor", "MON321", 199.99, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(prod1);
        order1.AddProduct(prod2);

        Order order2 = new Order(customer2);
        order2.AddProduct(prod3);
        order2.AddProduct(prod4);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}");
        Console.WriteLine(new string('-', 40));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}