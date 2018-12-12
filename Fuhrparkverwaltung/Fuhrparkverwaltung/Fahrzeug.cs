using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    class Fahrzeug
    {
        private string hersteller;
        private string modell;
        private string kennzeichen;
        private DateTime jahrDerErstzulassung;
        private float anschaffungspreis;

        private int stellplatz;

        public Fahrzeug(string hersteller, string modell, string kennzeichen, DateTime jahrDerErstzulassung, float anschaffungspreis, int stellplatz)
        {
            this.hersteller = hersteller;
            this.modell = modell;
            this.kennzeichen = kennzeichen;
            this.jahrDerErstzulassung = jahrDerErstzulassung;
            this.anschaffungspreis = anschaffungspreis;
            this.stellplatz = stellplatz;
        }

        public string Hersteller { get => hersteller; set => hersteller = value; }
        public string Modell { get => modell; set => modell = value; }
        public string Kennzeichen { get => kennzeichen; set => kennzeichen = value; }
        public DateTime JahrDerErstzulassung { get => jahrDerErstzulassung; set => jahrDerErstzulassung = value; }
        public float Anschaffungspreis { get => anschaffungspreis; set => anschaffungspreis = value; }
        public int Stellplatz { get => stellplatz; set => stellplatz = value; }



       
    }
}
