using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozyKonsola
{
    class Autobus: SrodekLokomocji //dziedziczenie
    {
        public Autobus(int iloscMiejsc) //konstruktor parametryczny
        {
            base.iloscMiejsc = iloscMiejsc;
            base.ObliczCene();
        }

        public override string ToString() //przesłonięcie metody 
        {
            return "Autobus, ilość miejsc: " + iloscMiejsc + ", cena biletu: " + cenaBiletu;
        }
    }
}
