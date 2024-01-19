using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cifminmax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m, min = 9, max = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            m = n;
            while (m > 0)
            {
                if (m % 10 > max) max = m % 10;
                else if (m % 10 < min) min = m % 10;
                m = m / 10;
            }
            Console.WriteLine($"Cifra minima a numarului {n} este {min}");
            Console.WriteLine($"Cifra maxima a numarului {n} este {max}");
        }
    }

}
