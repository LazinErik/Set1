using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set1ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                Console.Write(n % 10);
                n = n / 10;
            }
            Console.WriteLine();
        }
    }
}
