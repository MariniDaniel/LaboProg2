using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundaclase3
{
    class Program
    {
        static void Main(string[] args)
        {


            Personaje[] personajes = new Personaje[4];

            personajes[0] = new Personaje();
            personajes[1] = new Personaje();
            personajes[2] = new Personaje();
            personajes[3] = new Personaje();

            personajes[0].SetNombre("Pepe");
            personajes[1].SetNombre("Coco");
            personajes[2].SetNombre("Sayra");
            personajes[3].SetNombre("Kevin");

            /*for (int i = 0; i < personajes.Length; i++)
            {
                Console.WriteLine(personajes[i].GetNombre());
            }
            */
            Console.WriteLine("****************************");

            foreach (Personaje auxPersonaje in personajes)
            {
                Console.WriteLine(Personaje.MostarMensaje(auxPersonaje));
            }



            Console.ReadKey();

        }
    }
}
