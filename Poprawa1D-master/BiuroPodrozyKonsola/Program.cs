using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozyKonsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //kod do polecenia 5
            Queue<SrodekLokomocji> srodkiLokomocji = new Queue<SrodekLokomocji>();
            srodkiLokomocji.Enqueue(new Autobus(34));
            srodkiLokomocji.Enqueue(new Pociag(100, 234));
            srodkiLokomocji.Enqueue(new Express(322, 400));
            srodkiLokomocji.Enqueue(new Autobus(22));
            srodkiLokomocji.Enqueue(new Pociag(23, 23));
            srodkiLokomocji.Enqueue(new Express(122, 500));
            srodkiLokomocji.Enqueue(new Autobus(222));
            srodkiLokomocji.Enqueue(new Pociag(233, 243));
            srodkiLokomocji.Enqueue(new Express(1222, 40));

            double koszt = 0;
            foreach(var element in srodkiLokomocji)
            {
                koszt += element.PobierzCene();
            }
            Console.WriteLine("Koszt podróży: {0}",koszt);
            while(srodkiLokomocji.Count>0)
            {
                Console.WriteLine(srodkiLokomocji.Dequeue().ToString());
            }
            Console.ReadKey();
            Console.Clear();

            //kod z polecenia 8
            List<Podroz> wycieczka = new List<Podroz>();
            wycieczka.Add(new Podroz("Warszawa", 3));
            wycieczka.Add(new Podroz("Kraków", 2));
            wycieczka.Add(new Podroz("Warszawa", 5));
            wycieczka.Add(new Podroz("Poznań", 1));
            wycieczka.Add(new Podroz("Gniezno", 4));

            wycieczka.Sort();
            for(int i=wycieczka.Count-1;i>=0;i--)
            {
                Console.WriteLine(wycieczka[i].ToString());
            }

            Console.ReadKey();
            //kod do polecenia 9
            wycieczka.Add(wycieczka[2].GlebokaKopia());

        }
    }
}
