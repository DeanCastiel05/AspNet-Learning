using System;

class Loops
{
    static void Main(string[] args)
    {
        int numInput;

        Console.WriteLine("--- Multiplication ---");
        Console.Write("Number: ");
        numInput = int.Parse(Console.ReadLine()!);
        Console.WriteLine();

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numInput} x {i} = {numInput * i}");
        }
    }
}
