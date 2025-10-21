using System;

namespace MetodologiaTP
{
	//-Ejercicio 2-
    public class Numero : IComparable
    {
        private int valor;

        public Numero(int v)
        {
            this.valor = v;
        }

        public int Valor
        {
            get { return this.valor; }
        }

        public override string ToString()
        {
            return valor.ToString();
        }


        public bool SosIgual(IComparable c) => this.valor == ((Numero)c).Valor;

        public bool SosMenor(IComparable c) => this.valor < ((Numero)c).Valor;
        
        public bool SosMayor(IComparable c) => this.valor > ((Numero)c).Valor;
    }
}
