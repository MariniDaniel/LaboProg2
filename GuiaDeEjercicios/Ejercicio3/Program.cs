using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            int primosPorMostrar, numeros;
            int esPrimo;

            Console.WriteLine("Cuantos primos desea mostrar: ");
            primosPorMostrar = int.Parse(Console.ReadLine());

            numeros = 2;
            while (primosPorMostrar > 0)
            {

                /* determinar si n es primo */
                esPrimo = 1;
                for (int i = 2; i < numeros; i++)
                {
                    if (numeros % i == 0)
                    {
                        esPrimo = 0;
                        break;
                    }
                }

                /* mostrar el numero
                 * y actualizar el contador */
                if (esPrimo == 0)
                {
                    Console.WriteLine(numeros);
                    primosPorMostrar--;
                }
                numeros++;
            }

            Console.ReadLine(); 
          
        }
    }
}
