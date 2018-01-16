using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOm
{
    abstract class ProjektDomu
    {
        protected Dom dom;

        public void NowyDom()
        {
            Dom dom = new Dom();
        }
        public abstract void PomalujElewacje(Kolor kolor);
        override public string ToString()
        {
            return dom.ToString();
        }
        public virtual void WstawOkna(string rodzajOkien)
        {
            Dom dom = new Dom();
            dom.WstawOkna(rodzajOkien);
        }
        public virtual void ZamontujDrzwi(string rodzajDrzwi)
        {
            Dom dom = new Dom();
            dom.ZamontujDrzwi(rodzajDrzwi);
        }
    }
}
