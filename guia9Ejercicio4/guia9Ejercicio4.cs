using System;

class MainClass {
  public static void Main (string[] args) {
    Double promedio, sumatoria = 0;
    int mesventamayor = 0, mesventamenor = 0;

    Double[] ventas = new Double[9];

    Console.WriteLine ("Ingrese las ventas de recargas mensuales de los anteriores 9 meses");

    for(int cont = 0; cont < 9; cont ++){
      ventas[cont] = Double.Parse(Console.ReadLine());
    }

    for(int cont = 0; cont < 9; cont++){
      
      sumatoria += ventas[cont];

      if(ventas[mesventamayor] < ventas[cont]){
        mesventamayor = cont;
      }
      if(ventas[mesventamenor] > ventas[cont]){
        mesventamenor = cont;
      }
    }

    Console.WriteLine("Mes de venta mayor: " + (mesventamayor + 1));

    Console.WriteLine("Mes de venta menor: " + (mesventamenor + 1));

    promedio = sumatoria / 9;

    Console.WriteLine("El promedio de ventas es de $" + promedio);

    for(int cont = 0; cont < 9; cont++){
      if(ventas[cont] < promedio){
        Console.WriteLine("Las ventas del mes " + (cont + 1) + " son menores al promedio");
      }
    }
  }
}