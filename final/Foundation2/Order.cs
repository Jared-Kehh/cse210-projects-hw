public class Order{
    List<Products> _products = new List<Products>();
    List<Products> _products1 = new List<Products>();
    List<Customer> _customer = new List<Customer>();
    List<Customer> _customer1 = new List<Customer>();
    List<double> prices = new List<double>();
    List<double> prices1 = new List<double>();
    Address shipping = new Address("1641 Maple Hill Rd", "Diamond Bar", "CA", "USA");
    Address packinglabel = new Address("289 S 345 E", "Provo", "UT", "USA");
    Address shipping1 = new Address("131N 343E", "Kennington", "Oxford", "UK");
    double _total = 0;
    double _total1 = 0;

    public void AddProduct(Products product)
    {
        _products.Add(product);
    }
    public void AddProduct1(Products product)
    {
        _products1.Add(product);
    }
    public void ListingProducts(){
        Console.WriteLine("Items: ");
        foreach(Products items in _products){
            Console.WriteLine($"{items._name} x{items._quantity} Product ID:{items._productid}");
        }   
    }
    public void ListingProducts1(){
        Console.WriteLine("Items: ");
        foreach(Products items in _products1){
            Console.WriteLine($"{items._name} x{items._quantity} Product ID:{items._productid}");
        }   
    }

    public void Info(Customer customer){
        _customer.Add(customer);
    }
    public void Info1(Customer customer){
        _customer1.Add(customer);
    }

    public void totalCost()
    {
        foreach(Products itemss in _products){
            prices.Add(itemss._price*itemss._quantity);
        }
        foreach(double _prices in prices){
            int numOne = 0;
            int numTwo = 1;
            _total = _prices + prices[numOne] + prices[numTwo];

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
    public void totalCost1()
    {
        foreach(Products itemsss in _products1){
            prices1.Add(itemsss._price*itemsss._quantity);
        }
        foreach(double _prices in prices1){
            int numOne = 0;
            int numTwo = 1;
            _total1 = _prices + prices1[numOne] + prices1[numTwo];

        }
        if(shipping1._country == "USA")
        {
            _total1 = _total1 + 5;
        }
        else
        {
            _total1 = _total1 + 35;
        }
        Console.WriteLine($"Total Amount: ${_total1}");
    }
    
    public void DisplayOrder(){
        foreach (Customer customerss in _customer){
            Console.WriteLine($"Name: {customerss.name}");
        }
        Console.WriteLine($"Shipped to: {shipping._street}\nPackaged from: {packinglabel._street}");
    }

    public void DisplayOrder1(){
        foreach (Customer customerss in _customer1){
            Console.WriteLine($"Name: {customerss.name}");
        }
        Console.WriteLine($"Shipped to: {shipping1._street}\nPackaged from: {packinglabel._street}");
    }
}