using System;

namespace MetodologiaTP
{
	//-Ejercicio 3-
    public interface IColeccionable
    {
        int Cuantos();
        IComparable Minimo();
        IComparable Maximo();
        void Agregar(IComparable c);
        bool Contiene(IComparable c);
    }
}
