using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    class Parkplatz
    {
        
        private int parkplatznummer;
        private Parkplatztyp parkplatztyp;
        private bool frei = true;

        public Parkplatz(int parkplatznummer, Parkplatztyp parkplatztyp, bool frei)
        {
            Parkplatznummer = parkplatznummer;
            this.Parkplatztyp = parkplatztyp;
            this.frei = frei;
        }
        
        public bool Frei { get => frei; set => frei = value; }
        public int Parkplatznummer { get => parkplatznummer; set => parkplatznummer = value; }
        internal Parkplatztyp Parkplatztyp { get => parkplatztyp; set => parkplatztyp = value; }
    }
}
