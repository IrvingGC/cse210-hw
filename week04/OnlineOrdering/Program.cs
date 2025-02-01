using System;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Product product1 = new Product("Laptop", 10, 550, 1);
            Product product2 = new Product("TV Screen", 11, 600, 1);
            Product product3 = new Product("Milk", 12, 4, 2);

            
            Address address1 = new Address("525 Circle Av", "Chicago", "IL", "USA");
            Address address2 = new Address("N 2nd W", "Idaho Falls", "ID", "USA");

            
            Customer customer1 = new Customer("Mariana", address1);
            Customer customer2 = new Customer("Alejandro", address2);

            
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product3);

            
            Console.WriteLine("Order 1:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}\n");

            Console.WriteLine("Order 2:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}");
        }
    }
}