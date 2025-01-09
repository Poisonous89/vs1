using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace e12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader subor = new StreamReader("C:\\Users\\Anony\\Documents\\e12.txt");
            string[,,] p = new string[5, 1, 2];
            int e = 0;
            int a = 0;
            int b = 0;
            int i = 0;
            while (true)
            {
                string obsah = subor.ReadLine();
                if (obsah == null)
                    break;

                if (string.IsNullOrWhiteSpace(obsah))
                    continue;

                if (e == 0)
                    b = 0;
                else if  (e % 2 == 0)
                    b = 0;
                else
                    b = 1;
                p[a, 0, b] = obsah;
                if (b == 1)
                    a++;
                e++;
            }
            b = 0;
            while (i != 5)
            {
                Console.WriteLine(p[i, 0, b]);
                if (b == 0)
                    b = 1;
                else
                {
                    i++;
                    b = 0;
                    Console.WriteLine("");
                }
            }
            Console.ReadLine();
        }
    }
}
