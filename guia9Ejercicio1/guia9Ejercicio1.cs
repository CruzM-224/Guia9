using System;

class MainClass {

  public static void Main (string[] args) {
    Double[] notas = new Double[9];
    Double temp, cantidad = 0, parametro = 8.5;
    Console.WriteLine("Escriba las 9 notas");
    for(int cont = 0; cont < 9; cont++){
      temp = Double.Parse(Console.ReadLine());
      notas[cont] = temp;
    }

    for(int cont = 0; cont < 9; cont++){
      if(notas[cont] == parametro){
        cantidad++;
      }
    }

    Console.WriteLine("Hay " + cantidad + " notas iguales a " + parametro);
  }
}