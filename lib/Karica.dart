import 'dart:io';

abstract class Karica {
  //abstraktni razred
  int dolzina = 1;
  int praznoPolje;
  int presezeno = 1;
  String izpis = '';

  void IzrisKarice(int stevilo); //abstraktna metoda

  void Izris(int stevilo) {
    if (stevilo % 2 == 0) {
      stevilo -= 1;
    }

    praznoPolje = ((stevilo - 1) / 2).round();
    izpis = '';

    for (int i = 0; i < stevilo; i++) {
      if (dolzina == stevilo) {
        presezeno = -1;
      }

      //število praznih polj pred začetkom izrisa karice
      stdout.write((izpis.padLeft(praznoPolje)) + ' ');

      //telo karic je različno
      IzrisKarice(stevilo);

      dolzina += (presezeno) * 2;
      print('');
    }
  }
}
