using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _9._9_cv
{
    class Program
    {
        static void Main(string[] args)
        {
            /*StreamReader subor = new StreamReader("C:\\Users\\skutas23\\t.txt");

            while (true)
            {
                string obsah = subor.ReadLine(); // nacitanie celeho riadku

                if (obsah == null) // test, ci nie je koniec suboru
                    break; // ukoncenie zacykleneho nekonecneho cyklu

                Console.WriteLine(obsah); // vypis nacitaneho riadku            
            }
            subor.Close();*/




            int pokusov = 0;
            Random r = new Random();
            int hladane = r.Next(0, 100);
            while (true)
            {
                Console.WriteLine("zadaj cislo");
                int zadane = int.Parse(Console.ReadLine());

                if (rnd == a)
                    Console.WriteLine("cislo je rovne, GRATULUJEM");
                //Console.WriteLine("uhadol si na");
                //Console.WriteLine("zadal si mensie cislo");
                else if (rnd < a)
                    Console.WriteLine("zadal si vacsie cislo");
                else
                    Console.WriteLine("zadal si mensie cislo");
            }
                

        }
    }
}
