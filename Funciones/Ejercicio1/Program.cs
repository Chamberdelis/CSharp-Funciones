using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos.
            //Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y
            //muestre por pantalla el monto total a pagar. Usar la función.
            int
                p,
                c,
                m;

            Console.WriteLine("Ingrese el precio del producto X: ");
            p = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad vendida del producto X: ");
            c = int.Parse(Console.ReadLine());

            m = producto(p, c);

            Console.WriteLine("El monto total es:  " + m);
        }

        static int producto(int a, int b)
        {
            int r;
            r = a * b;
            return r;
        }
    }
}
