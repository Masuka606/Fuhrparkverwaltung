using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    class LKW : Fahrzeug
    {
        private string anzahlAchsen;
        private float zuladungInTonnen;

        public LKW(string hersteller, string modell, string kennzeichen, DateTime jahrDerErstzulassung, float anschaffungspreis, int stellplatz, string anzahlAchsen, float zuladungInTonnen) : base(hersteller, modell, kennzeichen, jahrDerErstzulassung, anschaffungspreis, stellplatz)
        {
            this.anzahlAchsen = anzahlAchsen;
            this.zuladungInTonnen = zuladungInTonnen;
        }

        public string AnzahlAchsen { get => anzahlAchsen; set => anzahlAchsen = value; }
        public float ZuladungInTonnen { get => zuladungInTonnen; set => zuladungInTonnen = value; }
    }
}
