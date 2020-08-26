using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            int numero;
            int j;
            string divisores = "";

            Console.Write("Determine hasta que numero desea realizar la busqueda de numeros perfectos: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                b = 0;

                for (j = 1; j <= (i / 2); j++)
                {
                    if (i % j == 0)
                    {
                        b += j;
                        divisores += " " + j + " ";
                    }
                }
                if (b == i)
                    Console.WriteLine("El numero " + i + " es perfecto y su divisores son: " + divisores);
                divisores = "";
            }
            Console.ReadKey();
        }
    }
    
}
