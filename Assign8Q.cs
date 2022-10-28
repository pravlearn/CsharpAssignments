using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments1
{
    internal class Assign8Q
    {
      static void Main()
        {
            int a, b;
            Console.WriteLine("Enter two numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine("{0} is the largest number", a);
            }
            else
            {
                Console.WriteLine("{0} is the largest number", b);


            }
            Console.ReadLine();

















        }






    }
}
