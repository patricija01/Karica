import 'dart:io';
import 'Karica.dart';

class NavadnaKarica extends Karica {
  @override
  void IzrisKarice(int stevilo) {
    if (presezeno == 1) {
      stdout.write(izpis.padLeft(dolzina, '*'));
      praznoPolje--;
    } else {
      stdout.write(izpis.padLeft(dolzina, '*'));
      praznoPolje++;
    }
  }
}
