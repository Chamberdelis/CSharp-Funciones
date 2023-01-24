using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
            // Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            int
                n,
                cont = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Escriba un numero para analizar: ");
                n = int.Parse(Console.ReadLine());

                if (par(n) == true)
                {
                    cont++;
                }
            }

            Console.WriteLine("La cantidad de pares es:  " + cont);
        }

        static bool par(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
