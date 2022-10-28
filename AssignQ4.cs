using System;

class AssignQ4
{
  static void Main()
    {
        int num1, num2, temp;
        Console.WriteLine("\nInput the first number:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("\nInput the second number:");
        num2 = int.Parse(Console.ReadLine());
        temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine("\nAfter swapping:");
        Console.WriteLine("\nfirst number:" + num1);
        Console.WriteLine("\nsecond number:" + num2);
        Console.ReadLine();







    }









}
