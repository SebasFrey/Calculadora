using System;


public class Calciuladora
{

  public static void Main(string[] args)
  {
    Console.WriteLine("===Calculadora===");
    Console.WriteLine("¿Que Operacion Desea Realizar?");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicacion");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Salir");

    Console.Write("Ingrese El Numero De La Operacion: ");
    string operacion = Console.ReadLine();

    Console.Write("Ingrese Un Primer Numero: ");
    string entrada1 = Console.ReadLine();
    double num1 = double.Parse(entrada1);

    Console.Write("Ingrese Un Segundo Numero: ");
    string entrada2 = Console.ReadLine();
    double num2 = double.Parse(entrada2);

    double suma = num1 + num2;

    double resta = num1 - num2;

    double multiplicacion = num1 * num2;

    double division = num1 / num2;

    switch (operacion)
    {

      case "1":
        Console.WriteLine("El Resultado De La Suma Es: " + suma);
        break;

      case "2":
        Console.WriteLine("El Resultado De La Resta Es: " + resta);
        break;

      case "3":
        Console.WriteLine("El Resultado De La Multiplicacion Es: " + multiplicacion);
        break;

      case "4":
        Console.WriteLine("El Resultado De La Division Es: " + division);
        break;

      case "5":
        Console.WriteLine("Hasta Luego");
        break;
        
      default:
        Console.WriteLine("Operacion Invalidad.");
        break;

    }
  }
}
