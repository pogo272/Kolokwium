using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozyKonsola
{
    abstract class SrodekLokomocji //oznaczenie metody jako abstrakcyjna
    {
        //deklaracja pól w klasie
        protected int iloscMiejsc;
        protected double cenaBiletu;

        public SrodekLokomocji() //konstruktor domyślny
        {

        }

        public virtual void ObliczCene() //metoda z polecenia 1c
        {
            this.cenaBiletu = 50;
        }

        public double PobierzCene() //metoda zwracająca cenę biletu
        {
            return cenaBiletu;
        }

    }
}
