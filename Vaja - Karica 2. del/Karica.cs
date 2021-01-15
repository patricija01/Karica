using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja___Karica_2.del
{
    public class Karica : Karo
    {
        public override void izrisi(int stevilo)
        {
            if (presezeno == 1) {
                Console.Write(izpis.PadLeft(dolzina-1, '*'));
                praznoPolje--;
            } else { //presezeno == -1
                Console.Write(izpis.PadLeft(dolzina-1, '*'));
                praznoPolje++;
            }
        }
    }
}
