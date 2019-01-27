using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    class Motorräder : Fahrzeug  
    {
        //Private Konstruktoren
        private int hubraum;

        //Konstruktor (erweitert den Standard Konstruktor
        public Motorräder(string hersteller, string modell, string kennzeichen, DateTime jahrDerErstzulassung, float anschaffungspreis, int stellplatz, int hubraum) : base(hersteller, modell, kennzeichen, jahrDerErstzulassung, anschaffungspreis, stellplatz)
        {
            this.hubraum = hubraum;
        }

        //Polymorphe Methode
        public override void PrintAllData()
        {
            base.PrintAllData();
            Console.WriteLine("Hubraum: \t\t{0}\n", this.hubraum);
        }

        // Erweitert die Funktion für die Steuerschuld
        public override void SteuerschuldfürKennzeichen()
        {
            base.SteuerschuldfürKennzeichen();

            double Steuerschuld = 0;
            double EineSteuerschuld = 0;
            int SchadstoffklassenKosten = 0;
            double HubraumSteuer = 0;

            HubraumSteuer = this.Hubraum + 99;
            EineSteuerschuld = (HubraumSteuer) / 100 * 20;
            Steuerschuld = Steuerschuld + EineSteuerschuld;
            EineSteuerschuld = 0;
            Console.WriteLine("Kennzeichen: {0} \t\tDie Steuerschuld beträgt: {1} Euro \n", this.Kennzeichen, Steuerschuld);


        }

        //Getter & Setter
        public int Hubraum { get => hubraum; set => hubraum = value; }
    }
}
