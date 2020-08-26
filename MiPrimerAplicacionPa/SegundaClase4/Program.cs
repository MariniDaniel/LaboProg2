using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaClase4
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno[] estudiantes = new Alumno[10];//creo array

            for (int i = 0; i < estudiantes.Length; i++)
            {
                estudiantes[i] = new Alumno();

                Console.ReadLine();
            }

        }
    }
}
