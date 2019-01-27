using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    class Fahrzeug
    {

        //Klasse Fahrzeug, hier werden erstmal für alle benötigten Werte sowie Funktionen benötigt
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
        //Polymorphe Methode zur Anzeige der Daten, wird in den entsprechenden "Fahrzeugtyp"-Klassen erweitert um die entsprechenden zusätzlichen Daten
        public virtual void PrintAllData()
        {
            Console.WriteLine("");
            Console.WriteLine("Hersteller: \t\t{0}\nModell: \t\t{1}\nKennzeichen: \t\t{2}\nJahr der Erstzulassung: {3}\nAnschaffungspreis: \t{4}\nStellplatz: \t\t{5}", this.hersteller, this.modell, this.kennzeichen, this.jahrDerErstzulassung, this.anschaffungspreis, this.stellplatz);
        }

        //Funktion zur Berechnung der Steuerschuld der Fahrzeuge. Wird auch in den entsprechenden Klassen erweitert (hier ja leer) muss aber hier sein, damit diese einfach aufgerufen werden kann
        public virtual void SteuerschuldfürKennzeichen()
        {
            //double Steuerschuld = 0;
            //double EineSteuerschuld = 0;
            //int SchadstoffklassenKosten = 0;
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
