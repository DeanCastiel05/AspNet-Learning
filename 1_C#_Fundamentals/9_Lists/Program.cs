using System;
using System.Collections.Generic;

class ListSample
{
    static void Main(string[] args)
    {
        List<string> studentNames = new();
        funcMenu(studentNames);
    }

    static void addStudent(List<string> names)
    {
        bool stopper = true;
        char keyCheck;
        string studentNames;
        Console.WriteLine("--- Enter Students Name ---");
        while (stopper == true)
        {
            Console.Write("Add Student? Y/N: ");
            keyCheck = char.Parse(Console.ReadLine()!);
            if (stopper == true && (keyCheck == 'Y' || keyCheck == 'y'))
            {
                Console.Write("Enter Name: ");
                studentNames = Console.ReadLine()!;
                names.Add(studentNames);
                Console.WriteLine();
            }
            else
            {
                stopper = false;
                break;
            }
        }
        funcMenu(names);
    }

    static void displayStudents(List<string> names)
    {
        Console.WriteLine("--- Student Names ---");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine($"Total: {names.Count}");
        funcMenu(names);
    }

    static void removeStudents(List<string> names)
    {
        string input;
        while (true)
        {
            Console.Write("Enter the number to remove: ");
            Console.WriteLine();
            input = Console.ReadLine()!;
            if (input == "n")
            {
                break;
            }
            int studentNumber = int.Parse(input);
            names.RemoveAt(studentNumber - 1);
        }
        funcMenu(names);
    }

    static void funcMenu(List<string> menus)
    {
        char keyLog;
        while (true)
        {
            Console.Write("Choices: Add 'A' | Remove 'R' | Display 'D' | Check 'C' | Stop 'S'");
            keyLog = char.Parse(Console.ReadLine()!);
            Console.WriteLine();
            if (keyLog == 'A' || keyLog == 'a')
            {
                addStudent(menus);
            }
            else if (keyLog == 'R' || keyLog == 'r')
            {
                removeStudents(menus);
            }
            else if (keyLog == 'D' || keyLog == 'd')
            {
                displayStudents(menus);
            }
            else if (keyLog == 'C' || keyLog == 'c')
            {
                checkStudents(menus);
            }
            else if (keyLog == 'S' || keyLog == 's')
            {
                break;
            }
        }
    }

    static void checkStudents(List<string> names)
    {
        string input;
        while (true)
        {
            Console.Write("Enter the name you want to check: ");
            Console.WriteLine();
            input = Console.ReadLine()!;
            if (input == "n")
            {
                break;
            }
            names.Contains(input);
            if (names.Contains(input))
            {
                Console.WriteLine("The student is in the List");
            }
            else
            {
                Console.WriteLine("The students is not in the List");
            }
        }
        funcMenu(names);
    }
}
