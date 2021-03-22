using System;

class MainClass {
  public static void Main (string[] args) {
    int numempleados, cobranentre = 0, cobranmas = 0;

    Console.WriteLine ("Escriba el numero de empleados");
    numempleados = int.Parse(Console.ReadLine());

    Double[] sueldos = new Double[numempleados];

    Console.WriteLine("Escriba los sueldos de los empleados");

    for(int cont = 0; cont < numempleados; cont++){
      sueldos[cont] = Double.Parse(Console.ReadLine());
    }

    for(int cont = 0; cont < numempleados; cont++){
      if(sueldos[cont] >= 100 && sueldos[cont] <= 300){
        cobranentre++;
      }
      if(sueldos[cont] > 350){
        cobranmas++;
      }
    }

    Console.WriteLine("El numero de empleados que cobran entre 100 y 300 es de " + cobranentre);

    Console.WriteLine("El numero de empleados que cobran mas de 350 es de " + cobranmas);
  }
}