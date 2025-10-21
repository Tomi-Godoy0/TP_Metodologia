using System.Runtime.InteropServices;

namespace MetodologiaTP
{
    public class IteradorDeLista : IIterador
    {
        private List<IComparable> elementos;
        private int ind; //Indice


        public IteradorDeLista(List<IComparable> l)
        {
            this.elementos = l;
            this.ind = 0;
        }

        public IComparable Actual() => this.elementos[this.ind];

        public void Primero() => this.ind = 0;

        public void Siguiente() => this.ind++;

        public bool Fin() => ind >= elementos.Count;
    }
}