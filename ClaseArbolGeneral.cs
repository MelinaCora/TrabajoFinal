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
    	public void RecorridoPreorden()
	{
    		RecorridoPreorden(this);
    	}
     	private void RecorridoPreorden(ArbolGeneral<T> nodo)
	{
    	    	if (nodo != null)
    		{
        	    Console.WriteLine(nodo.Dato);  // Visitar el nodo actual

        	    foreach (var hijo in nodo.Hijos)
        	    {
            	    	RecorridoPreorden(hijo);  // Recorrer cada hijo en profundidad
        	    }
    	    	}
        }
	//metodo para recorrer por niveles y acceder a las poblaciones 
	public void RecorridoPorNiveles()
	{
	}

 	//metodo de agregar hijo
	public void AgregarHijo()
	{
			
	}
		
  	//metodo para obtener el hermano derecho de un nodo
	public void getHermano()
	{
			
	}
		
	//metodo para obtener los hijos de un nodo
	public void getHijos()
	{
 
	}
 
}
