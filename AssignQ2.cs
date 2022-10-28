using System;
using System.Linq;

class AssignQ2
{
  static void Main()
    {
        Console.WriteLine("Average marks of 5 students");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        int e = Convert.ToInt32(Console.ReadLine());
        int[] average = { a, b, c, d, e };
        Console.WriteLine("Maximum marks obtained are", +average.Max());
        Console.ReadLine();



    }  














}
