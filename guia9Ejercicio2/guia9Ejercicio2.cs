using System;

class MainClass {
  public static void Main (string[] args) {
    int cantidadpiezas;
    Double aptas = 0;
    Console.WriteLine("Escriba la cantidad de piezas a procesar");

    cantidadpiezas = int.Parse(Console.ReadLine());

    Double[] piezas = new Double[cantidadpiezas];

    Console.WriteLine("Escriba las longitudes de cada perfil de hierro");

    for(int cont = 0; cont < cantidadpiezas; cont++){
      piezas[cont] = Double.Parse(Console.ReadLine());
    }

    for(int cont = 0; cont < cantidadpiezas; cont++){
      if(piezas[cont] <= 1.4 && piezas[cont] >= 1.2){
        aptas++;
      }
    }

    Console.WriteLine("La cantidad de piezas aptas en el lote es de " + aptas + " piezas");
  }
}