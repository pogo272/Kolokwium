using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbneKolo2NS
{
    class Sos:Skladnik
    {
        public Sos(string nazwa, double cena)
            :base(nazwa,cena)
        {

        }

        public override string ToString()
        {
            return String.Format("Sos: {0}, cena: {1}", nazwaSkladnika, cenaSkladnika);
        }
    }
}
