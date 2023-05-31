using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("274 Main St", "Windsor", "CA", "289015", "USA");
        Customer customer = new Customer("Lincoln T. Wilson", address);
        Order order = new Order(customer);

        Product product1 = new Product("Lenovo IdeaPad G5045 Dual Core 15.6 Inch Laptop", 306.99m, 2, 1);
        Product product2 = new Product("TechPP", 14.99m, 1, 2);

        order.AddProduct(product1);
        order.AddProduct(product2);

        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine($"Total cost: {order.GetTotalPrice():C}");
    }
}