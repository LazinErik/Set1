using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k, x, m;
            m = 0;
            Console.Write("n= ");
            n= int.Parse(Console.ReadLine());
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());
            x = n;
            while (x > 0)
            {
                x = x / 10;
                m = m + 1;
            }
            if (k > m) Console.WriteLine("Numarul n nu are k cifre");
            else 
            {
                while (k > 1)
                {
                    n = n / 10;
                    k = k - 1;
                }
                Console.WriteLine(n % 10);
            }
        }
    }
}
