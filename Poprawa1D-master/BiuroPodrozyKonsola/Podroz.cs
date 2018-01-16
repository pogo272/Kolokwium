using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozyKonsola
{
    class Podroz:IComparable<Podroz>
    {
        //deklaracja pól w klasie
        private string miasto;
        private int ileDni;

        public Podroz() //konstruktor domyślny  (dobra praktyka przy głębokiej kopii)
        {

        }

        public Podroz(string miasto, int ile) //konstruktor parametryczny
        {
            this.miasto = miasto;
            this.ileDni = ile;
        }

        public override string ToString() //przesłonięcie metody
        {
            return "Miasto: " + miasto + ", liczba dni: " + ileDni;
        }

        public int CompareTo(Podroz other) //implementacja metody do porównywania
        {
            if (this.miasto == other.miasto) return other.ileDni.CompareTo(this.ileDni);
            else return this.miasto.CompareTo(other.miasto);
        }

        public Podroz GlebokaKopia()
        {
            Podroz temp = new Podroz();
            temp.miasto = this.miasto;
            temp.ileDni = this.ileDni;
            return temp;
        }
    }
}
