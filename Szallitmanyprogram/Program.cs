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
            string[] teljes = { "ABC-123", "ASD-234", "FGH-432", "BAB-986", "SEX-444" };
            List<string> bent = new List<string>();
            string választás;
            do
            {
                //A választási lehetőségek kiírása.
                Console.WriteLine("Elmegy (E)");
                Console.WriteLine("Bejön (B)");
                Console.WriteLine("Kilépés (K)");
                //A választás bekérése.
                választás = Console.ReadLine();
                switch (választás)
                {
                    case "E":Elmegy();
                        break;
                    case "B":Bejön(teljes, bent);
                        break;
                    case "K":Kilépés();
                        break;
                    default: Console.WriteLine("Nem megfelelő a választás.");
                        break;
                }
            } while (választás!="K");
            
            Console.ReadKey();
        }

        private static void Kilépés()
        {
            
        }

        private static void Elmegy()
        {
            //Ha üres a lista, akkor írjuk ki, hogy nincs bent autó
            //ellenőrzés, hogy az autó a listában van-e
            //Ha igen akkor ki kell törölni a listából
        }

        static void Bejön(string[] teljes, List<string> bent)
        {
            Console.WriteLine("Adjon meg egy rendszámot.");
            string bekér = Console.ReadLine();
            
            if (teljes.Contains(bekér))
            {
                bent.Add(bekér);
                Console.WriteLine("Bemehet.");
            }
            else
            {
                Console.WriteLine("Nincs bent a rendszerben.");
            }
            if (true)
            {
                //ha tele van
            }
            //Minden autó bent van-e már?
            //Ha nincs minden autó bent, akkor a bejövő autó a céghez tartozik-e?
            //Ha igen, akkor tegyük a lista végére.
            //HF eljárás irja ki hogy eljárással ami kiirja az aktuális bent lévő autokat.
        }
    }
}
