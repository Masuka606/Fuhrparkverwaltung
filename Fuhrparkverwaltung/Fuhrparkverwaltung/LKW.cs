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
        private int anzahlAchsen;
        private float zuladungInTonnen;

        //Konstruktor
        public LKW(string hersteller, string modell, string kennzeichen, DateTime jahrDerErstzulassung, float anschaffungspreis, int stellplatz, int anzahlAchsen, float zuladungInTonnen) : base(hersteller, modell, kennzeichen, jahrDerErstzulassung, anschaffungspreis, stellplatz)
        {
            this.anzahlAchsen = anzahlAchsen;
            this.zuladungInTonnen = zuladungInTonnen;
        }

        //Polymorphische Methode
        public override void PrintAllData()
        {
            base.PrintAllData();
            Console.WriteLine("Anzahl der Achsen: \t{0}\nZuladung in Tonnen: \t{1}\n", this.anzahlAchsen, this.zuladungInTonnen);
        }

        public override void SteuerschuldfürKennzeichen()
        {
            base.SteuerschuldfürKennzeichen();

            double Steuerschuld = 0;
            double EineSteuerschuld = 0;
            int SchadstoffklassenKosten = 0;

            EineSteuerschuld = this.ZuladungInTonnen * 100 ;

            Steuerschuld = Steuerschuld + EineSteuerschuld;
            EineSteuerschuld = 0;
            Console.WriteLine("Kennzeichen: {0} \t\tDie Steuerschuld beträgt: {1}\n", this.Kennzeichen, Steuerschuld);
        }

        //Getter & Setter
        public int AnzahlAchsen { get => anzahlAchsen; set => anzahlAchsen = value; }
        public float ZuladungInTonnen { get => zuladungInTonnen; set => zuladungInTonnen = value; }
    }
}
