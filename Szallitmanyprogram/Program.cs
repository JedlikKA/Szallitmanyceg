using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szallitmanyprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teljes = { "ABC-123", "ASD-234", "FGH-432", "SEX-696" };
            List<string> bent = new List<string>();
            string választás;
            do
            {
                //Választási lehetőségek kiírása
                Console.WriteLine("Elmegy  (E)");
                Console.WriteLine("Bejön   (B)");
                Console.WriteLine("Kilépés (K)");
                //Választás bekérése
                választás = Console.ReadLine();
                switch (választás)
                {
                    case "E": Elmegy(teljes, bent);     break;
                    case "B": Bejön(teljes, bent);      break;
                    case "K": Kilépés();                break;
                    default: Console.WriteLine("Nem megfelelő választás..."); break;
                }
            } while (választás!="K");
            Console.ReadKey();
        }

        static void Kilépés()
        {
            Console.WriteLine("Köszönjük, hogy használta rendszerünk programát! További szép napot!");
        }

        static void Elmegy(string[] teljes, List<string> bent)
        {
            //Ha üres a lista, akkor írjuk ki hogy nincs bent autó.

            Console.WriteLine("Kérem a rendszámot: ");
            string rendszám = Console.ReadLine();
            if (teljes.Contains(rendszám) && bent.Contains(rendszám))
            {
                Console.WriteLine("Sikeres kilépés!");
                bent.Remove(rendszám);
                Console.WriteLine("Bent lévő autók:");
                Bentlevo_autok(teljes, bent);
            }
        }

        static void Bejön(string[] teljes, List<string> bent)
        {
            Console.WriteLine("Kérem a rendszámot: ");
            string rendszám = Console.ReadLine();
            if (teljes.Contains(rendszám)&& !bent.Contains(rendszám))
            {
                Console.WriteLine("Sikeres belépés!");
                bent.Add(rendszám);
                Console.WriteLine("Bent lévő autók:");
                Bentlevo_autok(teljes, bent);
            }
            else Console.WriteLine("Sikertelen belépés!");
            Console.ReadKey();
        }
        static void Bentlevo_autok (string[] teljes, List<string> bent)
        {
            foreach (string bentlevo_autók in bent)
            {
                Console.WriteLine(bentlevo_autók + " ");
            }
        }
    }
}
