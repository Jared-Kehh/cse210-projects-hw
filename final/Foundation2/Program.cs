using System;

class Program
{
    static void Main(string[] args)
    {
        Order orders = new Order();
        Products item = new Products("Lightbulb",195193,10.50,9);
        Products item1 = new Products("Water bottle", 12314, 20, 1);
        Products item2 = new Products("Laptop", 19283, 250, 2);
        Products item3 = new Products("Phone", 149185, 50, 4);
        Products item4 = new Products("Mouse", 12945, 30, 5);
        Products item5 = new Products("Minecraft", 14582, 40, 4);
        Address shipping = new Address("1641 Maple Hill Rd", "Diamond Bar", "CA", "USA");
        Address shipping1 = new Address("131N 343E", "Kennington", "Oxford", "UK");
        Address packinglabel = new Address("289 S 345 E", "Provo", "UT", "USA");
        Customer customer = new Customer("Jared Keh", true, shipping);
        Customer customer1 = new Customer("Lee Chan", true, shipping1);
        orders.AddProduct(item);
        orders.AddProduct(item1);
        orders.AddProduct(item2);
        orders.Info(customer);
        orders.DisplayOrder();
        orders.ListingProducts();
        orders.totalCost();
        Console.WriteLine("===================================");
        orders.AddProduct1(item3);
        orders.AddProduct1(item4);
        orders.AddProduct1(item5);
        orders.Info1(customer1);
        orders.DisplayOrder1();
        orders.ListingProducts1();
        orders.totalCost1();
    }
}