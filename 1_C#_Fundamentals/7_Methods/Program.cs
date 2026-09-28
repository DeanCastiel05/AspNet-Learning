using System;

class Methods
{
    static void Main(string[] args)
    {
        double firstNum;
        double secondNum;

        Console.WriteLine("--- Calculator ---");
        Console.Write("Enter Num1: ");
        firstNum = double.Parse(Console.ReadLine()!);
        Console.Write("Enter Num1: ");
        secondNum = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"Add: {firstNum} + {secondNum} = {addNum(firstNum, secondNum)}");
        Console.WriteLine($"Sub: {firstNum} - {secondNum} = {subNum(firstNum, secondNum)}");
        Console.WriteLine($"Mul: {firstNum} * {secondNum} = {mulNum(firstNum, secondNum)}");
        Console.WriteLine($"Div: {firstNum} / {secondNum} = {divNum(firstNum, secondNum)}");
    }

    static double addNum(double firstNum, double secondNum)
    {
        return firstNum + secondNum;
    }

    static double subNum(double firstNum, double secondNum)
    {
        return firstNum - secondNum;
    }

    static double mulNum(double firstNum, double secondNum)
    {
        return firstNum * secondNum;
    }

    static double divNum(double firstNum, double secondNum)
    {
        return firstNum / secondNum;
    }
}
