
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerAplicacion
{



    class Program
    {

        static void Main(string[] args)//metodos , no funciones.
        {

            DateTime horaActual = DateTime.Now;
            int salida = 0;
            suma( DateTime.Now.Minute, DateTime.Now.Second);

            Console.WriteLine("El resultado es: " + salida);
            Console.ReadLine();



        }

        static int suma(int sumando1, int sumando2) 
        {
            int resultado=0;

            if(sumando1 > 25 || sumando2 >25 )
                resultado = sumando1 +sumando2;

            return resultado;
        }
    }
}
