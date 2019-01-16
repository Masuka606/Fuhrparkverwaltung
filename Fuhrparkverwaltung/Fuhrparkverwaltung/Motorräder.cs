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

        //Konstruktor
        public Motorräder(string hersteller, string modell, string kennzeichen, DateTime jahrDerErstzulassung, float anschaffungspreis, int stellplatz, int hubraum) : base(hersteller, modell, kennzeichen, jahrDerErstzulassung, anschaffungspreis, stellplatz)
        {
            this.hubraum = hubraum;
        }

        //Polymorphe Methode
        public override void PrintAllData()
        {
            base.PrintAllData();
            Console.WriteLine("Hubraum: {0}\n", this.hubraum);
        }

        //Getter & Setter
        public int Hubraum { get => hubraum; set => hubraum = value; }
    }
}
