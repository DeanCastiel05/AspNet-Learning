using System;

class Conditions
{
    static void Main(string[] args)
    {
        string name;
        int grade;

        Console.WriteLine("--- Grade Evaluator ---");
        Console.Write("Name: ");
        name = Console.ReadLine()!;
        Console.Write("Grade: ");
        grade = int.Parse(Console.ReadLine()!);
        Console.WriteLine();
        Console.WriteLine($"Name: {name}");
        if (grade >= 90)
        {
            Console.WriteLine($"{grade}: Excellent");
        }
        else if (grade >= 80 && grade <= 89)
        {
            Console.WriteLine($"{grade}: Good");
        }
        else if (grade >= 75 && grade <= 79)
        {
            Console.WriteLine($"{grade}: Passed");
        }
        else
        {
            Console.WriteLine($"{grade}: Failed");
        }
    }
}
