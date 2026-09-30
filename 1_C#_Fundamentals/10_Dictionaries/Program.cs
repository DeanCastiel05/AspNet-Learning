using System;
using System.Collections.Generic;

class actDictionary
{
    static Dictionary<int, int> gradeDictionary = new();

    static void Main(string[] args)
    {
        funcMenu(gradeDictionary);
    }

    static void funcMenu(Dictionary<int, int> items)
    {
        while (true)
        {
            Console.WriteLine("-- Choose an Action --");
            Console.WriteLine(
                "Add 'A' | Remove 'R' | Display 'D' | Update 'U' | Check 'C' | Stop 'S'"
            );

            string key;
            key = Console.ReadLine()!;

            if (key == "S" || key == "s")
            {
                break;
            }
            else if (key == "R" || key == "r")
            {
                removeStudents(items);
            }
            else if (key == "D" || key == "d")
            {
                displayStudents(items);
            }
            else if (key == "U" || key == "u")
            {
                updateStudents(items);
            }
            else if (key == "C" || key == "c")
            {
                searchStudents(items);
            }
            else if (key == "A" || key == "a")
            {
                addStudents(items);
            }
        }
    }

    static void addStudents(Dictionary<int, int> items)
    {
        Console.WriteLine("--- Add Student ---");
        Console.WriteLine("Enter 'S/s' to Stop");
        while (true)
        {
            string firstInput;
            string secondInput;
            int studentId;
            int studentGrade;

            Console.Write("Enter student ID: ");
            firstInput = Console.ReadLine()!;
            if (firstInput == "S" || firstInput == "s")
            {
                break;
            }

            Console.Write("Enter Student Grade: ");
            secondInput = Console.ReadLine()!;

            studentId = int.Parse(firstInput);
            studentGrade = int.Parse(secondInput);
            items.Add(studentId, studentGrade);
        }
    }

    static void displayStudents(Dictionary<int, int> items)
    {
        Console.WriteLine("--- Students Lists ---");
        Console.WriteLine("- ID -- Grade -");
        foreach (var item in items)
        {
            Console.WriteLine($" {item.Key} - {item.Value} ");
        }
        Console.WriteLine($"Total: {items.Count}");
    }

    static void searchStudents(Dictionary<int, int> items)
    {
        while (true)
        {
            string key;
            int studentId;
            Console.WriteLine("--- Search ID ---");
            Console.WriteLine("Enter 'S/s' to Stop");
            Console.Write("Enter Student ID: ");
            key = Console.ReadLine()!;
            if (key == "s" || key == "S")
            {
                break;
            }
            studentId = int.Parse(key);
            if (items.ContainsKey(studentId))
            {
                Console.WriteLine($"ID: {studentId} Grade: {items[studentId]}");
            }
        }
    }

    static void removeStudents(Dictionary<int, int> items)
    {
        while (true)
        {
            string key;
            int studentId;
            Console.WriteLine("--- Remove ID ---");
            Console.WriteLine("Enter 'S/s' to Stop");
            Console.Write("Enter Student ID: ");
            key = Console.ReadLine()!;
            if (key == "s" || key == "S")
            {
                break;
            }
            studentId = int.Parse(key);
            if (items.ContainsKey(studentId))
            {
                items.Remove(studentId);
                Console.WriteLine("Item has been removed");
            }
        }
    }

    static void updateStudents(Dictionary<int, int> items)
    {
        while (true)
        {
            string key;
            int studentId;
            Console.WriteLine("--- Update ID Grade ---");
            Console.WriteLine("Enter 'S/s' to Stop");
            Console.Write("Enter Student ID: ");
            key = Console.ReadLine()!;
            if (key == "s" || key == "S")
            {
                break;
            }
            studentId = int.Parse(key);
            if (items.ContainsKey(studentId))
            {
                Console.WriteLine($"ID: {studentId} - Grade: {items[studentId]}");
                Console.Write("Enter new Grade: ");
                items[studentId] = int.Parse(Console.ReadLine()!);
                Console.WriteLine($"ID {studentId} value has been updated to {items[studentId]}");
            }
        }
    }
}
