using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment Assign1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(Assign1.GetSummary());

        MathAssignment Assign2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(Assign2.GetSummary());
        Console.WriteLine(Assign2.GetHomeworkList());

        WritingAssignment Assign3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(Assign3.GetSummary());
        Console.WriteLine(Assign3.GetWritingInformation());
    }
}