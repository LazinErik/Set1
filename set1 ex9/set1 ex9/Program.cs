using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set1_ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, d;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write($"Divizorii lui {n} sunt: ");
            for (d = 1; d <= n; d++)
            {
                if (n % d == 0) Console.Write($"{d} ");
            }
            Console.WriteLine();
        }
    }
}
