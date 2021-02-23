import 'dart:io';
import 'package:karica/NavadnaKarica.dart';

import 'Karica.dart';
import 'ObrobaKarice.dart';
import 'ParniZmaj.dart';

void main(List<String> arguments) {
  int x = -1; //dolžina
  int izbira = -1;

  //izbira oblike
  izbira = Meni();
  print('\n');
  print('Tvoja izbira: $izbira');

  do {
    //vpis velikosti karice
    try {
      print('Vpišite število med 3 in 40:');
      x = Vnos();
    } catch (e) {
      print('Napaka pri vpisu.');
    }

    //izvedba
    if (x < 3 || x > 40) {
      print(
          'Vneseno število je izven zahtevanih mej, ponovite ali vpisi 0 za izhod.');
      print('\n');
    } else {
      print('\n');
      if (izbira == 1) {
        ObrobaKarice K = new ObrobaKarice();
        K.Izris(x);
      } else if (izbira == 2) {
        ParniZmaj P = new ParniZmaj();
        P.Izris(x);
      } else {
        //izbira == 3
        NavadnaKarica X = new NavadnaKarica();
        X.Izris(x);
      }
    }
  } while ((x < 3 || x > 40) && (x != 0));
}

int Vnos() {
  int stevilo = int.parse(stdin.readLineSync());
  return stevilo;
}

int Meni() {
  print('Meni: ');
  print('1 - Obroba karice');
  print('2 - Parni zmaj');
  print('3 - Navadna karica');
  print('\n');
  int izbira = -1;

  do {
    try {
      print('Izbira: ');
      izbira = int.parse(stdin.readLineSync());
    } catch (e) {
      print('Napaka pri vpisu.');
    }

    if (izbira < 1 || izbira > 3) {
      print(
          'Vnesen izbira je izven zahtevanih mej. Prosimo vas za ponoven vpis.\n');
    }
  } while (izbira < 1 || izbira > 3);

  return izbira;
}
