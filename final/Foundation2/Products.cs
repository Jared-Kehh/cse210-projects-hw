public class Products{
    public string _name;
    public int _productid;
    public double _price;
    public int _quantity;
    public double _total;
    public Products(string name, int productid, double price, int quantity){
        _name = name;
        _productid = productid;
        _price = price;
        _quantity = quantity;
    }
    public void totalProducts()
    {
        _total = _price*_quantity;
        Console.WriteLine(_total);
    }
}

