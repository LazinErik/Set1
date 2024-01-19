using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set1ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, aux;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine("Valorile dupa interschimbare sunt: a = {0}, b = {1}", a, b);
        }
    }
}
