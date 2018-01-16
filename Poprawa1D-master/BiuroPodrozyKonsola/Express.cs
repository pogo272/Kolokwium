using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozyKonsola
{
    class Express:Pociag //dziedziczenie
    {
        public override void ObliczCene() //przesłonięcie metody
        {
            base.cenaBiletu = 200;
        }

        public override string ToString() //przesłonięcie metody
        {
            return "Expresss, ilość miejsc: " + iloscMiejsc + ", długość trasy: " + base.PobierzDlugoscTrasy() + ", cena biletu: " + cenaBiletu;
        }

        public Express(int iloscMiejsc, int dlugoscTrasy) //konstruktor parametryczny
            :base(iloscMiejsc,dlugoscTrasy)
        {

        }
    }
}
