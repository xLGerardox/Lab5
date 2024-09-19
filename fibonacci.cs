using System;

namespace Fibonacci
{
    class FibonacciCalcular
    {
        public static int FibonacciIterativo(int n)
        {
            if (n <= 1)
                return n;

            int a = 0, b = 1, resultado = 0;
            for (int i = 2; i <= n; i++)
            {
                resultado = a + b;
                a = b;
                b = resultado;
            }
            return resultado;
        }

        // Método recursivo
        public static int FibonacciRecursivo(int n)
        {
            if (n <= 1)
                return n;
            return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
        }
    }
}
