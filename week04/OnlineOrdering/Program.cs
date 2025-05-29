using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello World! Welcome to my OnlineOrdering Project.");

        // Customer 1 (Uganda)
        Address address1 = new Address("123 Rukidi 111 street", "Kampala", "SP", "Uganda");
        Customer customer1 = new Customer("Rebecca Prossy", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LP1001", 899.99, 1));
        order1.AddProduct(new Product("Wireless Mouse", "WM2002", 25.50, 2));

        DisplayOrder(order1);

        // Customer 2 (Kenya)
        Address address2 = new Address("456 Sir Appolo Kaggwa", "Bwayise", "SN", "Kenya");
        Customer customer2 = new Customer("Mugiriman Innocent", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Bluetooth Speaker", "BS3003", 45.00, 3));
        order2.AddProduct(new Product("USB Charger", "UC4004", 12.99, 4));

        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}");
        Console.WriteLine(new string('-', 50));

    }
}
