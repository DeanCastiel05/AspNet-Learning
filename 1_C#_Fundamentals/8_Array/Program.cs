using System;

class Array
{
    static void Main(string[] args)
    {
        double[] studentGrades = { 89, 80, 78, 90, 85, 92, 95, 75, 99, 77 };
        string[] studentSubjects =
        {
            "Mathematics",
            "Language",
            "Science",
            "History",
            "Geography",
            "Physics",
            "Chemistry",
            "Biology",
            "Physical Education",
            "Social Studies",
        };

        Console.WriteLine("--- Student Grades ---");

        for (int i = 0; i <= studentGrades.Length - 1; i++)
        {
            Console.WriteLine($"{i + 1}. {studentSubjects[i]} = {studentGrades[i]}");
        }

        Console.WriteLine();
        Console.WriteLine("--- Total & GWA ---");
        Console.WriteLine($"Total: {Total(studentGrades)}");
        Console.WriteLine($"Average: {Average(studentGrades)}");

        Console.WriteLine("--- Passed Subjects ---");
        for (int i = 0; i <= studentGrades.Length - 1; i++)
        {
            if (studentGrades[i] >= 75)
            {
                Console.WriteLine($"Passed: {studentSubjects[i]} - {studentGrades[i]}");
            }
        }

        static double Total(double[] grade)
        {
            double total = 0;
            for (int i = 0; i <= grade.Length - 1; i++)
            {
                total += grade[i];
            }
            return total;
        }

        static double Average(double[] total)
        {
            return Total(total) / total.Length;
        }
    }
}
