using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            //int[] cisla = new int[100];

            int[] trpaslici = new int[7];

            for (int i = 0; i < trpaslici.Length; i++)
                trpaslici[i] = r.Next(50, 100);

            int a = trpaslici[0];

            for (int i = 0; i < trpaslici.Length; i++)
                if (trpaslici[i + 1] > trpaslici[i])
                    a = trpaslici[i];
                    

            Console.WriteLine("Najmensi trpaslik mal " + a.ToString() + "cm");
        }
    }
}
