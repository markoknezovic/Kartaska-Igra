using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartaskaIgra
{
    class Program
    {
        static void Main(string[] args)
        {
            int BrojacKarta = 0, Karte;
            string KarteZaStringUInt;
            while (BrojacKarta < 31)
            {
                Console.WriteLine("Upisite 1-13 za karte  ");
                KarteZaStringUInt = (Console.ReadLine());
                Karte = Convert.ToInt16(KarteZaStringUInt);
                if (Karte > 13 || Karte < 1)
                {
                    Console.WriteLine("Upisali ste broj veci od 13 ili manji od 1 nemoze tako ");
                }
                else
                {
                    BrojacKarta += Karte;
                }
            }
            if (BrojacKarta > 30)
            {
                Console.WriteLine("Bravo pobjedili ste imate " + BrojacKarta);
            }
            else
            {
                Console.WriteLine("izgubili ste imate " + BrojacKarta);
            }
            Console.ReadLine();
        }
    }
}
