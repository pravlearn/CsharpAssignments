using System;

class AssignQ3
{
    static void Main()
    {
        int[] a = new int[100];
        int i, n, sum = 0;
        Console.WriteLine("Enter array limit:");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input {0} elements in the array:\n", n);
        for (i = 0; i<n; i++)
        {
            Console.WriteLine("Enter the numbers as per your limit {0}:", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (i=0; i<n; i++)
        { 
            sum += a[i];
        }
        Console.WriteLine("Sum of all elements stored in the array is : {0}\n\n", sum);






    }
}