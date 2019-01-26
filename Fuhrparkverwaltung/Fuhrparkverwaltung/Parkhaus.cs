using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    class Parkhaus
    {
        private Parkplatz[] Parkplätze;
        private string ParkhauName;
        private int ParkhausNummer;

        public Parkhaus(Parkplatz[] parkplätze, string parkhauName, int parkhausNummer)
        {
            Parkplätze = parkplätze;
            ParkhauName = parkhauName;
            ParkhausNummer = parkhausNummer;
        }
    }
}
