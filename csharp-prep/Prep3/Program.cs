using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.Write("What is the magic number? ");
        int magicNum = int.Parse(Console.ReadLine());
        Console.Write("What is your guess? ");
        int guessNum = int.Parse(Console.ReadLine());
        if (guessNum > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNum < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Congrats!");
            }
        
        while (magicNum != guessNum)
        {
            Console.Write("What is your guess? ");
            guessNum = int.Parse(Console.ReadLine());

            if (guessNum > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNum < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Congrats!");
            }

        }
    }
}