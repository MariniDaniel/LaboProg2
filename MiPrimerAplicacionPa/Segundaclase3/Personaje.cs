using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundaclase3
{
    class Personaje
    {




        string nombre;
        int edad;

        public void SetNombre(string auxNomb)
        {
            this.nombre = auxNomb;
        }

        private string GetNombre()
        {
            return this.nombre;
        }

        public static string MostarMensaje(Personaje auxPersonaje)//static porque es de la clase
        {

            return auxPersonaje.GetNombre();
        }




    }
}
