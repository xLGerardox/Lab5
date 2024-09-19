using Fibonacci;
using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Menú Principal");
                Console.WriteLine("1. Calcular Factorial");
                Console.WriteLine("2. Calcular Fibonacci");
                Console.WriteLine("3. Salir");
                Console.WriteLine("==========================");
                Console.Write("Selecciona una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CalcularFactorial();
                        break;
                    case "2":
                        CalcularFibonacci();
                        break;
                    case "3":
                        salir = true;
                        Console.WriteLine("Saliendo del programa...");
                        Console.WriteLine("Aqui le da la salida, esperando que vuelva");
                        break;
                    default:
                        Console.WriteLine("No es valida la opción elegida.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // calcular el factorial
        static void CalcularFactorial()
        {
            Console.Clear();
            Console.WriteLine("Calcular Factorial");
            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());
            int resultado = FactorialCalcular.CalcularFactorial(numero);
            Console.WriteLine($"El factorial de {numero} es: {resultado}");
            Console.WriteLine("Presiona cualquier tecla para volver al menú... :)");
            Console.ReadKey();
        }

        // calcular Fibonacci
        static void CalcularFibonacci()
        {
            Console.Clear();
            Console.WriteLine("Ahora se le presenta un menú para que elija si lo hará de forma " +
                               "recursiva o iterativa");
            Console.WriteLine("Menú Fibonacci");
            Console.WriteLine("1. Recursivo");
            Console.WriteLine("2. Iterativo");
            Console.WriteLine("==========================");
            Console.Write("Selecciona una opción: ");

            string opcion = Console.ReadLine();
            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case "1":
                    int resultadoRecursivo = FibonacciCalcular.FibonacciRecursivo(numero);
                    Console.WriteLine("Ahora le entrega el resultado del método recursivo");
                    Console.WriteLine($"El Fibonacci recursivo de {numero} es: {resultadoRecursivo}");
                    break;
                case "2":
                    int resultadoIterativo = FibonacciCalcular.FibonacciIterativo(numero);
                    Console.WriteLine("Ahora le entrega el resultado con método iterativo");
                    Console.WriteLine($"El Fibonacci iterativo de {numero} es: {resultadoIterativo}");
                    break;
                default:
                    Console.WriteLine("En este caso, la opción ingresada no es valida " +
                        "debe intentar de nuevo.");
                    break;
            }
            Console.WriteLine("Presiona cualquier tecla para volver al menú... :)");
            Console.ReadKey();

        }
    }
}
