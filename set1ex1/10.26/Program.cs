using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, x;
            Console.Write("Sa se introduca valoarea lui a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Sa se introduca valoarea lui b: ");
            b = float.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0) Console.WriteLine("Ecuatie nedeterminata");
                else Console.WriteLine("Ecuatie imposibila");
            }
            else {
                x = -b / a;
                Console.WriteLine("Solutia ecuatiei este x = {0}", x);
            }
        }
    }

    
}
