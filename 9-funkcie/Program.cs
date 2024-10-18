using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_funkcie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calc("+",7,2);

        }
        static void calc(string znak, int c1, int c2)
        {
            int a = 0;
            if (znak == "+")
                a = c1 + c2;
            else if (znak == "-")
                a = c1 - c2;
            else if (znak == "*")
                a = c1 * c2;
            else if (znak == "/")
                a = c1 / c2;
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
