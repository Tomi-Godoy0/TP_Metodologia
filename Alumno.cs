using System;

namespace MetodologiaTP
{
	//Ejercicio 12
 public class Alumno : Persona, IObservador 
	{
        private int legajo;
        private double promedio;
        private IEstrategiaComparacion estrategia = new EstrategiaPorLegajo();
        public Alumno(string n, int d, int l, double p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
        }

        public int Legajo
        {
            get { return this.legajo; }
        }

        public double Promedio
        {
            get { return this.promedio; }
        }

        public void SetEstrategia(IEstrategiaComparacion n)
        {
            this.estrategia = n;
        }


        public override string ToString()
        {
            return string.Format("\n Nombre: {0} \n DNI: {1} \n Legajo: {2} \n Promedio: {3}", this.Nombre, this.DNI, this.Legajo, this.Promedio);
        }

        //Comparacion con estrategia
        public override bool SosIgual(IComparable c) => estrategia.SosIgual(this, (Alumno)c);
        public override bool SosMenor(IComparable c) => estrategia.SosMenor(this, (Alumno)c);
        public override bool SosMayor(IComparable c) => estrategia.SosMayor(this, (Alumno)c);

        //Ejercicio 11
        public void prestarAtencion()
        {
            Console.WriteLine("Prestando atención...");
        }

        public void distraerse()
        {
            string[] frases =
            {
                "Mirando el celular",
                "Dibujando en el margen de la carpeta",
                "Tirando aviones de papel"
            };

            GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
            int indice = gen.numeroAleatorio(frases.Length);

            Console.WriteLine("El Alumno {0} está {1}.", this.Nombre, frases[indice]);
        }

        public void actualizar(IObservado o)
        {
            if (((Profesor)o).estaHablando())
            {
                this.prestarAtencion();
            }
            else
            {
                this.distraerse();
            }
        }


        //Comparación por legajo 
        // public override bool SosIgual(IComparable c) => this.Legajo == ((Alumno)c).Legajo;

        // public override bool SosMenor(IComparable c) => this.Legajo < ((Alumno)c).Legajo;

        // public override bool SosMayor(IComparable c) => this.Legajo > ((Alumno)c).Legajo;
	}
}
