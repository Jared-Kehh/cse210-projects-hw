using System;

class Program
{
    static void Main(string[] args)
    {
        Outdoor outdoor = new Outdoor("Sunny","Outdoor","Basketball","Playing pick up basketball","July 15, 2023","10am");
        Address address = new Address("3746 Maple Wood St","Kennesaw","GE","USA");
        outdoor.ShortDesc();
        outdoor.StandardDesc();
        address.Display();
        Console.WriteLine();
        outdoor.OutDesc();
        outdoor.StandardDesc();
        Console.WriteLine();
        Console.WriteLine("=======================================================================");

        Lectures lectures = new Lectures("Elder David A. Bednar",150,"Lecture","Devotional","Elder David A. Bednar will talk about becoming faith filled","July 19, 2023","7pm");
        lectures.ShortDesc();
        lectures.StandardDesc();
        Console.WriteLine();
        lectures.LecDesc();
        lectures.StandardDesc();
        Console.WriteLine();
        Console.WriteLine("=======================================================================");

        Reception reception = new Reception("kehjaredjk@gmail.com","Reception","Wedding","My friend is getting married at the Provo City Temple","July 21, 2023","7pm");
        reception.ShortDesc();
        reception.StandardDesc();
        Console.WriteLine();
        reception.RecpDesc();
        reception.StandardDesc();
        Console.WriteLine();
        Console.WriteLine("=======================================================================");
    }
}