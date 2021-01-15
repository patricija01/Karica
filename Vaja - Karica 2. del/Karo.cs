using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//abstraktni razred - kontrola izrisa je vedno enaka, le izrisna vrstica se spreminja

namespace Vaja___Karica_2.del
{
    public abstract class Karo //abstraktni razred
    {
        protected int dolzina = 1; //skupno število zvezdic in praznih polj med njimi
        protected int praznoPolje; //število praznih polj pred začetkom izrisa
        protected int presezeno = 1;
        protected string izpis = "";

        public abstract void izrisi(int stevilo);

        //vsi vsebujejo izris
        public void Izris(int stevilo)
        {
            //če je vneseno število parno, ga zmanjšamo za 1
            if (stevilo % 2 == 0)
                stevilo -= 1;

            //presezeno = 1; //ko karica preseže polovico izrisa            
            praznoPolje = (stevilo - 1) / 2;  //pred začetkom karice
            //dolzina = 1; //število zvezdic na začetku            

            izpis = "";

            for (int i = 0; i < stevilo; i++) { //število vrstic je enako vpisanemu številu

                if (dolzina == stevilo)
                    presezeno = -1;

                Console.Write(izpis.PadLeft(praznoPolje, ' ')); //število praznih polj pred začetkom izrisa karice

                //karica 
                Console.Write("*"); //začetek vrstice v karici je vedno zvezdica

                izrisi(stevilo);

                dolzina += (presezeno) * 2;
                Console.WriteLine();
            }            
        }
    }
}
