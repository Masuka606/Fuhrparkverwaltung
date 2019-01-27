using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    class PKW : Fahrzeug
    {
        //private Parameter
        private int hubraum;
        private int leistung;
        private Schadstoffklasse schadstoffklasse;

        //Konstruktor (erweitert den Standard Konstruktor)
        public PKW(string hersteller, string modell, string kennzeichen, DateTime jahrDerErstzulassung, float anschaffungspreis, int stellplatz, int hubraum, int leistung, Schadstoffklasse schadstoffklasse)
            :base(hersteller, modell, kennzeichen, jahrDerErstzulassung, anschaffungspreis, stellplatz)
        {
            this.hubraum = hubraum;
            this.leistung = leistung;
            this.schadstoffklasse = schadstoffklasse;
        }

        //Polymorphe Methode
        public override void PrintAllData()
        {
            base.PrintAllData();
            Console.WriteLine("Hubraum: \t\t{0}\nLeistung: \t\t{1}\nSchadstoffklasse: \t{2}\n", this.hubraum, this.leistung, this.schadstoffklasse);
        }

        // Überschreibt die Funktion aus der Fahrzeugklasse
        public override void SteuerschuldfürKennzeichen()
        {
            base.SteuerschuldfürKennzeichen();

            double Steuerschuld = 0;
            double EineSteuerschuld = 0;
            int SchadstoffklassenKosten = 0;
            double HubraumSteuer = 0; //muss Double sein, sonst kommt es zu schwerwiegenden Rundungsfehlern
            //Schadstoffklassenkosten
            if (this.Schadstoffklasse == Schadstoffklasse.Schadstoffarm)
                {
                    SchadstoffklassenKosten = 0;
                }
                if (this.Schadstoffklasse == Schadstoffklasse.Normal)
                {
                    SchadstoffklassenKosten = 1;
                }
                if (this.Schadstoffklasse == Schadstoffklasse.Diesel)
                {
                    SchadstoffklassenKosten = 2;
                }

            HubraumSteuer = this.Hubraum + 99;
           
            
                EineSteuerschuld = HubraumSteuer / 100 * 10 * (SchadstoffklassenKosten + 1);
                Steuerschuld = Steuerschuld + EineSteuerschuld;
                EineSteuerschuld = 0;
                Console.WriteLine("Kennzeichen: {0} \t\tDie Steuerschuld beträgt: {1} Euro \n", this.Kennzeichen, Steuerschuld);
            
        }


        //Getter & Setter
        public int Hubraum { get => hubraum; set => hubraum = value; }
        public int Leistung { get => leistung; set => leistung = value; }
        internal Schadstoffklasse Schadstoffklasse { get => schadstoffklasse; set => schadstoffklasse = value; }
    }
}
