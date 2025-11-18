using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.\n");

        // create addresses
        Address address1 = new Address("Calle Falsa 123", "Moreno", "Buenos Aires", "ARG");
        Address address2 = new Address("Av. Siempre Viva 742", "Córdoba", "Córdoba", "ARG");
        Address address3 = new Address("742 Evergreen Terrace", "Springfield", "Illinois", "USA");

        // create customers
        Customer customer1 = new Customer("Jose", address1);
        Customer customer2 = new Customer("Evelyn", address2);
        Customer customer3 = new Customer("Edward", address3);

        // create products
        Product product1 = new Product("Pencil", 1, 2, 12);
        Product product2 = new Product("Notebook", 2, 5, 20);
        Product product3 = new Product("Eraser", 3, 1, 30);
        Product product4 = new Product("Ruler", 4, 3, 15);
        Product product5 = new Product("Backpack", 5, 25, 5);
        Product product6 = new Product("Markers", 6, 10, 10);
        Product product7 = new Product("Glue Stick", 7, 4, 18);
        Product product8 = new Product("Scissors", 8, 6, 8);
        Product product9 = new Product("Highlighter", 9, 3, 22);

        // create orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        Order order3 = new Order(customer3);

        // populate orders with products
        order1.PopulateList(product1);
        order1.PopulateList(product2);
        order1.PopulateList(product3);
        order2.PopulateList(product4);
        order2.PopulateList(product5);
        order2.PopulateList(product6);
        order2.PopulateList(product7);
        order3.PopulateList(product8);
        order3.PopulateList(product9);

        // display text
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost:");
        Console.WriteLine(order1.ComputeTotalCost());
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost:");
        Console.WriteLine(order2.ComputeTotalCost());
        Console.WriteLine();
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine("Total Cost:");
        Console.WriteLine(order3.ComputeTotalCost());
        Console.WriteLine();


    }
}