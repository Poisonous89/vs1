using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uloha
{
    class Program
    {
        static void Main(string[] args)
        {
            string mesiac;
            string den;
            string[,] y = new string[3, 7];
            y[1, 1] = "Jano";
            y[1, 2] = "Jozo";
            y[1, 3] = "Juro";
            y[1, 4] = "Andrej";
            y[1, 5] = "Matus";
            y[1, 6] = "Peter";
            y[1, 0] = "Petra";
            y[2, 1] = "Adrian";
            y[2, 2] = "Matej";
            y[2, 3] = "Martin";
            y[2, 4] = "Jakub";
            y[2, 5] = "Alexandra";
            y[2, 6] = "Dominika";
            y[2, 0] = "Alexej";
            y[0, 1] = "Jimrich";
            y[0, 2] = "Daniel";
            y[0, 3] = "Michal";
            y[0, 4] = "Sofia";
            y[0, 5] = "Lukas";
            y[0, 6] = "Dominik";
            y[0, 0] = "Roman";
            Console.WriteLine("zadaj mesiac");
            mesiac = Console.ReadLine();
            Console.WriteLine("zadaj den");
            den = Console.ReadLine();
            int x = (Int32.Parse(den)-1);
            int z;
            if (mesiac == "Januar")
                    z = 1;
            else if (mesiac == "Februar")
                    z = 2;
            else if (mesiac == "Marec")
                    z = 0;
            else z = 4;
            if (z == 4)
                Console.WriteLine("Toto neni v systeme, tu je zoznam:"+ y);
            else if (x == 8)
                Console.WriteLine("Toto neni v systeme, tu je zoznam:"+y);
            else
            Console.WriteLine("Dneska ma meniny " + y[z,x]);
        }
        /*static int nieco(int mesiac, int den)
        {
            if (mesiac = 1)
                return 0;

        }*/
    }
}
