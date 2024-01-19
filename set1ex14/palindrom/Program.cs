using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, ogl = 0;
            Console.Write("n=");
            n=int.Parse(Console.ReadLine());
            int n_init = n;
            while (n != 0)
            {
                ogl = ogl * 10 + n % 10;
                n = n / 10;
            }
            if (ogl == n_init) Console.WriteLine($"Numarul {n_init} este palindrom");
            else Console.WriteLine($"Numarul {n_init} NU este palindrom");
        }
    }
}
