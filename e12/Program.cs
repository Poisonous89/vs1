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
            StreamReader subor = new StreamReader("C:\\Users\\skutas23\\e12.txt");
            string[,,] p = new string[5, 1, 2];
            var listik = new List<string> { "0", "1", "2", "3", "4" };
            var zapis = new List<string>();
            listik = listik.OrderBy(i => Guid.NewGuid()).ToList();
            int e = 0;
            int a = 0;
            int b = 0;
            int d = 0;
            int f = 0;
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
            /*while (d != 5)
            {
                Console.WriteLine(p[d, 0, b]);
                if (b == 0)
                    b = 1;
                else
                {
                    d++;
                    b = 0;
                    Console.WriteLine("");
                }
            }
            for (int i = 0; i < 10; i++)*/
            while(d != 5)
            {
                f = Int32.Parse(listik[d]);
                zapis.Add(p[f, 0, b]);
                Console.WriteLine(p[f, 0, b]);
                if (b == 0)
                    b = 1;
                else
                {
                    d++;
                    b = 0;
                    zapis.Add("");
                    Console.WriteLine("");
                }
            }
            subor.Close();
            File.WriteAllLines("C:\\Users\\skutas23\\e12.txt", zapis);
            Console.ReadLine();
        }
    }
}
