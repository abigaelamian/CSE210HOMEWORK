using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Dallas", "TX", "USA");
        Customer customer1 = new Customer("Abigail Masitsa", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 850, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25, 2));
        order1.AddProduct(new Product("Keyboard", "P1003", 45, 1));

        Address address2 = new Address("55 King Street", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("John Carter", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "P2001", 120, 1));
        order2.AddProduct(new Product("Webcam", "P2002", 75, 1));

        DisplayOrder(order1);
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("==============================");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice()}");
        Console.WriteLine();
    }
}