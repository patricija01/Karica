using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja___Karica_2.del
{
    class ParniZmaj : Karo
    {
        int vrstica = 0;        

        public override void izrisi(int stevilo)
        {
            int sredina = (stevilo + 1) / 2;
            int prostor = (dolzina - 3) / 2; //prostor med dvema zvezdicama

            if (vrstica == 0 || vrstica == stevilo - 1) //prva in zadnja vrstica se razlikujejo od ostalih
                praznoPolje--;
            else if (vrstica == sredina - 1) { //srednja vrsta je drugačna od vseh, čisto polna zvezdic
                Console.Write(izpis.PadLeft((dolzina - 1), '*')); //dolzina-1, ker je prva zvezdica že narisana
                praznoPolje++;
            } else {
                if (presezeno == 1) {
                    Console.Write(izpis.PadLeft(prostor, ' '));
                    Console.Write("*");
                    Console.Write(izpis.PadLeft(prostor, ' '));
                    praznoPolje--;
                } else { //presezeno == -1
                    Console.Write(izpis.PadLeft(prostor, ' '));
                    Console.Write("*");
                    Console.Write(izpis.PadLeft(prostor, ' '));
                    praznoPolje++;
                }
                Console.Write("*"); //zadnji znak je zvezdica
            }
            vrstica++;
        }
    }
}
