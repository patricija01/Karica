using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vpišite število med 3 in 40:");
            int stevilo = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (stevilo >= 3 && stevilo < 40)
            {
                if (stevilo % 2 == 0) //če število ni liho, izpis ni podoben kvadratku
                    Console.WriteLine("Izpis v obliki kvadrata ni mogoč.");
                else
                {
                    int prazno_polje_pred_zvezdicami = (stevilo - 1) / 2; //število praznih polj v prvi vrsti na eni strani kvadratka
                    int presezeno = 0;
                    int stevilo_zvezdic = 1; //začnemo z 1, nato vedno za 2 povečamo - dokler ne dosežemo vpisanega števila, nato za 2 zmanjšujemo

                    for (int i = 0; i < stevilo; i++) //število vrstic je enako vpisanemu številu
                    {
                        //najprej napišemo prazna polja pred zvezdicami
                        for (int x = 0; x < prazno_polje_pred_zvezdicami; x++)
                            Console.Write(" ");

                        if (presezeno == 0) //ni še najdaljša vrstica z zvezdicami
                            prazno_polje_pred_zvezdicami -= 1;
                        else //ko presežemo začnemo povečevat razmake
                            prazno_polje_pred_zvezdicami += 1;

                        //zvezdice                         
                        if (presezeno == 0)
                        { //če še nismo dosegli najdaljše vrstice z zvezdicami
                            for (int j = 0; j < stevilo_zvezdic; j++)
                            {
                                Console.Write("*");
                            }
                            stevilo_zvezdic += 2; //vedno dve več
                            if (stevilo_zvezdic == stevilo) //dosegli smo najdaljšo vrstico z zvezdicami, začnemo zmanjševat
                            {
                                presezeno = 1;
                                prazno_polje_pred_zvezdicami = 1;
                                //srednja vrstica s številom zvezdic enakemu vnesenemu številu
                                Console.WriteLine();
                                for (int y = 0; y < stevilo_zvezdic; y++)
                                    Console.Write("*");
                            }
                        }
                        else
                        {
                            for (int j = stevilo_zvezdic - 2; j >= 1; j--) //od vnesenega števila do 1 zvezdice
                            {
                                Console.Write("*");
                            }
                            stevilo_zvezdic -= 2; //vedno dve manj, dokler ni samo ena
                        }
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadKey(true);
        }
    }
}
