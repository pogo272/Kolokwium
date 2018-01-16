using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meczyk
{
    class Obronca:Pilkarz
    {
        public Obronca(string imie,string nazwisko,int numerNaKoszulce)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numerNaKoszulce = numerNaKoszulce;
            if(this.numerNaKoszulce %2!=0)
            {
                throw new BlednyNumerExceptioncs("BLEDNY NUMER");

            }
        }
        public override string ToString()
        {
            return "OBRONCA:" + " " + "PILKARZ:" + " " + this.imie + " " + this.nazwisko + " " + "NUMER NA KOSZULCE:" + " " + this.numerNaKoszulce;
        }

    }
}
