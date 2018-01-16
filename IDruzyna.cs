using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meczyk
{
    interface IDruzyna
    {
        void UstawNapastnika(int miejsce, string imie, string nazwisko, int numerNaKoszulce);
        void UstawObronce(int miejsce, string imie , string nazwisko, int numerNaKoszulce);
        void UstawNazwe(string nazwad);
        bool CzyOK();
    }
}
