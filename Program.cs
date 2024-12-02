using System;


public class Calciuladora
{

  public static void Main(string[] args)
  {
    Console.WriteLine("===Calculadora===");

    Console.Write("Ingrese Un Primer Numero: ");
    string entrada1 = Console.ReadLine();
    double num1 = double.Parse(entrada1);

    Console.Write("Ingrese Un Segundo Numero: ");
    string entrada2 = Console.ReadLine();
    double num2 = double.Parse(entrada2);

    Console.WriteLine("¿Que Operacion Desea Realizar?");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicacion");
    Console.WriteLine("4. Division");

    Console.Write("Ingrese El Numero De La Operacion: ");
    string operacion = Console.ReadLine();




  }



}
