using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PociagZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Pociag ciuchcia1 = new Pociag();
            Console.WriteLine(ciuchcia1.Informacje());
            ciuchcia1.DodajLokomotywe("",-3);
            ciuchcia1.DodajLokomotywe("Pafawag 102E",80000);
            ciuchcia1.DodajOsobowy("112A",33500,"przedziałowy, 1 klasa");
            Console.WriteLine(ciuchcia1.Informacje());
            Console.WriteLine(ciuchcia1.MozeJechac());

            Pociag ciuchcia2 = new Pociag();
            ciuchcia2.DodajLokomotywe("Pafawag 102E", 80000);
            ciuchcia2.DodajOsobowy("112A", 33500, "przedziałowy, 1 klasa");
            ciuchcia2.DodajOsobowy("112A", 33500, "przedziałowy, 1 klasa");
            ciuchcia2.DodajOsobowy("112A", 33500, "przedziałowy, 1 klasa");
            Console.WriteLine(ciuchcia2.Informacje());
            Console.WriteLine(ciuchcia2.MozeJechac());
            ciuchcia2.DodajLokomotywe("Pafawag 102E", 80000);
            Console.WriteLine(ciuchcia2.MozeJechac());

            Pociag ciuchcia3 = new Pociag();
            ciuchcia3.DodajLokomotywe("Pafawag 102E", 80000);
            ciuchcia3.DodajOsobowy("112A", 33500, "przedziałowy, 1 klasa");
            ciuchcia3.DodajTowarowy("401Z", -3, "węgiel, ruda żelaza");
            ciuchcia3.DodajTowarowy("401Z", 19500, "węgiel, ruda żelaza");
            Console.WriteLine(ciuchcia3.Informacje());
            Console.WriteLine(ciuchcia3.MozeJechac());
            Console.ReadKey();
        }
    }
}
