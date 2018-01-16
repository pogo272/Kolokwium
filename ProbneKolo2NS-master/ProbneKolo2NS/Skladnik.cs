using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbneKolo2NS
{
    class Skladnik:IComparable<Skladnik>
    {
        protected string nazwaSkladnika;
        protected double cenaSkladnika;

        public Skladnik(string nazwa, double cena)
        {
            if (cena < 0) throw new ArgumentException();
            this.nazwaSkladnika = nazwa;
            this.cenaSkladnika = cena;
        }

        public override string ToString()
        {
            return String.Format("Składnik: {0}, cena: {1}", nazwaSkladnika, cenaSkladnika);
        }

        public double PobierzCene()
        {
            return cenaSkladnika;
        }

        public int CompareTo(Skladnik other)
        {
            return other.cenaSkladnika.CompareTo(this.cenaSkladnika);
        }
    }
}
