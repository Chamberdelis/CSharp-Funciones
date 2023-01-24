using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es.
            // Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero.

            //Informar el promedio teniendo en cuenta sólo los números primos.
            int
                numprim = 0,
                totalprim = 0,
                n;
            float promedio;

            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                
                if (primo(n) == true)
                {
                    numprim++;
                    totalprim += n;
                }

                Console.WriteLine("Ingrese otro numero: ");
                n = int.Parse(Console.ReadLine());
            }

            promedio = totalprim / numprim;

            Console.WriteLine("El promedio de primos es: " + promedio);
        }

        static bool primo(int a)
        {
            int contador = 0;

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    contador++;
                }
            }

            if (contador == 2)
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
