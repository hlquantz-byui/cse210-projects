using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        List<Customer> customers = new List<Customer>();
        customers.Add(new Customer("John Smith", "123 Maple Street", "Springfield", "IL", "USA"));
        customers.Add(new Customer("Emily Johnson", "456 Oak Avenue", "Toronto", "ON", "Canada"));
        customers.Add(new Customer("Sarah Brown", "789 High Street", "London", "", "UK"));
        customers.Add(new Customer("Michael Lee", "321 Pine Road", "Sydney", "NSW", "Australia"));

        List<Order> orders = new List<Order>();
        foreach (Customer customer in customers)
        {
            orders.Add(new Order(customer));
        }

        orders[0].AddProduct(new Product("Wireless Mouse", "US-001", 25.99m, 2));
        orders[0].AddProduct(new Product("USB-C Charging Cable", "US-002", 15.49m, 1));
        orders[1].AddProduct(new Product("Bluetooth Headphones", "CA-001", 79.99m, 1));
        orders[1].AddProduct(new Product("Laptop Stand", "CA-002", 39.99m, 2));
        orders[2].AddProduct(new Product("Smartwatch", "UK-001", 199.99m, 1));
        orders[2].AddProduct(new Product("Fitness Tracker", "UK-002", 49.99m, 3));
        orders[3].AddProduct(new Product("External Hard Drive", "AU-001", 89.99m, 1));
        orders[3].AddProduct(new Product("Gaming Keyboard", "AU-002", 59.99m, 2));

        foreach (Order order in orders)
        {
            Console.WriteLine($"Shipping Label:\n{order.GetShippingLabel()}\n");
            Console.WriteLine($"Packing Label:\n{order.GetPackingLabel()}");
            Console.WriteLine($"Total Cost: {order.CalculateTotalCost()}\n");
        }
    }
}