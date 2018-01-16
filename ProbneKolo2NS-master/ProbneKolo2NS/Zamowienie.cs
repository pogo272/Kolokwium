using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbneKolo2NS
{
    abstract class Zamowienie
    {
        protected string czasDostawy;

        public virtual bool PoprawnyCzas()
        {
            if (czasDostawy != null) return true;
            else return false;
        }

        public void UstawCzasDostawy(string czas)
        {
            this.czasDostawy = czas;
        }
    }
}
