using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        numbers.Add(num);
        while(num != 0)
        {
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            numbers.Add(num);
        }

        int sum = 0;
        foreach (int sumNum in numbers)
        {
            sum += sumNum;
        }

        Console.WriteLine($"This is the sum of the list: {sum}");

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"Average Number: {average}");

    }
}