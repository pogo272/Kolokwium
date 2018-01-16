using System;
using System.Collections.Generic;

namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {           
            Katalog l = new Katalog("");
            Aplikacja start = new Aplikacja();

            start.Wystartuj();
            while (true)
            {
                start.WczytajKlawisz();
            }
        }


        public class Aplikacja:Katalog
        {
            string tytul;
            int id;
            string wydawca;
            int rok;
            int numer;
            int lstron;
            string imie, nazwisko;
            char d;
            private Katalog odet=new Katalog("");
            List<Pozycja> pozycje = new List<Pozycja>();

            public void WczytajKlawisz()
            {
                d = ' ';
                Console.WriteLine("Aplikacja do zarządzania katalogiem");
                Console.WriteLine("Co chcesz zrobić? Wpisz klawisz i zatwierdź enterem...");
                Console.WriteLine("A-Dodaj czasopismo");
                Console.WriteLine("B-Dodaj książke");
                Console.WriteLine("C-Wyszukaj po tytule");
                Console.WriteLine("D-Wyszukaj po id");
                Console.WriteLine("E-Pokaż zawartość");
                Console.WriteLine("X-Wyjdź z aplikacji");

                try
                {
                    d = Convert.ToChar(Console.ReadLine());
                }
                catch
                { }

                WykonajDzialanie(d);
            }
            public void WykonajDzialanie(char d)
            {
                switch (d)
                {
                    case 'A':
                        PobierzDaneC();
                        break;
                    case 'B':
                        PobierzDaneK();
                        break;
                    case 'C':
                        Console.WriteLine("Podaj tytuł: ");
                        string wczytaj = Console.ReadLine();
                         WyszukajPoTytule(wczytaj);
                        break;
                    case 'D':
                        int pobierz=0;
                        Console.WriteLine("Podaj ID: ");
                        try
                        {
                            pobierz = Convert.ToInt32(Console.ReadLine());
                            WyszukajPoId(pobierz);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 'E':
                        WypiszWszystko();
                        break;
                    case 'X':
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Błąd!");
                        break;
                }
                Console.WriteLine("Naciśnij dowolny przycisk...");
                Console.ReadKey();
                Console.Clear();
            }


            public void PobierzDaneC()
            {
                Console.WriteLine("Podaj dane czasopisma(tytul, id, wydawnictwo, rokWydania, nr): ");

                tytul = Console.ReadLine();

                try
                { 

                id= Convert.ToInt32(Console.ReadLine());

                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                wydawca = (Console.ReadLine());

                try
                {
                    rok = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                try
                {
                    numer = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                DodajPozycje(tytul,id,wydawca,rok,numer);
            }
            public void SprawdzString()
            {
                if (String.Format(tytul)!=tytul)
                {
                    Console.WriteLine("Niepoprawny format. Podaj imie autora: ");
                    tytul = Console.ReadLine();
                }
            }
            public void PobierzDaneK()
            {
                
                Console.WriteLine("Podaj dane książki(tytul, id, wydawnictwo, rokWydania, liczba stron, imie, nazwisko): ");
                    tytul = Console.ReadLine();
                SprawdzString();
                try
                {
                    id = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                    wydawca = (Console.ReadLine());
                try
                {
                    rok = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                try
                {
                    lstron = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                imie = Console.ReadLine();
                nazwisko = Console.ReadLine();
                DodajPozycje(tytul, id, wydawca, rok, lstron,imie,nazwisko);
            }

            public void Wystartuj()
            {
                Test();
            }
        }
    }
}
