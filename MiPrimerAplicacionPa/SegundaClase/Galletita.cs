using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaClase          //namespace es una bolsa que entra clases,interfaces,objetos. agrupamos espacio de trabajo
{                               //f12 te lleva a donde esta definida la clase, f9 debugg f10 paso a paso f11 entra en metodos
    public class Galletita
    {
        string sabor;//public hace que sea  modificado como leido 
       // private bool bajasCalorias = true;//no hacer esto <---

        /// <summary>
        /// es un metodo get
        /// </summary>
        /// <returns>Devuelve el valor de sabor</returns>
        public string GetSabor() 
        {
            return this.sabor;//this para devolver el atributo de la clase "string para dar un string , si no devuelvo nada void.
        }

        //con shift y / / /  creo el summary
        /// <summary>
        /// Este metodo graba el valor que se pasa por parametro en el atributo sabor
        /// </summary>
        /// <param name="saborASetear">es la variable que se recibe</param>
        public void SetSabor(string saborASetear) 
        {
            this.sabor = saborASetear;//modifica el valor y pone el que te paso por parametro
        }
    }
}
