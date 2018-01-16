using System;
using System.Collections.Generic;

namespace Biblioteka
{
    class Katalog :IZarzadzanie
    {
        string dzialTematyczny;
        List<Pozycja> pozycje=new List<Pozycja>();
        
        public Katalog()
        {

        }

        public Katalog(string dzialT)
        {
            this.dzialTematyczny = dzialT;
        }

        public void DodajPozycje(string tytul,int id,string wydawca,int rok,int liczbastron,string imie,string nazwisko)
        {
            pozycje.Add(new Ksiazka(tytul,id,wydawca,rok,liczbastron,imie,nazwisko));
        }
        public void DodajPozycje(string tytul, int id, string wydawca, int rok, int numer)
        {
            pozycje.Add(new Czasopismo(tytul, id, wydawca, rok, numer));
        }

        public void WypiszWszystko()
        {
            foreach (Pozycja zList in pozycje)
            {
                zList.WypiszInfo();
            }
        }

        public void WyszukajPoTytule(string tytul)
        {
            int licz=0;
            foreach (Pozycja zList in pozycje)
            {
                if (tytul == zList.PobierzTytul())
                {
                    zList.WypiszInfo();
                    licz++;
                }
            }
            if(licz==0)
            {
                Console.WriteLine("Nie znaleziono pozycji o podanym tytule");
            }
        }
        public void WyszukajPoId(int id)
        {
            int licz = 0;
            foreach (Pozycja zList in pozycje)
            {
                if (id == zList.PobierzId())
                {
                    zList.WypiszInfo();
                    licz++;
                }
            }
            if (licz == 0)
                Console.WriteLine("Nie znaleziono pozycji o podanym ID");
        }

        public void Test()
        {
            DodajPozycje("Gazeta Olsztyńska", 200, "Edytor", 1992, 7);
            DodajPozycje("Gazeta Wyborcza", 123, "Agora", 2010, 23);
            DodajPozycje("Krzyżacy", 220, "Znak", 2010, 300, "Henryk", "Sienkiewicz");
            DodajPozycje("Krzyżacy", 221, "Znak", 2011, 298, "Henryk", "Sienkiewicz");
        }
    }
}
