using System;

namespace MetodologiaTP
{
	//-Ejercicio 3-
	public interface IColeccionable
	{
		int cuantos();
		IComparable	minimo();
		IComparable maximo();
		void agregar(IComparable c);
		bool contiene(IComparable c);
	}
}
