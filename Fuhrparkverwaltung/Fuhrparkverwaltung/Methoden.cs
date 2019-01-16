using System
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    class Methoden
    {



        //Kennzeichensuche
        public void searchByNumberPlate()
        {

            string Kennzeichen = Convert.ToString(Console.ReadLine());

        }

        public void AddNewFahrzeug(Fahrzeug[] Fahrzeuge)
        {

            Console.WriteLine("Geben Sie bitte den gewünschten Fahrzeugtyp ein: \nPKW \nLKW\n Motorrad");
            string Fahrzeugtyp = Convert.ToString(Console.ReadLine());

            //Fahrzeug Fahrzeug1 = n
            Fahrzeuge[Fahrzeuge.Length +1] = new PKW("Audi", "RS6+", "K-AL-1092", , 2, 4.5, 640, )
            //Fahrzeuge.GetLength()




        }


        

        //Alle Daten von allen Fahrzeugarten

        //Steuerschuld

        //Zuweisen eines Stellplatzes
    }
}
