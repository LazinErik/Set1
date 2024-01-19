using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifegale
{
    internal class Program
    {
        public int egale(int x);
        { 
            int c, uc, ucl;
            c = 1;
            ucl = x%10;
            while(x!=0)
            {
                uc=x%10;
                if(uc != ucl) c=0;
                x=x/10;
            }
            return c;
        }
    } 
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Introduceti un nr:");
            n = int.Parse(Console.ReadLine());
            var t = new Program();
            if (t.egale(n) == 1) Console.WriteLine("Cifre egale");
            else Console.WriteLine("Cifrele nu sunt egale");
}
}

