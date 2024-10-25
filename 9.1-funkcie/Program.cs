using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1_funkcie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* uloha spravit hru 2 hracov v hode kockou ktora moze vydat hodnotu 1-6
              s opakovanim hodu pri cisle 6, hraci sa striedaju po hodoch a hrac vyhrava
            pri dosiahnut skore 100 */

           
            Console.WriteLine(hod());
            Console.ReadLine();
        }


        static int hod() 
        {
            
            int hod = r.Next(1, 7);
            while (hod == 6)
            {
                hod =hod + r.Next(1, 7);
            }
            return hod;
        }
    }
}
