using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments1
{
    internal class Class1
    {
        static void Main()
        {
            int n = 5, a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} is a prime number", n);
            }
            else
            {
                Console.WriteLine("Not a prime number");
            }
            Console.ReadLine();

        }

    }
}
