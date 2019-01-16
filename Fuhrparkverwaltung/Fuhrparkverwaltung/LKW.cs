using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    class LKW : Fahrzeug
    {
        //private Parameter
        private string anzahlAchsen;
        private float zuladungInTonnen;

        //Konstruktor
        public LKW(string hersteller, string modell, string kennzeichen, DateTime jahrDerErstzulassung, float anschaffungspreis, int stellplatz, string anzahlAchsen, float zuladungInTonnen) : base(hersteller, modell, kennzeichen, jahrDerErstzulassung, anschaffungspreis, stellplatz)
        {
            this.anzahlAchsen = anzahlAchsen;
            this.zuladungInTonnen = zuladungInTonnen;
        }

        //Polymorphische Methode
        public override void PrintAllData()
        {
            base.PrintAllData();
            Console.WriteLine("Anzahl der Achsen: {0}\n, Zuladung in Tonnen{1}\n", this.anzahlAchsen, this.zuladungInTonnen);
        }

        //Getter & Setter
        public string AnzahlAchsen { get => anzahlAchsen; set => anzahlAchsen = value; }
        public float ZuladungInTonnen { get => zuladungInTonnen; set => zuladungInTonnen = value; }
    }
}
