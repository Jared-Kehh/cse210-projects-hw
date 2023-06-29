using System;

class Program
{
    static void Main(string[] args)
    {
        Order orders = new Order();
        Products item = new Products("Lightbulb",195193,10.50,9);
        Products item1 = new Products("Water bottle", 12314, 20, 1);
        Products item2 = new Products("Laptop", 19283, 250, 2);
        Address shipping = new Address("1641 Maple Hill Rd", "Diamond Bar", "CA", "USA");
        Address packinglabel = new Address("289 S 345 E", "Provo", "UT", "USA");
        Customer customer = new Customer("Jared Keh", true, shipping);
        orders.AddProduct(item);
        orders.AddProduct(item1);
        orders.AddProduct(item2);
        orders.DisplayOrder();
        orders.ListingProducts();
        orders.totalCost();
        orders.Info(customer);
    }
}