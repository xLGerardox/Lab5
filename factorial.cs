using System;

namespace Fibonacci
{
    class FactorialCalcular
    {
        public static int CalcularFactorial(int n)
        {

            if (n <= 1)
                return 1;

            int resultado = 1;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
