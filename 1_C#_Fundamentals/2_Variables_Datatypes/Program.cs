using System;

class PersonalInfo
{
    static void Main(string[] args)
    {
        string name = "Juan Dela Cruz";
        int age = 24;
        double height = 5.4;
        decimal salary = 20000;
        bool isEmployed = true;
        char initial = 'C';

        Console.WriteLine("--- Personal Information ---");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Salary: {salary}");
        Console.WriteLine($"Employed?: {isEmployed}");
        Console.WriteLine($"Initial: {initial}");
    }
}
