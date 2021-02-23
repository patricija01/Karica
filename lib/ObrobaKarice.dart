import 'dart:io';
import 'Karica.dart';

class ObrobaKarice extends Karica {
  int vrstica = 0;

  @override
  void IzrisKarice(int stevilo) {
    int prostor = dolzina - 2; //prostor med dvema zvezdicama
    stdout.write('*');
    if (vrstica == 0 || vrstica == stevilo - 1) {
      //prva in zadnja vrstica se razlikujeta od ostalih, saj imata le eno zvezdico
      praznoPolje--;
    } else {
      if (presezeno == 1) {
        stdout.write(izpis.padLeft(dolzina - 2, ' '));
        praznoPolje--;
      } else {
        //presezeno == -1
        stdout.write(izpis.padLeft(dolzina - 2, ' '));
        praznoPolje++;
      }
      stdout.write('*');
      izpis = '';
    }
    vrstica++;
  }
}
