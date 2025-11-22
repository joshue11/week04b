using System;

class Program
{
    static void Main(string[] args)
    {
        // ----- ORDER 1 -----
        Address address1 = new Address("123 Main St", "Dallas", "TX", "USA");
        Customer customer1 = new Customer("John Carter", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "L100", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M200", 25.50, 2));

        // ----- ORDER 2 -----
        Address address2 = new Address("45 Maple Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Sarah Collins", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Keyboard", "K300", 49.99, 1));
        order2.AddProduct(new Product("Monitor", "MN800", 199.99, 1));
        order2.AddProduct(new Product("USB Cable", "USB10", 5.99, 3));

        // ----- DISPLAY RESULTS -----
        DisplayOrder(order1);
        Console.WriteLine("------------------------------------");
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"TOTAL COST: ${order.GetTotalCost():0.00}\n");
    }
}
