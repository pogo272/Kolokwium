using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    class Program
    {
        static void Main(string[] args)
        {
            Przychodnia przychodnia = new Przychodnia();
            Queue<Pacjent> pacjenci = new Queue<Pacjent>();
            string imie, nazwisko, specjalnosc, choroba;
            int wiek=0;
            Console.Write("Przychodnia!");
            IfError:
            Console.Write("Dodaj lekarza - podaj jego imie:  ");
            imie = Console.ReadLine();
            if (string.IsNullOrEmpty(imie) == true)
            {
                Console.WriteLine("Nie podano imienia");
                goto IfError;
            }
            nazwiskoLabel:
            Console.Write("\nnazwisko: ");
            nazwisko = Console.ReadLine();
            if (string.IsNullOrEmpty(nazwisko) == true)
            {
                Console.WriteLine("Nie podano nazwiska");
                goto nazwiskoLabel;
            }
            specjalnoscLabel:
            Console.WriteLine("\noraz specjalność: ");
            specjalnosc = Console.ReadLine();
            if (string.IsNullOrEmpty(specjalnosc) == true)
            {
                Console.WriteLine("Nie podano specjalności");
                goto specjalnoscLabel;
            }
            przychodnia.UstawLekarza(imie,nazwisko,specjalnosc);

            imieLabel:
            Console.Write("Podaj imie pacjenta: ");
            imie = Console.ReadLine();
            if (string.IsNullOrEmpty(imie) == true)
            {
                Console.WriteLine("Nie podano imienia");
                goto imieLabel;
            }

            nazwiskoLabel2:
            Console.Write("\tnazwisko: ");
            nazwisko = Console.ReadLine();
            if (string.IsNullOrEmpty(nazwisko) == true)
            {
                Console.WriteLine("Nie podano nazwiska");
                goto nazwiskoLabel2;
            }
            wiekLabel:
            Console.Write("\twiek: ");
            try
            {
                wiek = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Podaj wiek w poprawnym formacie");
                goto wiekLabel;
            }
            if((wiek<0)||(wiek>120))
            {
                Console.WriteLine("Wprowadzono niepoprawny wiek.");
                goto wiekLabel;
            }
            chorobaLabel:
            Console.Write("\tchorobe: ");
            choroba = Console.ReadLine();
            if (string.IsNullOrEmpty(choroba) == true)
            {
                Console.WriteLine("Nie podano choroby");
                goto chorobaLabel;
            }
            przychodnia.DodajDoKolejki(imie,nazwisko,wiek,choroba);
            while(true)
            {
                char klawisz;
                Console.WriteLine("A-Ustaw lekarza");
                Console.WriteLine("B-Dopisz do kolejki");
                Console.WriteLine("C-Wykonaj porade");
                Console.WriteLine("D-Wykonaj badanie");
                Console.WriteLine("E-Pokaz kolejke");
                Console.WriteLine("X-Zamknij");
                klawisz = Convert.ToChar(Console.ReadLine());
                switch (klawisz)
                {                   
                    case 'A':
                        Start:
                        Console.Write("Dodaj lekarza - podaj jego imie:  ");
                        imie = Console.ReadLine();
                        if (string.IsNullOrEmpty(imie) == true)
                        {
                            Console.WriteLine("Nie podano imienia");
                            goto Start;
                        }
                        Console.Write("\nnazwisko: ");
                        nazwisko = Console.ReadLine();
                        if (string.IsNullOrEmpty(nazwisko) == true)
                        {
                            Console.WriteLine("Nie podano nazwiska");
                            goto Start;
                        }
                        Console.WriteLine("\noraz specjalność: ");
                        specjalnosc = Console.ReadLine();
                        if (string.IsNullOrEmpty(specjalnosc) == true)
                        {
                            Console.WriteLine("Nie podano specjalności");
                            goto Start;
                        }
                        przychodnia.UstawLekarza(imie,nazwisko,specjalnosc);
                        break;

                    case 'B':
                        goto imieLabel;

                    case 'C':
                        Console.WriteLine(przychodnia.WykonajPorade());
                        break;

                    case 'D':
                        Console.WriteLine(przychodnia.WykonajBadanie());
                        break;

                    case 'E':
                        Console.WriteLine(przychodnia.ToString());
                        break;

                    case 'X':
                        Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("Błąd!");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
