using System;

class Program
{
    static void Main(string[] args)
    {
        Outdoor outdoor = new Outdoor("Sunny","Outdoor","Basketball","Playing pick up basketball","July 15, 2023","10am");
        Address address = new Address("3746 Maple Wood St","Kennesaw","GE","USA");
        outdoor.shortDesc();
        outdoor.standardDesc();
        address.Display();
        Console.WriteLine();
        outdoor.outDesc();
        outdoor.standardDesc();
        Console.WriteLine();
        Console.WriteLine("=======================================================================");

        Lectures lectures = new Lectures("Elder David A. Bednar",150,"Lecture","Devotional","Elder David A. Bednar will talk about becoming faith filled","July 19, 2023","7pm");
        lectures.shortDesc();
        lectures.standardDesc();
        Console.WriteLine();
        lectures.lecDesc();
        lectures.standardDesc();
        Console.WriteLine();
        Console.WriteLine("=======================================================================");

        Reception reception = new Reception("kehjaredjk@gmail.com","Reception","Wedding","Friend is getting married at the Provo City Temple","July 21, 2023","7pm");
        reception.shortDesc();
        reception.standardDesc();
        Console.WriteLine();
        reception.recDesc();
        reception.standardDesc();
        Console.WriteLine();
        Console.WriteLine("=======================================================================");
    }
}