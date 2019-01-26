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
            Console.WriteLine("");
            Console.WriteLine("Hersteller: \t\t{0}\nModell: \t\t{1}\nKennzeichen: \t\t{2}\nJahr der Erstzulassung: {3}\nAnschaffungspreis: \t{4}\nStellplatz: \t\t{5}", this.hersteller, this.modell, this.kennzeichen, this.jahrDerErstzulassung, this.anschaffungspreis, this.stellplatz);
        }


        public virtual void SteuerschuldfürKennzeichen(List<Fahrzeug> alleFahrzeuge, string kennzeichen)
        {

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
