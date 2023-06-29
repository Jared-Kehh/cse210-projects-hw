public class Order{
    List<Products> _products = new List<Products>();
    List<Customer> _customer = new List<Customer>();
    Address shipping = new Address("1641 Maple Hill Rd", "Diamond Bar", "CA", "USA");
    Address packinglabel = new Address("289 S 345 E", "Provo", "UT", "USA");
    double _total = 0;

    public void AddProduct(Products product)
    {
        _products.Add(product);
    }
    public void ListingProducts(){
        Console.WriteLine("Items: ");
        foreach(Products items in _products){
            Console.WriteLine(items._name);
        }
    }

    public void Info(Customer customer){
        _customer.Add(customer);
    }

    public void totalCost()
    {
        foreach(Products itemss in _products){
            _total = itemss._price*itemss._quantity;
        }
        if(shipping._country == "USA")
        {
            _total = _total + 5;
        }
        else
        {
            _total = _total + 35;
        }
        Console.WriteLine($"Total Amount: ${_total}");
    }
    
    public void DisplayOrder(){
        Console.WriteLine($"Shipped to: {shipping._street}\nPackaged from: {packinglabel._street}");


    }

}