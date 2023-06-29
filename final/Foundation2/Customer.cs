public class Customer{

   private string name;
   Address _address = new Address("", "", "", "");
   bool _livingUSA = true;
   public Customer(string _name, bool livingUSA, Address address){
    _address = address;
    name = _name;
    _livingUSA = livingUSA;
   }
   
}