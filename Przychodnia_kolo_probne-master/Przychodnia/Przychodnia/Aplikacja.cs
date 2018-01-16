using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    class Aplikacja
    {
        public static void Dzialanie()
        {
            char klawisz;
            Console.WriteLine("A-Ustaw lekarza");
            Console.WriteLine("B-Dopisz do kolejki");
            Console.WriteLine("C-Wykonaj porade");
            Console.WriteLine("D-Wykonaj badanie");
            Console.WriteLine("X-Zamknij");
            klawisz = Convert.ToChar(Console.ReadLine());
            Wykonaj(klawisz);
        }
        public static void Wykonaj(char klawisz)
        {
            switch (klawisz)
            {
                case 'A':

                    break;
                case 'B':
                    break;
                case 'C':
                    break;
                case 'D':
                    break;
                case 'X':
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Błąd!");
                    break;
            }
        }
    }
}
