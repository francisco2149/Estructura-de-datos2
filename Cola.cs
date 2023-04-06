using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_datos2
{
    class Cola
    {
        public Nodo primero;
        public Nodo Ultimo;

        public void AGREGAR(Nodo nuevo)
        {
            if (primero == null) 
            {
                primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;
            }
        }
        public void Eliminar()
        {
            if(primero== Ultimo)
            {
                primero = null;
                Ultimo = null;
            }
            else
            {
                primero = primero.Siguiente;
            }
        }
    }
}
