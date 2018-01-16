using System;


namespace Biblioteka
{
    class Czasopismo : Pozycja
    {
        private int numer;

        public Czasopismo() { }
        public Czasopismo(string tytul, int id, string wydawnictwo, int rokWydania, int nr)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.numer = nr;
        }
        override public void WypiszInfo()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}",this.tytul.Trim(), this.id,this.wydawnictwo.Trim(), this.rokWydania,this.numer);
        }

    }
}
