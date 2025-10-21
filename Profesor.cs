namespace MetodologiaTP
{
    //-Ejercicio 8 
    public class Profesor : Persona, IComparable, IObservado
    {
    //-Ejercicio 12
        private List<IObservador> observadores;
        private bool hablando;

        private int antiguedad = 0;
        
        private IEstrategiaComparacion estrategia = new EstrategiaPorAntiguedad();

        public Profesor(string n, int d, int a) : base(n, d)
        {
            this.antiguedad = a;
            this.observadores = new List<IObservador>();
        }

        public int Antiguedad
        {
            get { return this.antiguedad; }
        }

        public void SetEstrategia(IEstrategiaComparacion n)
        {
            this.estrategia = n;
        }

        //Ejercicio 9
        public override bool SosIgual(IComparable c) => estrategia.SosIgual(this, (Profesor)c);

        public override bool SosMayor(IComparable c) => estrategia.SosMayor(this, (Profesor)c);

        public override bool SosMenor(IComparable c) => estrategia.SosMenor(this, (Profesor)c);

        public override string ToString()
        {
            return string.Format("\n Nombre: {0} \n DNI: {1} \n Antiguedad: {2} años", this.Nombre, this.DNI, this.antiguedad);
        }

        public bool estaHablando()
        {
            return this.hablando;
        }

        public void hablarALaClase()
        {
            Console.WriteLine("Hablando de algún tema");
            hablando = true;
            notificar();
        }

        public void escribirEnElPizarron()
        {
            Console.WriteLine("Escribiendo en el pizarron");
            hablando = false;
            notificar(); //Avisa a los alumnos
        }

        public void agregarObservador(IObservador o)
        {
            this.observadores.Add(o);
        }

        public void quitarObservador(IObservador o)
        {
            this.observadores.Remove(o);
        }

        public void notificar()
        {
            foreach (IObservador obs in observadores)
            {
                obs.actualizar(this);
            }
        }
    }
}