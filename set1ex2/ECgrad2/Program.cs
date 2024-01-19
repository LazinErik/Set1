using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECgrad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2;
            float a, b, c, delta;
            Console.Write("a=");
            a = float.Parse(Console.ReadLine());
            Console.Write("b=");
            b = float.Parse(Console.ReadLine());
            Console.Write("c=");
            c = float.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    if (c == 0) Console.WriteLine("Ecuatie nedeterminata");
                    else Console.WriteLine("Ecuatie imposibila");
                else
                {
                    x1 = -c / b;
                    Console.WriteLine("Ecuatia de gradul I cu solutia: x1 = {0}", x1);
                }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0) Console.WriteLine("Ecuatia are solutii complexe");
                else
                {
                    if (delta == 0)
                    {
                        x1 = -b / (2 * a);
                        x2 = -b / (2 * a);
                        Console.WriteLine("Solutiile ecuatiei sunt: x1 = {0}, x2 = {0}", x1, x2);
                    }
                    else 
                    {
                        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine("Solutiile ecuatiei sunt: x1 = {0}, x2 = {1}", x1, x2);
                    }
                }                
            }

        }
    }
}
