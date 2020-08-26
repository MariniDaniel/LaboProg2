using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int cantidad;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            float promedio = 0;

            Console.WriteLine("Cuantos numeros va a ingresar? ; ");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese un numero:  ");
                numero = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                else
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    else if (numero < minimo)
                    {
                        minimo = numero;
                    }

                }

                promedio += numero;
            }

            promedio = promedio / cantidad;


            Console.WriteLine($"El maximo es {maximo}");
            Console.WriteLine($"El minimo es {minimo}");
            Console.WriteLine($"El promedio Total es {promedio}");

            Console.ReadKey();
            Console.ReadKey();


        }
    }
}
