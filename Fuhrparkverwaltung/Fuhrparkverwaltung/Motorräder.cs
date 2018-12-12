using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    class Motorräder : Fahrzeug  
    {
        private int hubraum;

        public Motorräder(string hersteller, string modell, string kennzeichen, DateTime jahrDerErstzulassung, float anschaffungspreis, int stellplatz, int hubraum) : base(hersteller, modell, kennzeichen, jahrDerErstzulassung, anschaffungspreis, stellplatz)
        {
            this.hubraum = hubraum;
        }

        public int Hubraum { get => hubraum; set => hubraum = value; }
    }
}
