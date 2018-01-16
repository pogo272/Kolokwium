using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia 
{
    class Przychodnia:IPrzychodnia
    {
        private Lekarz lekarz= new Lekarz();
        private Queue<Pacjent> pacjenci = new Queue<Pacjent>();
        
        public void UstawLekarza(string imie,string nazwisko,string specjalnosc)
        {
            lekarz = new Lekarz(imie,nazwisko,specjalnosc);
        }
        public void DodajDoKolejki(string imie,string nazwisko,int wiek,string choroba)
        {
            pacjenci.Enqueue(new Pacjent(imie,nazwisko,wiek,choroba));
        }
        public string WykonajPorade()
        {
            if (pacjenci.Count > 0)
                return "Wykonano porade. " + pacjenci.Dequeue().ToString();
            else
                return "Kolejka jest pusta";
        }
        public string WykonajBadanie()
        {
            return "Wykonano badanie. " + pacjenci.Peek().ToString();
        }
        public int CzasOczekiwania()
        {
            return pacjenci.Count / 4;
        }
        override public string ToString()
        {
            string danezkolejki=" ";
            foreach (Pacjent t in pacjenci)
            {
                danezkolejki += t.ToString() + "\n";
            }
            return lekarz.ToString()+"\n" + "Pacjenci w kolejce\n" + danezkolejki + "Czas oczekiwania: " + CzasOczekiwania();
        }
        public bool CzyLekarz()
        {
            if (lekarz != null)
                return true;
            else
                return false;
        }
        
    }
}
