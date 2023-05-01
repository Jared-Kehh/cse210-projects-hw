public class car
{
    //instances 
public string brand;

public int miles;

public string color;

    //constructor
    public car(){

    }

    //Methods (functions)
    public void move_forward(){
        Console.Write("is running");
    }

    public void displayInfo(){
        Console.WriteLine($"brand:{brand} Miles: {miles} Color:{color}");
    }

}