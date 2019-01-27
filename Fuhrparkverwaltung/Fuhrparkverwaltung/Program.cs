using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Fahrzeug> alleFahrzeuge = new List<Fahrzeug>();
            List<Parkhaus> Parkhäuser = new List<Parkhaus>();
            Parkplatz[] ParkhausNr1 = new Parkplatz[300];


        //Parkhäuser.Add(new Parkhaus(ParkhausNr1, "Porzer Haus", 1));



        int CreateParkplätze = 0;
            while (CreateParkplätze < 100)
            {
                ParkhausNr1[CreateParkplätze] = new Parkplatz(CreateParkplätze +1, Parkplatztyp.PKW, true);
                //ParkhausNr1.Add(new Parkplatz(CreateParkplätze, Parkplatztyp.PKW, true));
                CreateParkplätze++;
            }

            while (CreateParkplätze < 200)
            {
                ParkhausNr1[CreateParkplätze] = new Parkplatz(CreateParkplätze + 1, Parkplatztyp.LKW, true);
                CreateParkplätze++;
            }

            while (CreateParkplätze < 300)
            {
                ParkhausNr1[CreateParkplätze] = new Parkplatz(CreateParkplätze + 1, Parkplatztyp.Motorrad, true);
                CreateParkplätze++;
            }



            // Anlegen von drei schon vorhandenen Fahrzeugen mit Daten (jeder Typ einmal)


            alleFahrzeuge.Add(new PKW("Audi", "RS6+", "K-BB-2000", new DateTime(2018, 1, 1), 180000, 1, 5400, 640, Schadstoffklasse.Normal));
            ParkhausNr1[0].Frei = false;
            alleFahrzeuge.Add(new LKW("Man", "Trucka", "K-AA-1111", new DateTime(1980, 1, 1), 240000, 150, 6, 40));
            ParkhausNr1[149].Frei = false;
            alleFahrzeuge.Add(new Motorräder("Kawasaki", "Ninja", "BN-KS-12", new DateTime(2016, 9, 1), 23000, 300, 2000));
            ParkhausNr1[299].Frei = false;

            

            bool running = true;
            //Do While draus machen
            // Angezeigtes Optionen Menü 
            do {


                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\tWillkommen in der Fuhrparkverwaltung von Nico, Lukas und Fabio\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bitte wählen Sie eine der folgenden Optionen, indem Sie die dazu gehörige Ziffer wählen:");
                Console.WriteLine("1. Ausgabe der Details aller Fahrzeuge");
                Console.WriteLine("2. Ausgabe der Detail eines bestimmten Kennzeichens");
                Console.WriteLine("3. Neuanlage eines Fahrzeugs");
                Console.WriteLine("4. Steuerschuldberechnung für alle Fahrzeuge");
                Console.WriteLine("5. Steuerschuldberechnung für ein Fahrzeug");
                Console.WriteLine("6. Beenden\n\n");
                Console.ForegroundColor = ConsoleColor.White;

                int Auswahlmenu = Convert.ToInt32(Console.ReadLine());

                //Abfrage nach was gemacht werden soll
                switch (Auswahlmenu)
                {
                    case 1:
                        Verwaltung.AusgabeAllerDaten(alleFahrzeuge);
                        break;

                    case 2:
                        string gesuchtesKennzeichen = Verwaltung.gesuchtesKennzeichenErmitteln(alleFahrzeuge);
                        Verwaltung.GebeAlleDatenEinesKennzeichensAus(alleFahrzeuge, gesuchtesKennzeichen);

                        Console.ReadKey();
                        break;
                    case 3:
                        Verwaltung.addNewFahrzeug(alleFahrzeuge, ParkhausNr1);
                        break;

                    case 4:
                    
                        Verwaltung.BerechneSteuerschuld(alleFahrzeuge);
                        break;

                    case 5:
                        string gesuchtesKennzeichenSteuer = Verwaltung.gesuchtesKennzeichenErmitteln(alleFahrzeuge);
                        Verwaltung.SteuerschuldfürKennzeichen(alleFahrzeuge, gesuchtesKennzeichenSteuer);
                        break;

                    case 6:
                        running = false;
                        break;

                }

            }while (running == true) ;
        }



    }
}
