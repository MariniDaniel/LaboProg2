using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaClase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Parte 1
            Galletita galletita_1;//guardame espacio
            galletita_1 = new Galletita();//aca haceme la galletita
            
            Galletita galletita_2 = new Galletita();//igual que lo anterior pero en una linea de codigo."mas usada esta "

            //no lo usamos ya galletita_1.sabor = "Vainilla";

            string saborcito = galletita_1.sabor;

            galletita_1.bajasCalorias = true;
            */

            Galletita galletita_1 = new Galletita();
            Galletita galletita_2 = new Galletita();

            galletita_1.SetSabor("Vainilla");
            galletita_2.SetSabor("Chocolate");

            Console.WriteLine(galletita_1.GetSabor());//me da el sabor
            Console.WriteLine(galletita_2.GetSabor());//me da el sabor
            Console.ReadKey();


        }
    }
}
