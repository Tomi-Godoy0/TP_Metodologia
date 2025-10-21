using System;

namespace MetodologiaTP
{
    public class ColeccionMultiple : IColeccionable
    {
        Pila pila;
        Cola cola;

        public ColeccionMultiple(Pila p, Cola c)
        {
            this.pila = p;
            this.cola = c;
        }

        public int Cuantos() => this.pila.Cuantos() + this.cola.Cuantos();

        public IComparable Minimo()
        {
            if (pila.Minimo().SosMenor(cola.Minimo()))
            {
                return pila.Minimo();
            }
            else
            {
                return cola.Minimo();
            }
        }

        public IComparable Maximo()
        {
            if (pila.Maximo().SosMayor(cola.Maximo()))
            {
                return pila.Maximo();
            }
            else
            {
                return cola.Maximo();
            }
        }

        public void Agregar(IComparable c)
        {
            
        }

        public bool Contiene(IComparable c) => pila.Contiene(c) || cola.Contiene(c);
    }
}
