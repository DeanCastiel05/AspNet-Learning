using System;
using System.Collections.Generic;

class classObject
{
    static List<Students> studentList = new(); // Student is an Object and Object is a reference type List<T>, T = type

    static void Main(string[] args)
    {
        fncMenu(studentList); //fncMenu is static fucntion and it cal only access and called on same type
    }

    static void fncMenu(List<Students> studentList) // function (type variable) students is Object, since i have to access the same list on different function, i have to use the same object to access the list
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
                createStudent(studentList);
            }
            else if (checkKey == "D" || checkKey == "d")
            {
                displayStudents();
            }
        }
    }

    static void createStudent(List<Students> studentList)
    {
        string enterName = "";
        int enterGrade;
        int enterId;

        while (true)
        {
            Console.WriteLine("--- Enter Details ---");
            Console.WriteLine("Enter S/s to Stop");
            Console.Write("Name: ");
            enterName = Console.ReadLine()!;
            if (enterName == "S" || enterName == "s")
            {
                break;
            }
            Console.Write("Grade: ");
            while (true)
            {
                try
                {
                    if (int.TryParse(Console.ReadLine(), out enterGrade))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Emter Number only");
                        Console.Write("Grade: ");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error Happened");
                }
            }
            Console.Write("ID: ");
            while (true)
            {
                try
                {
                    if (int.TryParse(Console.ReadLine(), out enterId))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Emter Number only");
                        Console.Write("Grade: ");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error Happened");
                }
            }

            Students s1 = new();
            s1.studentName = enterName;
            s1.studentGrade = enterGrade;
            s1.studentId = enterId;
            s1.studentStats = s1.studentStatus();

            studentList.Add(s1);
        }
    }

    static void displayStudents()
    {
        foreach (var item in studentList)
        {
            item.studentDisplay();
            Console.WriteLine();
        }
    }
}

class Students
{
    public string studentName = "";
    public int studentGrade;
    public int studentId;
    public string studentStats = "";

    public void studentDisplay()
    {
        Console.WriteLine($"Name: {studentName}");
        Console.WriteLine($"Grade: {studentGrade}");
        Console.WriteLine($"ID: {studentId}");
        Console.WriteLine($"Status: {studentStats}");
    }

    public string studentStatus()
    {
        return (studentGrade < 75 ? "Failed" : "Passed");
    }
}
