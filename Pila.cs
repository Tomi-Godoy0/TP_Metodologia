using System;
using System.Linq;
using System.Collections.Generic;

namespace MetodologiaTP
{
    public class Pila : IColeccionable, IIterable, IOrdenable//Es una colección Lifo (Last In, First Out) 
    {
        private List<IComparable> elementos;

        private IOrdenEnAula1 ordenInicio, ordenAulaLlena;
        private IOrdenEnAula2 ordenLlegaAlumno;        

        public Pila()
        {
            this.elementos = new List<IComparable>();
        }

        public void Apilar(IComparable c)
        {
            this.elementos.Add(c);

            if (this.elementos.Count == 1 && ordenInicio != null)
            {
                this.ordenInicio.ejecutar();
            }

            if (this.ordenLlegaAlumno != null)
            {
                this.ordenLlegaAlumno.ejecutar(c);
            }
            
            if (this.elementos.Count == 40 && ordenAulaLlena != null)
            {
                this.ordenAulaLlena.ejecutar();
            }            
        }

        public IComparable Desapilar()
        {
            IComparable aux = this.elementos[elementos.Count - 1];

            this.elementos.RemoveAt(this.elementos.Count - 1);

            return aux;
        }

        public int Cuantos() => this.elementos.Count();

        public IComparable Minimo()
        {
            IComparable minActual = this.elementos[0];
            int n = Cuantos();

            for (int i = 0; i < n; i++)
            {
                if (elementos[i].SosMenor(minActual))
                {
                    minActual = elementos[i];
                }
            }

            return minActual;
        }

        public IComparable Maximo()
        {
            IComparable maxActual = this.elementos[0];
            int n = Cuantos();

            for (int i = 0; i < n; i++)
            {
                if (elementos[i].SosMayor(maxActual))
                {
                    maxActual = elementos[i];
                }
            }

            return maxActual;
        }

        public void Agregar(IComparable c)
        {
            this.Apilar(c);
        }

        public bool Contiene(IComparable c)
        {
            foreach (IComparable e in elementos)
            {
                if (e.SosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }

        public IIterador CrearIterador()
        {
            return new IteradorDeLista(this.elementos);
        }
        
        // Clase 5 - Ejercicio 9 - El invocador va a ser la pila y cola
        //Setea en la pila las ordenes que vamos a ejecutar
        public void setOrdenInicio(IOrdenEnAula1 orden)
        {
            this.ordenInicio = orden;
        }

        public void setOrdenLlegaAlumno(IOrdenEnAula2 orden)
        {
            this.ordenLlegaAlumno = orden;
        }

        public void setOrdenAulaLlena(IOrdenEnAula1 orden)
        {
            this.ordenAulaLlena = orden;
        }
    }
}
