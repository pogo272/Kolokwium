using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PociagZ
{
    /// <summary>
    /// Interfejs dla sprawdzenia poprawności pociągu.
    /// </summary>

    interface IPoprawnyPociag
    {
        //deklaracja metody ktorej zadaniem jest sprawdzenie czy pociag moze jechac
        bool MozeJechac();
    }
}
