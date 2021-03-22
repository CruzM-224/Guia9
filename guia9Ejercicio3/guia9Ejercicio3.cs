using System;

class MainClass {
  public static void Main (string[] args) {
    Double valor;
    int cantidad, posicion = 0;
    bool encontrado = false;

    Console.WriteLine ("Cuantos valores quiere ingresar en el vector");
    cantidad = int.Parse(Console.ReadLine());
    Double[] valores = new Double[cantidad];

    Console.WriteLine("Escriba los valores que quiere ingresar al vector");
    for(int cont = 0; cont < cantidad; cont++){
      valores[cont] = Double.Parse(Console.ReadLine());
    }

    Console.WriteLine("Que valor quieres buscar");
    valor = Double.Parse(Console.ReadLine());

    for(int cont = 0; cont < cantidad; cont++){
      if(valores[cont] == valor){
        posicion = cont;
        encontrado = true;
        break;
      }
    }
    
    if(encontrado == true){
      Console.WriteLine("El valor si se ha encontrado en el vector");
      Console.WriteLine("Se ha encontrado en la posicion numero " + (posicion + 1));
    }else{
      Console.WriteLine("El valor no se ha encontrado en el vector");
    }

  }
}