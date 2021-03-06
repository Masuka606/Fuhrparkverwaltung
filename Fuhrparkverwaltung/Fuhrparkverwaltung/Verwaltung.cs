﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    class Verwaltung
    {
      

        public static void AusgabeAllerDaten(List<Fahrzeug> alleFahrzeuge)
        {
            Console.WriteLine("\n\nEs werden alle {0} Fahrzeuge aufgelistet:\n", CountFahrzeuge(alleFahrzeuge));
            foreach (Fahrzeug fahrzeug in alleFahrzeuge)
            {
                
                fahrzeug.PrintAllData();
            }

        }
        public static string gesuchtesKennzeichenErmitteln(List<Fahrzeug> allefahrzeuge)
        {

            Console.WriteLine("\n Bitte geben Sie das gewünschte Kennzeichen ein\n\n");
            string gesuchtesKennzeichen = Convert.ToString(Console.ReadLine());
            bool KennzeichenGefunden = false;

            foreach (Fahrzeug fahrzeug in allefahrzeuge)
            {
                if (fahrzeug.Kennzeichen == gesuchtesKennzeichen)
                {
                    KennzeichenGefunden = true;
                }
                
            }
            if (KennzeichenGefunden == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDas Kennwort ist nicht vorhanden\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return gesuchtesKennzeichen;

        }

        //Funktion zur Ausgabe der Daten eines bestimmten Fahrzeugs, durch einfache Prüfung des Kennzeichen-strings
        public static void GebeAlleDatenEinesKennzeichensAus(List<Fahrzeug> alleFahrzeuge, string kennzeichen)
        {
            foreach (Fahrzeug fahrzeug in alleFahrzeuge)
            {
                if (fahrzeug.Kennzeichen == kennzeichen)
                {
                    fahrzeug.PrintAllData();
                }
            }
        }

        public static int CountFahrzeuge(List<Fahrzeug> alleFahrzeuge)
        {
            int AnzahlFahrzeuge = 0;


            foreach (Fahrzeug fahrzeug in alleFahrzeuge)
            {
                AnzahlFahrzeuge++;
            }
            return AnzahlFahrzeuge;
        }

        public static void BerechneSteuerschuld(List<Fahrzeug> alleFahrzeuge)
        {
            double SteuerschuldG = 0;
            double Steuerschuldgesamt = 0;
            
            


            //Steuerschuld PKW
            foreach (PKW fahrzeug in alleFahrzeuge.OfType<PKW>())
            {

             //   fahrzeug.SteuerschuldfürKennzeichen();
                SteuerschuldG = fahrzeug.SteuerschuldfürKennzeichen();
                Steuerschuldgesamt = Steuerschuldgesamt + SteuerschuldG;
               
            }

            foreach (LKW fahrzeug in alleFahrzeuge.OfType<LKW>())
            {

                
              //  fahrzeug.SteuerschuldfürKennzeichen();
                SteuerschuldG = fahrzeug.SteuerschuldfürKennzeichen();
                SteuerschuldG = SteuerschuldG * fahrzeug.ZuladungInTonnen;
                Steuerschuldgesamt = Steuerschuldgesamt + SteuerschuldG;

            }

            foreach (Motorräder fahrzeug in alleFahrzeuge.OfType<Motorräder>())
            {

               // fahrzeug.SteuerschuldfürKennzeichen();
                SteuerschuldG = fahrzeug.SteuerschuldfürKennzeichen();
                Steuerschuldgesamt = Steuerschuldgesamt + SteuerschuldG;

            }

            Console.WriteLine("Die gesamte Steuerschuld beträgt: {0}\n", Steuerschuldgesamt);

           
        }


        public static void SteuerschuldfürKennzeichen(List<Fahrzeug> alleFahrzeuge, string kennzeichen)
        {
            
            foreach (Fahrzeug fahrzeug in alleFahrzeuge)
            {
                if (fahrzeug.Kennzeichen == kennzeichen)
                {


                    fahrzeug.SteuerschuldfürKennzeichen();
                       
                }
            }
        }






        // Funktion zum hinzufügen weiterer Fahrzeuge
        // Erst wird die Angabe des Typs gefordert und dann darauf hin ein entsprechendes neues Fahrzeug Objekt vom angegebenen Typ erstellt
        // Danach wird man aufgefordert die benötigten Daten anzugeben
        public static void addNewFahrzeug(List<Fahrzeug> alleFahrzeuge, Parkplatz[] Parkplätze)
        {
            bool fahrzeugAngelegt = false;
            do
            {
                try
                {
                    //Initialisierung des Enums mit einem Defaultwert
                    Fahrzeugtyp einFahrzeugtyp = Fahrzeugtyp.Default;

                    Console.WriteLine("Geben Sie bitte den gewünschten Fahrzeugtyp ein: \nPKW \nLKW\nMotorrad\n");
                    string fahrzeugtyp = Convert.ToString(Console.ReadLine());
                    fahrzeugtyp = fahrzeugtyp.ToLower();
                    // Prüfung des gewünschten Fahrzeugtyps und anlegen eines neuen Objektes des gewünschten Typs
                    if (fahrzeugtyp != "pkw" && fahrzeugtyp != "lkw" && fahrzeugtyp != "motorrad")
                    {
                        throw new Exception();
                    }
                    if (fahrzeugtyp == "pkw")
                    {
                        einFahrzeugtyp = Fahrzeugtyp.PKW;
                    }
                    if (fahrzeugtyp == "lkw")
                    {
                        einFahrzeugtyp = Fahrzeugtyp.LKW;
                    }
                    if (fahrzeugtyp == "motorrad")
                    {
                        einFahrzeugtyp = Fahrzeugtyp.Motorrad;
                    }
                    // Frage nach den Daten die für alle Fahrzeugtypen gebraucht werden
                    Console.WriteLine("Geben Sie bitte den Hersteller an:");
                    string hersteller = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Geben Sie bitte das Modell an:");
                    string modell = Convert.ToString(Console.ReadLine());
                    
                    Console.WriteLine("Geben Sie bitte das Kennzeichen an:");
                    string kennzeichen = Convert.ToString(Console.ReadLine());
                    
                    Console.WriteLine("Geben Sie bitte das Anschaffungsjahr an:");
                    string anschaffungsjahrString = (Console.ReadLine());
                    if (!Int32.TryParse(anschaffungsjahrString, out int anschaffungsjahr))
                    {
                        throw new Exception();
                    }

                    Console.WriteLine("Geben Sie bitte den Anschaffungspreis an:");
                    string anschaffungspreisString = (Console.ReadLine());
                    if (!Int32.TryParse(anschaffungspreisString, out int anschaffungspreis))
                    {
                        throw new Exception();
                    }
                    
                    //Parkplatzabfrage 
                    // Hier wird sowohl geprüft, ob der Parkplatz für das Fahrzeug kompatibel ist, sowie ob der Parkplatz frei ist
                    bool ParkplatzFrei = false;
                    bool ParkplatztypPasst = false;
                    int ParkplatzGewünscht;
                    do
                    {
                    Console.WriteLine("Geben Sie bitte den gewünschten Parkplatz ein. \nDas Parkhaus hat 300 Stellplätze.\nPKW Parkplätze: 1-100\nLKW Parkplätze: 101-200 \nMotorradstellplätze: 201- 300 ");
                    string parkplatzStringGewünscht = (Console.ReadLine());
                        if (!Int32.TryParse(parkplatzStringGewünscht, out ParkplatzGewünscht))
                        {
                            throw new Exception();
                        }
                            ParkplatzFrei = false;
                            ParkplatztypPasst = false;

                            if (Parkplätze[ParkplatzGewünscht - 1].Parkplatztyp.ToString() != einFahrzeugtyp.ToString())
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nDer Parkplatz ist leider nicht für diesen Fahrzeugtyp kompatibel!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        else if(Parkplätze[ParkplatzGewünscht - 1].Parkplatztyp.ToString() == einFahrzeugtyp.ToString())
                            {
                                ParkplatztypPasst = true;
                            }

                         if (Parkplätze[ParkplatzGewünscht -1].Frei == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nDer Parkplatz ist leider bereits belegt! Bitte wählen Sie einen anderen Parkplatz aus.\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        else if (Parkplätze[ParkplatzGewünscht - 1].Frei != false)
                            {
                                ParkplatzFrei = true;
                            }

                    }while(ParkplatzFrei != true || ParkplatztypPasst != true);
                    
                    //Hier wird nach den Fahrzeugtyp spezifischen Daten gefragt
                    switch (fahrzeugtyp)
                    {
                        case "pkw":
                            Console.WriteLine("Geben Sie bitte den bitte geben Sie den Hubraum an:");
                            string pkwhubraumString = (Console.ReadLine());
                            if (!Int32.TryParse(pkwhubraumString, out int pkwhubraum))
                            {
                                throw new Exception();
                            }

                            Console.WriteLine("Geben Sie bitte den bitte geben Sie die Leistung an:");
                            string leistungString = (Console.ReadLine());
                            if (!Int32.TryParse(leistungString, out int leistung))
                            {
                                throw new Exception();
                            }

                            Console.WriteLine("Geben Sie bitte die Schadstoffklasse ein: (Schadstoffarm, Diesel, Normal)");
                            string schadstoffklasse = Convert.ToString(Console.ReadLine());
                            schadstoffklasse = schadstoffklasse.ToLower();

                            Schadstoffklasse EnumSchadstoffklasse;
                            if (schadstoffklasse == "schadstoffarm")
                            {
                                EnumSchadstoffklasse = Schadstoffklasse.Schadstoffarm;
                            }
                            else if (schadstoffklasse == "diesel")
                            {
                                EnumSchadstoffklasse = Schadstoffklasse.Diesel;
                            }
                            else if (schadstoffklasse == "normal")
                            {
                                EnumSchadstoffklasse = Schadstoffklasse.Normal;
                            }
                            else
                            {
                                throw new Exception();

                            }

                            alleFahrzeuge.Add(new PKW(hersteller, modell, kennzeichen, new DateTime(anschaffungsjahr, 1, 1), anschaffungspreis, ParkplatzGewünscht, pkwhubraum, leistung, EnumSchadstoffklasse));
                            fahrzeugAngelegt = true;


                            break;

                        case "lkw":

                            Console.WriteLine("Geben Sie bitte den bitte geben Sie die Anzahl der Achsen an:");
                            string anzahlAchsenString = (Console.ReadLine());
                            if (!Int32.TryParse(anzahlAchsenString, out int anzahlAchsen))
                            {
                                throw new Exception();
                            }

                            Console.WriteLine("Geben Sie bitte den bitte geben Sie die maximale Zuladung in Tonnen an:");
                            string zuladungInTonnenString = (Console.ReadLine());
                            if (!Int32.TryParse(zuladungInTonnenString, out int zuladungInTonnen))
                            {
                                throw new Exception();
                            }

                            alleFahrzeuge.Add(new LKW(hersteller, modell, kennzeichen, new DateTime(anschaffungsjahr, 1, 1), anschaffungspreis, ParkplatzGewünscht, anzahlAchsen, zuladungInTonnen));
                            fahrzeugAngelegt = true;
                            break;

                        case "motorrad":
                            Console.WriteLine("Geben Sie bitte den bitte geben Sie den Hubraum an:");
                            string motorradhubraumString = (Console.ReadLine());
                            if (!Int32.TryParse(motorradhubraumString, out int motorradhubraum))
                            {
                                throw new Exception();
                            }

                            alleFahrzeuge.Add(new Motorräder(hersteller, modell, kennzeichen, new DateTime(anschaffungsjahr, 1, 1), anschaffungspreis, ParkplatzGewünscht, motorradhubraum));
                            fahrzeugAngelegt = true;
                            break;

                    }

                    //Bei erfolgreichem erstellen des Fahrzeugs den Parkplatz belegen
                    Parkplätze[ParkplatzGewünscht - 1].Frei = false;
                    Console.WriteLine("Das Fahrzeug wurde erfolgreich angelegt");

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDie angegebenen Daten sind ungültig! Bitte geben Sie gültige Werte ein\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (fahrzeugAngelegt == false);

        }
    }
}
