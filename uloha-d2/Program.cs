using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace uloha_d2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader subor = new StreamReader("C:\\Users\\skutas23\\d2.txt");
            List<string> typ = new List<string>();
            List<string> kategoria = new List<string>();
            int cicavec = 0;
            int ryba = 0;
            int vtak = 0;
            string a;

            while (true)
            {
                string obsah = subor.ReadLine();
                if (obsah == null) 
                    break;

                string[] poleStringov1Riadku = obsah.Split('-');

                typ.Add(poleStringov1Riadku[0]); 
                kategoria.Add(poleStringov1Riadku[1]); 
    
            }
            /*foreach (var item in typ)
                Console.WriteLine(item);
            foreach (var item in kategoria)
                Console.WriteLine(item);*/
            for (int i = 0; i < typ.Count; i++)
            {
                Console.WriteLine($"{typ[i]}    {kategoria[i]}");
            }
            for (int i = 0; i < typ.Count; i++)
            {
                if (kategoria[i] == "cicavec")
                    cicavec++;
                else if (kategoria[i] == "vtak")
                    vtak++;
                else
                    ryba++;
            }
            var aTyp = typ.OrderBy(x => x).ToList();
            var bTyp = typ.OrderByDescending(x => x).ToList();
            Console.WriteLine("");
            Console.WriteLine("Cicavcov: " + cicavec);
            Console.WriteLine("Ryb: " + ryba);
            Console.WriteLine("Vtakov: " + vtak);
            Console.WriteLine("");
            Console.WriteLine("AK chcete zoradit od a alebo z zadajte do konzoly ZoradOdA/ZoradOdZ alebo ak chcete ukoncit tak zadajte koniec");
            a = Console.ReadLine();
            if (a == "ZoradOdA")
                foreach (var item in aTyp)
                {
                    Console.WriteLine(item);
                }
            else if (a == "ZoradOdZ")
                foreach (var item in bTyp)
                {
                    Console.WriteLine(item);
                }


            subor.Close();
        }
    }
}
