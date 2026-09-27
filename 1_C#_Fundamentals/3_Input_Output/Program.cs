using System;

class InputOutput
{
    static void Main(string[] args)
    {
        string name;
        int age;
        double height;
        decimal salary;
        bool isEmployed;
        char initial;

        Console.WriteLine("--- Fill up the following ---");
        Console.Write("Full Name:");
        name = Console.ReadLine()!;
        Console.Write("Age:");
        age = int.Parse(Console.ReadLine()!);
        Console.Write("Height:");
        height = double.Parse(Console.ReadLine()!);
        Console.Write("Salary:");
        salary = decimal.Parse(Console.ReadLine()!);
        Console.Write("Employed?:");
        isEmployed = bool.Parse(Console.ReadLine()!);
        Console.Write("inittial:");
        initial = char.Parse(Console.ReadLine()!);
        Console.WriteLine();

        Console.WriteLine("--- Your Personal Information ---");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Salary: {salary}");
        Console.WriteLine($"Imployed?: {isEmployed}");
        Console.WriteLine($"Initial: {initial}");
    }
}
