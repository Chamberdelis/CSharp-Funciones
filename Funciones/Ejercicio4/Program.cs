using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero”
            //que reciba un número por valor y una variable por referencia.
            //Que analice el número y escriba variable recibida por referencia con:
            // a. 1 si el número es positivo.
            // b. -1 si el número es negativo.
            // c. 0 si el número es cero.
            int
                n,
                j = 0,
                contP = 0,
                contN = 0,
                contC = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                posnegcero(n, ref j);

                switch (j)
                {
                    case 1:
                        contP++;
                        break;
                    case 0:
                        contC++;
                        break;
                    default:
                        contN++;
                        break;
                }
            }

            Console.WriteLine("La cantidad de positivos son: " + contP);
            Console.WriteLine("La cantidad de negativos son: " + contN);
            Console.WriteLine("La cantidad de neutros son: " + contC);
        }

        static void posnegcero(int a, ref int x)
        {
            if (a > 0)
            {
                x = 1;
            }
            else if (a == 0)
            {
                x = 0;
            }
            else
            {
                x = -1;
            }
        }
    }
}
