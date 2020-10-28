using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppUE02
{
    class Program
    {
        static void Main(string[] args)
        {
            // achtung writeline
            Console.WriteLine("Hallo Welt");

            // achtung write
            Console.Write("Bitte gebe Sie eine Zahl ein: ");

            // ist ein string keine Zahl
            string fromUser = Console.ReadLine();

            // ist eine int variable wird zum konvertieren verwendet
            int convFromUser = 0;

            // die konvert funktion
            if(int.TryParse(fromUser, out convFromUser))
            {
                Console.WriteLine("Es wurde eine Zahl eingetrage");
            }
            else
            {
                Console.WriteLine("Es wurde keine Zahl eingetragen");
            }

            // alternativ
            CallDoLoop();

            if(convFromUser > 0)
            { 
                CallForLoop(convFromUser);
            }
        }

        static void CallDoLoop()
        {
            int convFromUser = 0;
            // schleife zum einlesen und convert
            do
            {
                Console.Write("Bitte geben Sie eine Zahl ein: ");
            } while (!int.TryParse(Console.ReadLine(), out convFromUser));
        }

        static void CallForLoop(int copyConvFromUser)
        {
            // ausgabe so oft
            for (int i = 0; i < copyConvFromUser; i++)
            {
                Console.WriteLine("Die Schleife wird zum x mal besucht {0}", i);
            }
        }

        static void TestMyClass()
        {
            MySuperClass myIns_01 = new MySuperClass();
            MySuperClass myIns_02 = new MySuperClass("Test");

        }
    }
}
