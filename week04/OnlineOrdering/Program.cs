using System;
class Program
{
    static void Main(string[] args)
    {
        // Created some products
        Product product1 = new Product("Laptop", "P1001", 999.99, 1);
        Product product2 = new Product("Mouse", "P1002", 24.99, 2);
        Product product3 = new Product("Keyboard", "P1003", 49.99, 1);
        Product product4 = new Product("Monitor", "P1004", 199.99, 2);
        Product product5 = new Product("Headphones", "P1005", 79.99, 3);

        // Created addresses
        Address usaAddress = new Address("123 Main St", "Rexburg", "ID", "USA");
        Address internationalAddress = new Address("456 High St", "London", "England", "UK");

        // Created customers
        Customer customer1 = new Customer("John Doe", usaAddress);
        Customer customer2 = new Customer("Jane Smith", internationalAddress);

        // Created orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Displays order information
        Console.WriteLine("ORDER 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():0.00}");
        Console.WriteLine();

        Console.WriteLine("ORDER 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():0.00}");
    }
}