using System;
using System.Collections.Generic;

namespace TP_obligatorio
{
    public class ArbolGeneral<T>
    {
        // Atributos
        public T Dato { get; set; }
        public List<ArbolGeneral<T>> Hijos { get; set; }
        public Planeta Raiz { get; set; } // Atributo para almacenar la raíz

        // Constructor
        public ArbolGeneral()
	{
    		Hijos = new List<ArbolGeneral<T>>();
	}

       public void RecorridoPreorden()
        {
            Console.WriteLine(Dato);
            foreach (ArbolGeneral<T> hijo in Hijos)
            {
                hijo.RecorridoPreorden();
            }
        }
    		
	//metodo de agregar hijo
				
	public void AgregarHijo( ArbolGeneral<T> nodoHijo)
	{
    		Hijos.Add(nodoHijo);
    	}
		
	//metodo para obtener los hijos de un nodo
	public List<ArbolGeneral<T>> getHijos()
	{
    		return Hijos;
	}
		
	public void EliminarHijo(ArbolGeneral<T> nodoHijo)
	{
		Hijos.Remove(nodoHijo);
	}
		
	public void AgregarHijoAunDeterminadoNodo(ArbolGeneral<T> datoPadre, ArbolGeneral<T> datoHijo)
	{
    		if (datoPadre != null)
    		{
        	// Crear un nuevo nodo para el hijo
        	ArbolGeneral<T> nuevoNodoHijo = new ArbolGeneral<T>();
        
        	// Agregar el nuevo nodo como hijo del nodo padre
        	datoPadre.AgregarHijo(nuevoNodoHijo);
    		}
	}
	
    }   
    
}
