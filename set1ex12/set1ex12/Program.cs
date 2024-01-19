using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set1ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, i, k = 0;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for (i = a; i <= b; i++)
            {
                if (i % n == 0) k++;
            }
            Console.WriteLine($"In intervalul [{a},{b}] sunt {k} numere divizibile cu {n}");
        }
    }
}
