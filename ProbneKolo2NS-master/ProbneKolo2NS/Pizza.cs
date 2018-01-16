using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbneKolo2NS
{
    class Pizza:IPrzepis
    {
        List<string> przepis = new List<string>();

        public void DodajDoPrzepisu(string p1)
        {
            przepis.Add(p1);
        }

        public void Wypisz()
        {
            foreach(var element in przepis)
            {
                Console.WriteLine(element);
            }
        }
    }
}
