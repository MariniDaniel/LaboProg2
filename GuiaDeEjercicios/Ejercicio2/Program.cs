using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;
            double cubo;
            double cuadrado ;


            Console.WriteLine("Ingrese el numero que desea elevar al cubo y al cuadrado:  ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                cubo = Math.Pow(numero, 2);//al cuadrado
                cuadrado = Math.Pow(numero, 3);//al cubo 

                Console.WriteLine($"El cubo de su numero es : {cubo}");
                Console.WriteLine($"El cuadrado de su numero es : {cuadrado}");
            }
            else
            {
                Console.WriteLine("El numero debe ser mayor a 0 ");
                Console.ReadLine();
            }



            Console.ReadLine();
        }
    }
}
