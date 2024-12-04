using System;

public class Calculadora
{
  public static void Main(string[] args)
  {
    // Mostrar menú de operaciones
    Console.WriteLine("=== Calculadora ===");
    Console.WriteLine("¿Qué operación desea realizar?");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicación");
    Console.WriteLine("4. División");
    Console.WriteLine("5. Salir");

    // Solicitar al usuario el número de operación
    Console.Write("Ingrese el número de la operación: ");
    string operacion = Console.ReadLine();

    // Verificar si se desea salir
    if (operacion == "5")
    {
      Console.WriteLine("Hasta luego");
      return; // Salir del programa
    }

    // Solicitar los números al usuario con validación
    double num1 = ObtenerNumero("Ingrese el primer número: ");
    double num2 = ObtenerNumero("Ingrese el segundo número: ");

    // Realizar la operación seleccionada
    switch (operacion)
    {
      case "1": // Suma
        Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
        break;

      case "2": // Resta
        Console.WriteLine("El resultado de la resta es: " + (num1 - num2));
        break;

      case "3": // Multiplicación
        Console.WriteLine("El resultado de la multiplicación es: " + (num1 * num2));
        break;

      case "4": // División
                // Verificar si el segundo número es cero
        if (num2 == 0)
        {
          Console.WriteLine("Error: No se puede dividir por cero.");
        }
        else
        {
          Console.WriteLine("El resultado de la división es: " + (num1 / num2));
        }
        break;

      default:
        Console.WriteLine("Operación inválida.");
        break;
    }
  }

  // Método para obtener un número con validación de entrada
  private static double ObtenerNumero(string mensaje)
  {
    double numero;
    bool esNumeroValido;

    // Solicitar un número al usuario hasta que se ingrese un número válido
    do
    {
      Console.Write(mensaje);
      string entrada = Console.ReadLine();
      esNumeroValido = double.TryParse(entrada, out numero);

      if (!esNumeroValido)
      {
        Console.WriteLine("Por favor, ingrese un número válido.");
      }

    } while (!esNumeroValido);

    return numero;
  }
}
