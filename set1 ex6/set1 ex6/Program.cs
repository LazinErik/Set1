using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set1_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("a=");
            a= int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());
            if (a < b + c && b < a + c && c < a + b) Console.WriteLine($"Numerele {a},{b},{c} pot fi laturile unui triunghi");
            else Console.WriteLine($"Numerele {a},{b},{c} NU pot fi laturile unui triunghi");
        }
    }
}
