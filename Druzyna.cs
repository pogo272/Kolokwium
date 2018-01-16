using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meczyk
{
    class Druzyna:IDruzyna
    {
        private Pilkarz[,] druzyna = new Pilkarz[2, 4];
        private string nazwa;
        public bool CzyOK()
        {
            int rezultat=0;
            foreach(var element in druzyna)
            {
                if(element==null)
                {
                    rezultat++;
                }
            }
            if (rezultat==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void UstawNapastnika(int miejsce, string imie, string nazwisko, int numerNaKoszulce)
        {
            druzyna[0, miejsce] = new Napastnik(imie, nazwisko, numerNaKoszulce);
        }
        public void UstawNazwe(string nazwad)
        {
            nazwa = nazwad;
        }     
        public void UstawObronce(int miejsce, string imie, string nazwisko, int numerNaKoszulce)
        {
            druzyna[1, miejsce] = new Obronca(imie, nazwisko, numerNaKoszulce);
        }
        public override string ToString()
        {
            return "[0,0]" + druzyna[0, 0].ToString() + "\n" + "[0,1]" + druzyna[0, 1].ToString() + "[0,2]" + druzyna[0, 2].ToString() + "[0,3]" + druzyna[0, 3].ToString() +
                "[1,0]" + druzyna[1, 0].ToString() + "[1,1]" + druzyna[1, 1].ToString() + "[1,2]" + druzyna[1, 2].ToString() + "[1,3]" + druzyna[1, 3].ToString();

        }

    }
}
