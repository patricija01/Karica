using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//OPTIMIZACIJA KARICE
//-vnos parno število: potrebno zmanjšat za 1
//-vnos ločen od izvedbe
//-dolgi if stavek ni smiseln in je nepregleden
//-izris v funkcijo pokličeš samo, če je z vpisom vse vredu
//-funkcija za pattern: z njo si prihranim for
//-preseženo na 1 in -1
//-zvezdice += (presezeno)*2 -> s tem se predznak obrne, zanka pa leti naprej

namespace Karica
{
    class Program
    {
        static int Vnos()
        {
            int stevilo = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //če je vneseno število parno, ga zmanjšamo za 1
            if (stevilo % 2 == 0)
                stevilo -= 1;

            return stevilo;
        }

        static void Izris(int stevilo)
        {
            int presezeno = 1; //ko karica preseže polovico izrisa
            int zvezdice = 1; //število zvezdic na začetku
            int praznoPolje = (stevilo - 1) / 2;

            string izpis = "";

            for (int i = 0; i < stevilo; i++) //število vrstic je enako vpisanemu številu
            {
                if (zvezdice == stevilo)
                    presezeno = -1;

                Console.Write(izpis.PadLeft(praznoPolje, ' '));            

                if (presezeno == 1)
                {
                    Console.Write(izpis.PadLeft(zvezdice, '+'));
                    praznoPolje--;
                }
                else if (presezeno == -1)
                {
                    Console.Write(izpis.PadLeft(zvezdice, '+'));
                    praznoPolje++;
                }
                
                zvezdice += (presezeno) * 2;
                
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int x; //vnos
            while (true) //dokler ni z vpisom vse ok 
            {                
                try
                {
                    Console.Write("Vpišite število med 3 in 40: ");
                    x = Vnos();                    
                    break;
                }
                catch
                {
                    Console.WriteLine("Napaka pri vpisu.");
                }
            }

            if (x >= 3 && x <= 40)
                Izris(x);
            else Console.WriteLine("Vneseno število je izven zahtevanih parametrov.");

            Console.ReadKey(true);
        }
    }
}
