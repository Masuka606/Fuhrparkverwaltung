using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    class PKW : Fahrzeug
    {
        private int hubraum;
        private int leistung;
        //private Schadstoffklasse Schadstoffklasse = Schadstoffklasse.Diesel;
        private Schadstoffklasse schadstoffklasse;

        public PKW(string hersteller, string modell, string kennzeichen, DateTime jahrDerErstzulassung, float anschaffungspreis, int stellplatz, int hubraum, int leistung, Schadstoffklasse schadstoffklasse)
            :base(hersteller, modell, kennzeichen, jahrDerErstzulassung, anschaffungspreis, stellplatz)
        {
            this.hubraum = hubraum;
            this.leistung = leistung;
            this.schadstoffklasse = schadstoffklasse;
        }

        public int Hubraum { get => hubraum; set => hubraum = value; }
        public int Leistung { get => leistung; set => leistung = value; }
        internal Schadstoffklasse Schadstoffklasse { get => schadstoffklasse; set => schadstoffklasse = value; }
    }
}
