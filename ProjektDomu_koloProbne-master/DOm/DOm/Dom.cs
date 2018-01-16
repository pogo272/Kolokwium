using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOm
{
    class Dom
    {
        string drzwi;
        Kolor kolorElewacji;
        string okno;

        public void PomalujElewacje(Kolor kolor)
        {
            kolorElewacji = kolor;
        }
        override public string ToString()
        {
            string info = " ";
            if (string.IsNullOrEmpty(okno) != true)
                info += "okno: "+okno;
            if (string.IsNullOrEmpty(drzwi) != true)
                info += " drzwi: "+drzwi;
            if (string.IsNullOrEmpty(Convert.ToString(kolorElewacji)) != true)
                info += " kolor elewacji: " + kolorElewacji;

            return info;
        }
        public void WstawOkna(string okno)
        {
            this.okno = okno;
        }
        public void ZamontujDrzwi(string drzwi)
        {
            this.drzwi = drzwi;
        }
    }
}
