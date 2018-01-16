using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOm
{
    class SzefBudowy
    {
        ProjektDomu projektDomu;

        public void Buduj(string rodzajOkien,string rodzajDrzwi,Kolor kolor)
        {
            Dom dom = new Dom();
            projektDomu.NowyDom();
            projektDomu.WstawOkna(rodzajOkien);
            projektDomu.ZamontujDrzwi(rodzajDrzwi);
            projektDomu.PomalujElewacje(kolor);
        }
        public override string ToString()
        {
            return projektDomu.ToString();
        }
        public void WybierzProjekt(ProjektDomu projekt)
        {
            projektDomu = new Biurowiec();
        }
    }
}
