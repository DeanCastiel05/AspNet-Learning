using System;
using System.Collections.Generic;

class ActConstructors
{
    static List<Students> studentDataBase = new();

    static void Main(string[] args)
    {
        fncMenu();
    }

    static void fncMenu()
    {
        while (true)
        {
            string checkKey;
            Console.WriteLine("Menu: Add 'A' | Display 'D' | Stop 'S'");
            checkKey = Console.ReadLine()!;
            if (checkKey == "S" || checkKey == "s")
            {
                break;
            }
            else if (checkKey == "A" || checkKey == "a")
            {
                addStudent();
            }
            else if (checkKey == "D" || checkKey == "d")
            {
                loopDisplay();
            }
        }
    }

    static void addStudent()
    {
        Console.WriteLine("--- Add Students ---");
        Console.WriteLine("Enter S/s to stop");
        while (true)
        {
            string addName;
            int addId;
            int addGrade;

            Console.Write("Name: ");
            addName = Console.ReadLine()!;
            if (addName == "S" || addName == "s")
            {
                break;
            }
            Console.Write("ID: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out addId))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You Entered wrong type, try again");
                    Console.Write("ID: ");
                }
            }

            Console.Write("Grade: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out addGrade))
                {
                    if (addGrade < 0 || addGrade > 100)
                    {
                        Console.WriteLine("Invalid Range, Please input 0-100");
                        Console.Write("Grade: ");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("You Entered wrong type, try again");
                    Console.Write("Grade: ");
                }
            }
            Console.WriteLine();

            Students s2 = new Students(addName, addId, addGrade);
            studentDataBase.Add(s2);
        }
    }

    static void loopDisplay()
    {
        Console.WriteLine("--- Student List ---");
        foreach (var item in studentDataBase)
        {
            item.displayStudent();
            item.studentStatus();
            Console.WriteLine();
        }
    }
}

class Students
{
    public string studentName;
    public int studentId;
    public int studentGrade;

    public Students(string studentName, int studentId, int studentGrade)
    {
        this.studentName = studentName;
        this.studentId = studentId;
        this.studentGrade = studentGrade;
    }

    public void displayStudent()
    {
        Console.WriteLine($"Name: {studentName}");
        Console.WriteLine($"ID: {studentId}");
        Console.WriteLine($"Grade: {studentGrade}");
    }

    public void studentStatus()
    {
        Console.WriteLine($"Status: {(studentGrade >= 75 ? "Passed" : "Failed")}");
    }
}
