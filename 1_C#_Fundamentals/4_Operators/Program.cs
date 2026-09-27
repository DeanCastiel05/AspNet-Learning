using System;

class Operator
{
    static void Main(string[] args)
    {
        string productName;
        decimal productPrice;
        int quantity;
        decimal payment;

        Console.WriteLine("--- Enter Product Details ---");
        Console.Write("Item: ");
        productName = Console.ReadLine()!;
        Console.Write("Price: ");
        productPrice = decimal.Parse(Console.ReadLine()!);
        Console.Write("Quantity: ");
        quantity = int.Parse(Console.ReadLine()!);
        Console.Write("Payment: ");
        payment = decimal.Parse(Console.ReadLine()!);
        Console.WriteLine();

        double subtotal = (double)productPrice * quantity;
        double discount = subtotal * 0.10;
        double finalTotal = (double)subtotal - (double)discount;
        decimal remainingAmount = payment - (decimal)finalTotal;

        Console.WriteLine();
        Console.WriteLine("=== Purchase Details ===");
        Console.WriteLine($"Item: {productName}");
        Console.WriteLine($"Price: {productPrice}");
        Console.WriteLine($"Quantity: {quantity}");
        Console.WriteLine($"Payment: {payment}");
        Console.WriteLine("------- Discount -------");
        Console.WriteLine($"Discount 10%: {discount}");
        Console.WriteLine($"Total: {finalTotal}");
        Console.WriteLine("------- Balance --------");
        Console.WriteLine($"Amount: {remainingAmount}");
        Console.WriteLine("========================");
    }
}
