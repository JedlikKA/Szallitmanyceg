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
                    case "B":Bejön();
                        break;
                    case "K":Kilépés();
                        break;
                    default: Console.WriteLine("Nem megfelelő a választás.");
                        break;
                }
            } while (választás!="K");
            Console.ReadKey();
        }
    }
}
