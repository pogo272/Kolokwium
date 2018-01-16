using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbneKolo2NS
{
    class Program
    {
        static void Main(string[] args)
        {
            // polecenie 2
            List<Skladnik> pizza = new List<Skladnik>();
            pizza.Add(new Skladnik("Boczek", 2));
            pizza.Add(new Skladnik("Ananas", 3));
            pizza.Add(new Skladnik("Szynka", 2.7));
            pizza.Add(new Skladnik("Peperoni", 2.3));
            pizza.Add(new Skladnik("Ananas", 3));
            pizza.Add(new Sos("pomidorowy", 2));
            foreach(var element in pizza)
            {
                Console.WriteLine(element);
            }
            //polecenie 3
            pizza.Sort();
            for (int i = 0; i < pizza.Count;i++ )
            {
                if (i % 2 == 0) Console.WriteLine(pizza[i]);
            }
            pizza.Reverse();

            //polecenie 4
            try
            {
                Skladnik skl = new Skladnik("sss", -3);
            }
            catch
            {
                Console.WriteLine("cena nie może być ujemna");
            }

            //polecenie 7 
            Queue<Zamowienie> kolejka = new Queue<Zamowienie>();
            kolejka.Enqueue(new NaMiejscu());
            kolejka.Enqueue(new NaMiejscu());
            kolejka.Enqueue(new NaWynos());
            kolejka.Enqueue(new NaMiejscu());
            kolejka.Enqueue(new NaWynos());
            foreach(var element in kolejka)
            {
                element.UstawCzasDostawy("czas");
            }
            foreach (var element in kolejka)
            {
                Console.WriteLine(element.PoprawnyCzas());
            }
            while(kolejka.Count>0)
            {
                kolejka.Dequeue();
            }

            //polecenie 8d

            Pizza pizza1 = new Pizza();
            pizza1.DodajDoPrzepisu("sss");
            pizza1.DodajDoPrzepisu("ssadss");
            pizza1.DodajDoPrzepisu("wwwwwsss");
            pizza1.Wypisz();

            //polecenie 9

            Piec.NastawCzas(4);
            Console.ReadKey();
        }
    }
}
