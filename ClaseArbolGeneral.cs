using System;
using System.Collections.Generic;

namespace TP_obligatorio
{
    public class ArbolGeneral<T>
    {
        // Atributos
        private T Dato { get; set; }
        private List<ArbolGeneral<T>> Hijos { get; set; }

        // Constructor
        public ArbolGeneral(T dato)
        {
            Dato = dato;
            Hijos = new List<ArbolGeneral<T>>();
        }
    }
}
