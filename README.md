# Calculadora en Consola

¡Bienvenido a la calculadora básica desarrollada en **C#**! Este programa permite realizar operaciones aritméticas básicas como suma, resta, multiplicación y división de dos números ingresados por el usuario.

## Características

- Interfaz interactiva basada en consola.
- Realiza las siguientes operaciones:
  - **Suma**
  - **Resta**
  - **Multiplicación**
  - **División**
- Validación básica de entradas.
- Manejo de errores comunes (e.g., evitar divisiones entre cero).

## Requisitos

Para ejecutar este programa, necesitas:

- **Sistema operativo:** Windows, macOS o Linux.
- **.NET SDK** instalado (mínimo versión X.X).
  Puedes descargarlo desde [Microsoft .NET](https://dotnet.microsoft.com/download).

## Cómo usar

1. Clona este repositorio en tu máquina local o copia el código fuente.
2. Compila el programa usando el siguiente comando en tu terminal/prompt:
   ```bash
   dotnet run
   ```
3. Sigue las instrucciones que aparecerán en la consola:
   - Ingresa el primer número.
   - Ingresa el segundo número.
   - Selecciona la operación que deseas realizar (suma, resta, multiplicación o división).

### Ejemplo de uso

```plaintext
===Calculadora===
Ingrese Un Primer Numero: 10
Ingrese Un Segundo Numero: 5
¿Qué Operación Desea Realizar?
1. Suma
2. Resta
3. Multiplicación
4. División
Ingrese El Numero De La Operacion: 1
El Resultado De La Suma Es: 15
```

## Notas importantes

- Asegúrate de ingresar números válidos; las entradas no numéricas no son aceptadas.
- La división entre cero mostrará un mensaje de error.
- Esta calculadora está diseñada como un proyecto educativo básico para practicar C# y programación en consola.

## Mejoras futuras

- Añadir soporte para más operaciones (e.g., exponenciación, raíces cuadradas).
- Implementar una interfaz gráfica (GUI) usando WinForms o WPF.
- Validación avanzada de entradas y soporte para números decimales en formatos internacionales.
