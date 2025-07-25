using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Elm Street", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("T-shirt", "TS001", 15.99, 2));
        order1.AddProduct(new Product("Mug", "MG005", 9.50, 1));

        Address address2 = new Address("45 Oxford Road", "London", "Greater London", "UK");
        Customer customer2 = new Customer("James Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "NB002", 4.75, 5));
        order2.AddProduct(new Product("Pen Pack", "PP010", 2.20, 3));

        Console.WriteLine("=== Order 1 ===");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}\n");

        Console.WriteLine("=== Order 2 ===");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}