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

        //Konstruktor Erweitert den Standard Konstruktur
        public LKW(string hersteller, string modell, string kennzeichen, DateTime jahrDerErstzulassung, float anschaffungspreis, int stellplatz, int anzahlAchsen, float zuladungInTonnen) : base(hersteller, modell, kennzeichen, jahrDerErstzulassung, anschaffungspreis, stellplatz)
        {
            this.anzahlAchsen = anzahlAchsen;
            this.zuladungInTonnen = zuladungInTonnen;
        }

        //Polymorphische Methode
        public override void PrintAllData()
        {
            base.PrintAllData();
            Console.WriteLine("Anzahl der Achsen: \t{0}\nZuladung in Tonnen: \t{1} \n", this.anzahlAchsen, this.zuladungInTonnen);
        }

        public override double SteuerschuldfürKennzeichen()
        {
            base.SteuerschuldfürKennzeichen();

            double SteuerschuldG = 0;
            double Steuerschuld = 0;
            double EineSteuerschuld = 0;
            int SchadstoffklassenKosten = 0;

            EineSteuerschuld = this.ZuladungInTonnen * 100 / 1000 ;

            Steuerschuld = Steuerschuld + EineSteuerschuld;
            EineSteuerschuld = 0;
            SteuerschuldG = Steuerschuld;
            Console.WriteLine("Kennzeichen: {0} \t\tDie Steuerschuld beträgt: {1} Euro / t\n", this.Kennzeichen, Steuerschuld);
            return SteuerschuldG;
        }

        //Getter & Setter
        public int AnzahlAchsen { get => anzahlAchsen; set => anzahlAchsen = value; }
        public float ZuladungInTonnen { get => zuladungInTonnen; set => zuladungInTonnen = value; }
    }
}
