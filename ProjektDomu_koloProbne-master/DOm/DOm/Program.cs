using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOm
{
    enum Kolor
    {
        biel,
        czerwony,
        zielony,
        czarny
    }
    class Program
    {

        static void Main(string[] args)
        {
            Dom one = new Dom();
            SzefBudowy four = new SzefBudowy();
            ProjektDomu two = new Biurowiec();
            ProjektDomu three = new DomJednorodzinny();
            while(true)
            {
                startLabel:
                char klawisz;
                Console.WriteLine("Co chcesz zrobić?");
                Console.WriteLine("A-Buduj biurowiec");
                Console.WriteLine("B-Buduj dom jednorodzinny");
                Console.WriteLine("C-Wyjdź");
                klawisz = Convert.ToChar(Console.ReadLine());
                switch(klawisz)
                {
                    case 'A':
                        string zlap = " ";
                        //two.NowyDom();
                        Console.WriteLine("Jak pomalować elewacje(biel,czerwony,zielony,czarny)??");
                        ustawKolorLabel:
                        zlap = Console.ReadLine();
                        if ((string.IsNullOrEmpty(zlap)==true)||(zlap.Length <=2))
                        {
                            Console.WriteLine("Niepodales poprawnie koloru! Podaj kolor ponownie(biel,czerwony,zielony,czarny): ");
                            goto ustawKolorLabel;
                        }
                        switch(zlap)
                        {
                            case "biel":
                                two.PomalujElewacje(Kolor.biel);
                                break;
                            case "czerowny":
                                two.PomalujElewacje(Kolor.czerwony);
                                break;
                            case "zielony":
                                two.PomalujElewacje(Kolor.zielony);
                                break;
                            case "czarny":
                                two.PomalujElewacje(Kolor.czarny);
                                break;
                            default:
                                Console.WriteLine("Niepoprawnie wybrales kolor.\nProsze wybierz jeden z kolorów(biel,czerwony,zielony,czarny)");
                                goto ustawKolorLabel;
                        }
                        Console.WriteLine("Teraz podaj rodzaj drzwi: ");
                        ustawRDrzwiLabel:

                        string rodzajDrzwi = Console.ReadLine();
                        if ((string.IsNullOrEmpty(rodzajDrzwi)==true) || (rodzajDrzwi.Length <= 2))
                        {
                            Console.WriteLine("Niepodales poprawnie rodzaju drzwi! Podaj rodzaj drzwi ponownie: ");
                            goto ustawRDrzwiLabel;
                        }
                        two.ZamontujDrzwi(rodzajDrzwi);

                        Console.WriteLine("Teraz podaj rodzaj okien: ");
                        ustawROkienLabel:
                        string rodzajOkien = Console.ReadLine();
                        if ((string.IsNullOrEmpty(rodzajOkien)==true) || (rodzajOkien.Length <= 2))
                        {
                            Console.WriteLine("Niepodales poprawnie rodzaju okien! Podaj rodzaj okien ponownie: ");
                            goto ustawROkienLabel;
                        }
                        two.WstawOkna(rodzajOkien);
                        Console.WriteLine("Gratulacje! Poprawnie przyjęto zamówienie!");
                        Console.WriteLine(two.ToString());
                        break;
                    case 'B':
                        zlap = " ";
                        three.NowyDom();

                        Console.WriteLine("Jak pomalować elewacje(biel,czerwony,zielony,czarny)??");
                        ustawKolorLabel2:
                        zlap = Console.ReadLine();
                        if ((string.IsNullOrEmpty(zlap) == true) || (zlap.Length <= 2))
                        {
                            Console.WriteLine("Niepodales poprawnie koloru! Podaj kolor ponownie(biel,czerwony,zielony,czarny): ");
                            goto ustawKolorLabel2;
                        }
                        switch (zlap)
                        {
                            case "biel":
                                three.PomalujElewacje(Kolor.biel);
                                break;
                            case "czerowny":
                                three.PomalujElewacje(Kolor.czerwony);
                                break;
                            case "zielony":
                                three.PomalujElewacje(Kolor.zielony);
                                break;
                            case "czarny":
                                three.PomalujElewacje(Kolor.czarny);
                                break;
                            default:
                                Console.WriteLine("Niepoprawnie wybrales kolor.\nProsze wybierz jeden z kolorów(biel,czerwony,zielony,czarny)");
                                goto ustawKolorLabel;
                        }
                        Console.WriteLine("Teraz podaj rodzaj drzwi: ");
                        ustawRDrzwiLabel2:

                        rodzajDrzwi = Console.ReadLine();
                        if ((string.IsNullOrEmpty(rodzajDrzwi) == true) || (rodzajDrzwi.Length <= 2))
                        {
                            Console.WriteLine("Niepodales poprawnie rodzaju drzwi! Podaj rodzaj drzwi ponownie: ");
                            goto ustawRDrzwiLabel2;
                        }
                        three.ZamontujDrzwi(rodzajDrzwi);

                        Console.WriteLine("Teraz podaj rodzaj okien: ");
                        ustawROkienLabel2:
                        rodzajOkien = Console.ReadLine();
                        if ((string.IsNullOrEmpty(rodzajOkien) == true) || (rodzajOkien.Length <= 2))
                        {
                            Console.WriteLine("Niepodales poprawnie rodzaju okien! Podaj rodzaj okien ponownie: ");
                            goto ustawROkienLabel2;
                        }
                        three.WstawOkna(rodzajOkien);
                        Console.WriteLine("Gratulacje! Poprawnie przyjęto zamówienie!");
                        Console.WriteLine(three.ToString());
                        break;
                    case 'C':
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Błąd!");
                        goto startLabel;
                }
            }

        }
    }
}
