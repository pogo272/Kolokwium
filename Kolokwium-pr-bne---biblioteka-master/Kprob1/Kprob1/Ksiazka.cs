using System;

namespace Biblioteka
{
    class Ksiazka : Pozycja
    {
        private int liczbaStron;
        private Autor autor;

        public Ksiazka() { }
        public Ksiazka(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron, string imie, string nazwisko)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.liczbaStron = liczbaStron;
            this.autor = new Autor(imie.Trim(), nazwisko.Trim());
        }
        override public void WypiszInfo()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", this.tytul.Trim(), this.id, this.wydawnictwo.Trim(), this.rokWydania, this.liczbaStron,autor.WypiszInfo());
        }

    }
}
