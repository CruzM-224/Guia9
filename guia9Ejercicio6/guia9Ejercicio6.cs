using System;

class MainClass {
  public static void Main (string[] args) {
    int mayoresedad = 0;
    string[] nombres = new string[5];
    int[] edades = new int[5]; 

    Console.WriteLine("Escriba el nombre de la persona y su edad");
    for(int cont = 0; cont < 5; cont++){
      nombres[cont] = Console.ReadLine();
      edades[cont] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Mayores de edad");
    for(int cont = 0; cont < 5; cont++){
      if(edades[cont] >= 18){
        Console.WriteLine(nombres[cont] + "\n" + "Edad: " + edades[cont] + " años");
      }
    }
  }
}