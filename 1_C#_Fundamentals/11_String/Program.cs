using System;

class actString
{
    static void Main(string[] args)
    {
        enterDetails();
    }

    static void enterDetails()
    {
        while (true)
        {
            string inputName;
            string inputEmail;
            Console.WriteLine("--- Enter Details ---");
            Console.WriteLine("Enter S/s to Stop");
            Console.WriteLine();
            Console.WriteLine("Enter name: ");
            inputName = Console.ReadLine()!;

            if (inputName == "S" || inputName == "s")
            {
                break;
            }

            Console.WriteLine("Enter Email: ");
            inputEmail = Console.ReadLine()!;
            Console.WriteLine();
            Console.WriteLine("--- Upper Case ---");
            Console.WriteLine(inputName.ToUpper().Trim());
            Console.WriteLine(inputEmail.ToUpper().Trim());
            Console.WriteLine();
            Console.WriteLine("--- Lower Case ---");
            Console.WriteLine(inputName.ToLower().Trim());
            Console.WriteLine(inputEmail.ToLower().Trim());
            Console.WriteLine();
            Console.WriteLine("--- Number of Characters ---");
            Console.WriteLine($"Name Char Count: {inputName.Trim().Length}");
            Console.WriteLine($"Email Char Count: {inputEmail.Trim().Length}");
            Console.WriteLine();
            Console.WriteLine("--- Check Space ---");
            if (inputName.Contains(" "))
            {
                Console.WriteLine("Contains Space");
            }
            else
            {
                Console.WriteLine("No Space");
            }
            Console.WriteLine();
            Console.WriteLine("--- Split Name ---");
            string[] nameParts = inputName.Split(" ");
            Console.WriteLine($"First Name: {nameParts[0]}");
            Console.WriteLine();
            Console.WriteLine("--- Check Email ---");
            if (inputEmail.Contains("@") && inputEmail.EndsWith(".com"))
            {
                Console.WriteLine("The email is valid");
            }
            else
            {
                Console.WriteLine("Invalid Email");
            }
            Console.WriteLine();
            Console.WriteLine("--- Replace Space ---");
            Console.WriteLine($"Name with space: {inputName.Trim()}");
            Console.WriteLine($"Name with - : {inputName.Trim().Replace(" ", "-")}");
        }
    }
}
