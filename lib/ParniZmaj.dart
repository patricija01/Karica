import 'dart:io';
import 'Karica.dart';

class ParniZmaj extends Karica {
  int vrstica = 0;

  @override
  void IzrisKarice(int stevilo) {
    int sredina = ((stevilo + 1) / 2).round();
    int prostor = ((dolzina - 3) / 2).round(); //prostor med dvema zvezdicama

    stdout.write('*');

    if (vrstica == 0 || vrstica == stevilo - 1) {
      //prva in zadnja vrstica se razlikujejo od ostalih
      praznoPolje--;
    } else if (vrstica == sredina - 1) {
      stdout.write(izpis.padLeft(dolzina - 1, '*'));
      praznoPolje++;
    } else {
      if (presezeno == 1) {
        stdout.write(izpis.padLeft(prostor, ' '));
        stdout.write('*');
        stdout.write(izpis.padLeft(prostor, ' '));
        praznoPolje--;
      } else {
        //presezeno == -1
        stdout.write(izpis.padLeft(prostor, ' '));
        stdout.write('*');
        stdout.write(izpis.padLeft(prostor, ' '));
        praznoPolje++;
      }
      stdout.write('*');
    }
    vrstica++;
  }
}
