using System;

namespace Foundation2
{
    class Program
    {
        static void Main()
        {
            List<Product> products1 = new List<Product>();
            List<Product> products2 = new List<Product>();

            Product product1 = new Product("Table", 1, 749.00, 1);
            Product product2 = new Product("Chair", 2, 49.99, 4);
            Product product3 = new Product("Cutlery Set", 3, 21.99, 2);
            Product product4 = new Product("Napkins", 4, 0.50, 100);

            products1.Add(product1);
            products1.Add(product2);
            products1.Add(product3);
            products2.Add(product2);
            products2.Add(product3);
            products2.Add(product4);

            Address address1 = new Address("914 Rock Ct.", "Antioch", "California", "USA");
            Address address2 = new Address("2-21-1 Shibuya Scramble Square", "Shibuya", "Tokyo", "Japan");

            Customer customer1 = new Customer("Tyler Wright", address1);
            Customer customer2 = new Customer("Sora Arai", address2);

            Order order1 = new Order(products1, customer1);
            Order order2 = new Order(products2, customer2);

            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine(order1.GetTotalPrice());
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine(order2.GetTotalPrice());
        }
    }
}