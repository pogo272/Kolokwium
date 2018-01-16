using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOm
{
    class Biurowiec : ProjektDomu
    {
        Dom dom = new Dom();
        public override void PomalujElewacje(Kolor kolor)
        {
            dom.PomalujElewacje(kolor);
        }
        public override string ToString()
        {
            return "Biurowiec: " + dom.ToString();
        }
        public override void ZamontujDrzwi(string rodzajDrzwi)
        {
            dom.ZamontujDrzwi(rodzajDrzwi);
        }
    }
}
