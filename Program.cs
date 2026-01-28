using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 800, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25, 2));
        DisplayOrder(order1);

        Console.WriteLine("\n------------------------\n");

        Address address2 = new Address("45 Ring Road", "Accra", "Greater Accra", "Ghana");
        Customer customer2 = new Customer("Abdul Aziz", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P2001", 500, 1));
        order2.AddProduct(new Product("Headphones", "P2002", 60, 1));
        order2.AddProduct(new Product("Charger", "P2003", 20, 2));
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"TOTAL PRICE: ${order.GetTotalPrice()}");
    }
}
