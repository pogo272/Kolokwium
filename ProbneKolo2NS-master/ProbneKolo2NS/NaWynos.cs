using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbneKolo2NS
{
    class NaWynos:Zamowienie
    {
        public override bool PoprawnyCzas()
        {
            if (czasDostawy == "jutro") return true;
            else return false;
        }
    }
}
