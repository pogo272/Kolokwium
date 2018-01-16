using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOm
{
    class DomJednorodzinny:ProjektDomu
    {
        Dom dom = new Dom();
        public override void PomalujElewacje(Kolor kolor)
        {
            dom.PomalujElewacje(Kolor.czerwony);
        }
        public override string ToString()
        {
            return "Dom jednorodzinny: " + dom.ToString();
        }
    }
}
