using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja___Karica_2.del
{
    class ObrobaKarice : Karo
    {
        int vrstica = 0;

        public override void izrisi(int stevilo)
        {
            int prostor = dolzina - 2; //prostor med dvema zvezdicama

            if (vrstica == 0 || vrstica == stevilo - 1) //prva in zadnja vrstica se razlikujeta od ostalih, saj imata le eno zvezdico
                praznoPolje--;
            else {
                if (presezeno == 1) {
                    Console.Write(izpis.PadLeft((dolzina - 2), ' '));
                    praznoPolje--;
                } else { //presezeno == -1
                    Console.Write(izpis.PadLeft(dolzina - 2, ' '));
                    praznoPolje++;
                }
                Console.Write("*"); //zadnji znak je zvezdica
            }       
            vrstica++;
        }
    }
}
