using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozyKonsola
{
    class Pociag:SrodekLokomocji //dziedziczenie
    {
        private int dlugoscTrasy; //deklaracja pola

        public override void ObliczCene() //przesłonięcie metody
        {
            if (dlugoscTrasy > 100) base.cenaBiletu = dlugoscTrasy * 1.43;
            else base.ObliczCene();
        }

        public Pociag(int iloscMiejsc, int dlugoscTrasy) //konstruktor parametryczny
        {
            base.iloscMiejsc = iloscMiejsc;
            this.dlugoscTrasy = dlugoscTrasy;
            this.ObliczCene();
        }

        public override string ToString() //przesłonięcie metody
        {
            return "Pociąg, ilość miejsc: " + iloscMiejsc + ", długość trasy: "+ dlugoscTrasy+", cena biletu: " + cenaBiletu;
        }

        public int PobierzDlugoscTrasy() //metoda zwracająca dlugosc trasy (potrzebne do polecenia 4b)
        {
            return dlugoscTrasy;
        }
    }
}
