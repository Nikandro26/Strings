using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arbeiten mit Strings");
            string wiederholen;

            //string s = "Hallo";
            //Console.WriteLine(s);
            //for (int i = 0; i < s.Length; i++)
            //for (int i =0; i< s.Length; i+=2)
            //for (int i = s.Length-1 ; i>=0; i--)
            //{
            //    Console.WriteLine[i]);
            //}
            do
            {
                //Menü
                int auswahl;
                //string auswahl;
                Console.WriteLine("1: Zeichen ersetzen.");
                Console.WriteLine("2: Vokale entfernen.");
                Console.WriteLine("3: Queersumme bilden ");
                Console.WriteLine("4: Auf kleinbuchstaben prüfen");
                Console.WriteLine("5: Beenden");

                Console.WriteLine("Auswahl : ");
                auswahl = Convert.ToInt32(Console.ReadLine());

                switch (auswahl)
                {
                    case 1 :
                        
                        Console.WriteLine("Zeichen sollen ersetzt werden");
                        string zuErsetzen, zeichen , ersatz; ;
                        Console.WriteLine("Zeichenkette eingeben");
                        zuErsetzen = Console.ReadLine();
                        Console.WriteLine("Welches Zeichen soll ersetzt werden");
                        zeichen = Console.ReadLine();
                        Console.WriteLine("Wodurch soll " + zeichen + " Ersetzt werden?");
                        ersatz = Console.ReadLine();
                        Console.WriteLine("Es wird " + zeichen + "durch"+ ersatz + "ersetzt: ");
                        
                        

                        string ersetzt = zuErsetzen.Replace(zeichen, ersatz);

                        //for (int i = 0; i< zuErsetzen.Length; i++)
                        //{
                        //    if (zuErsetzen[i].ToString() == zeichen)
                        //    {
                        //        ersetzt += ersatz;
                        //    }
                        //    else
                        //    {
                        //        ersetzt += zuErsetzen[i];
                        //    }
                        //}
                        Console.WriteLine(zuErsetzen + " wird zu " + ersetzt);

                        break;
                    case 2:
                        Console.WriteLine("Vokale sollen entfernt werden");
                        string Zeichenkette;
                        Console.WriteLine("Zeichenkette eingeben");
                        Zeichenkette = Console.ReadLine();
                        string ergebnis ="" ;
                        string Vokale = " aieouaAIEOU ";
                        string ZeichenketteAlt = Zeichenkette;
                        string ersetz2 = "";

                        for( int i = 0; i< Vokale.Length; i++)
                        {
                            //Zeichenkette = Zeichenkette.Replace(Vokale[i].ToString(), "" );
                            //for (int j = 0; j < Zeichenkette.Length; j++) ;
                            //{
                            //    if (Zeichenkette[j]== Vokale[i])
                            //    {
                            //        ersetz2 += "";
                            //    }
                            //    else
                            //    {
                            //        ersetz2 += Zeichenkette[i];
                            //    }
                            //}
                           
                        }
                   
                        Console.WriteLine(ZeichenketteAlt + "wird zu " + Zeichenkette);
   
                        break;
                    case 3:
                        
                        
                        Console.WriteLine("Die Queersumme einer ganzen Zahl soll berechnet werden");
                        Console.Write(" Eine ganzen Zahl eingeben ");
                        string zahl = Console.ReadLine();
                        int Queersumme = 0;
                        for ( int i= 0; i<zahl.Length; i++)
                        {
                            Queersumme += Convert.ToInt32( zahl[i].ToString() );
                        }
                        Console.WriteLine(" Die Queersumme von " + zahl + " ist: " + Queersumme);

                        break;
                    case 4:
                        Console.WriteLine("Ein String wird auf kleinbuchstaben untersucht");
                        Console.Write(" Eine Zeichenkette eingeben: " );
                        string wort = Console.ReadLine();
                        int zz = 0;
                        for(int i = 0; i< wort.Length ; i++)
                        {
                            if (char.IsLower(wort[i]))
                            {
                                zz += 1;
                            }
                        }
                        if (zz>0)
                        {
                            Console.WriteLine("Kleinbuchstaben vorhanden");
                        }
                        else
                        {
                            Console.WriteLine("kein Kleinbuchstabe vorhanden. ");
                        }

                        break;

                    case 5:
                        Console.WriteLine("Programm wird beendet:");
                        break;
                }


                Console.WriteLine("Neue Auswahl? (j/n)");
                wiederholen = Console.ReadLine();
            } while (wiederholen == "j" || wiederholen == "J");
        }
    }
}
