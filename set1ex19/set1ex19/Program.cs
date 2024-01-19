using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set1ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k=0;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            int[] fr = new int[10];
            int n_init = n;
            while (n!=0)
            {
                fr[n % 10]++;
                n = n / 10;
            }
            for (int i = 0; i <= 9; i++)
            {
                if (fr[i] != 0) k++;
            }
            if (k == 2) Console.WriteLine($"Numarul {n_init} este format doar cu doua cifre care se pot repeta");
            else Console.WriteLine($"Numarul {n_init} NU este format doar cu doua cifre care se pot repeta");
        }
    }
}
