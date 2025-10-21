namespace MetodologiaTP
{
    public class Conjunto : IColeccionable, IIterable
    {
        private List<IComparable> elementos = new List<IComparable>();

        public void Agregar(IComparable c)
        {
            if (!Contiene(c))
            {
                this.elementos.Add(c);
            }
        }

        public bool Pertenece(IComparable c) => Contiene(c);

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

        public bool Contiene(IComparable c)
        {
            foreach (IComparable i in elementos)
            {
                if (i.SosIgual(c))
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
    }
}