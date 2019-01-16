using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    class Fahrzeug
    {
        //Private Methoden
        private string hersteller;
        private string modell;
        private string kennzeichen;
        private DateTime jahrDerErstzulassung;
        private float anschaffungspreis;

        private int stellplatz;

        //Konstruktor
        public Fahrzeug(string hersteller, string modell, string kennzeichen, DateTime jahrDerErstzulassung, float anschaffungspreis, int stellplatz)
        {
            this.hersteller = hersteller;
            this.modell = modell;
            this.kennzeichen = kennzeichen;
            this.jahrDerErstzulassung = jahrDerErstzulassung;
            this.anschaffungspreis = anschaffungspreis;
            this.stellplatz = stellplatz;
        }
        //Polymorphe Methode
        public virtual void PrintAllData()
        {

            Console.WriteLine("Hersteller: {0}\n Modell: {1}\n Kennzeichen: {2}\n Jahr der Erstzulassung: {3}\n Anschaffungspreis: {4}\n, Stellplatz: {5}\n", this.hersteller, this.modell, this.kennzeichen, this.jahrDerErstzulassung, this.anschaffungspreis, this.stellplatz);
        }

        //Getter & Setter
        public string Hersteller { get => hersteller; set => hersteller = value; }
        public string Modell { get => modell; set => modell = value; }
        public string Kennzeichen { get => kennzeichen; set => kennzeichen = value; }
        public DateTime JahrDerErstzulassung { get => jahrDerErstzulassung; set => jahrDerErstzulassung = value; }
        public float Anschaffungspreis { get => anschaffungspreis; set => anschaffungspreis = value; }
        public int Stellplatz { get => stellplatz; set => stellplatz = value; }



       
    }
}
