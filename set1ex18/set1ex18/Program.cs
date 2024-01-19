using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set1ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, d = 2, p;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            while (n > 1)
            {
                p = 0;
                while (n % d == 0)
                {
                    n = n / d;
                    p++;
                }
                if (p != 0 && n!=1) Console.Write($"{d}^{p} x ");
                else if (p != 0 && n == 1) Console.Write($"{d}^{p}");
                d++;
            }
            Console.WriteLine();    
        }
    }
}
