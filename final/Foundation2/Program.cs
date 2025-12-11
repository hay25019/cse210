using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        Console.Clear();
        Order order1 = new Order(new Customer("Peter Hugh Mann", new Address("1234 Wallaby Way", "Sydney", "New South Wales", "Australia")));
        order1.AddProduct(new Product("Hiking Boots", "354810", 60, 1));
        order1.AddProduct(new Product("White Curtain", "684108", 15, 4));
        order1.AddProduct(new Product("Stinky Cheese", "000000", 100, 1));
        orders.Add(order1);

        Order order2 = new Order(new Customer("Annie Kingsley", new Address("8753 Park Way", "New York City", "New York", "United States")));
        order2.AddProduct(new Product("Dell Laptop", "486017", 350, 1));
        order2.AddProduct(new Product("#2 Pencil", "684014", 5, 10));
        order2.AddProduct(new Product("Trampoline Mat", "987654", 50, 1));
        orders.Add(order2);

        Order order3 = new Order(new Customer("Trent Petersen", new Address("2021 Whitmer Drive", "Kansas City", "Missouri", "United States")));
        order3.AddProduct(new Product("Pizza Box (used)", "890318", 3, 300));
        order3.AddProduct(new Product("Old Yogurt", "999999", 100, 2));
        order3.AddProduct(new Product("Broken Chandelier", "160485", 50, 5));
        orders.Add(order3);

        foreach (Order order in orders)
        {
            Console.WriteLine($"Shipping Label:\n{order.GetShippingLabel()}");
            Console.WriteLine($"\nPacking Label:\n{order.GetPackingLabel()}");
            Console.WriteLine($"\nTotal Cost: ${order.CalculateToalCost()}\n");
        }
        
    }
}