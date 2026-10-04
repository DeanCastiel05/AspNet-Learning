using System;
using System.Collections.Generic;

class exeptHandling
{
    static void Main(string[] args)
    {
        List<int> listNum = new();
        List<string> listName = new();

        funcMenu(listName, listNum);
    }

    static void funcMenu(List<string> item1, List<int> item2)
    {
        Console.WriteLine("--- Menu ---");
        while (true)
        {
            Console.WriteLine("Add 'A' | Display 'D' | Stop 'S'");
            string menuKey = Console.ReadLine()!;
            if (menuKey == "S" || menuKey == "s")
            {
                break;
            }
            else if (menuKey == "A" || menuKey == "a")
            {
                enterDetails(item1, item2);
            }
            else if (menuKey == "D" || menuKey == "d")
            {
                displayData(item1, item2);
            }
        }
    }

    static void enterDetails(List<string> item1, List<int> item2)
    {
        Console.WriteLine("--- Enter Student Details ---");
        Console.WriteLine("Enter S/s to stop");
        while (true)
        {
            string nameDetail;
            string gradeDetail;
            int gradeParsed;
            Console.Write("Name : ");
            nameDetail = Console.ReadLine()!;

            if (nameDetail == "S" || nameDetail == "s")
            {
                break;
            }

            Console.Write("Grade : ");

            while (true)
            {
                try
                {
                    gradeDetail = Console.ReadLine()!;
                    if (int.TryParse(gradeDetail, out gradeParsed))
                    {
                        if (gradeParsed < 0 || gradeParsed > 100)
                        {
                            Console.WriteLine(
                                $"You entered {gradeParsed} that is invalid try again!"
                            );
                            Console.WriteLine("Enter numbers only from 0-100");
                            Console.Write("Grade : ");
                        }
                        else
                        {
                            item1.Add(nameDetail.Trim());
                            item2.Add(gradeParsed);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Retry!");
                        Console.WriteLine("Enter numbers only from 1-100");
                        Console.Write("Grade : ");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("There is an error");
                }
                finally
                {
                    Console.WriteLine($"Total: {item1.Count}");
                }
            }
            Console.WriteLine();
        }
    }

    static void displayData(List<string> item1, List<int> item2)
    {
        Console.WriteLine();
        Console.WriteLine("--- Student Info ---");
        if (item1.Count == 0)
        {
            Console.WriteLine("No data yet, Add data");
        }
        Console.WriteLine("   Name - Grade");
        for (int i = 0; i <= item1.Count - 1; i++)
        {
            Console.WriteLine(
                $"{i + 1}. {item1[i]} - {item2[i]} - {(item2[i] >= 75 ? "Passed" : "Failed")}"
            );
        }
        Console.WriteLine();
    }
}
