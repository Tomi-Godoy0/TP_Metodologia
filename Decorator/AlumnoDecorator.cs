namespace MetodologiaTP
{
    //Clase 4 - Ejercicio 6 - Todos los decoradores
    public abstract class AlumnoDecorator : IAlumno
    {

        protected IAlumno adicional;

        public AlumnoDecorator(IAlumno a)
        {
            this.adicional = a;
        }

        public string getNombre() => adicional.getNombre();

        public void setNombre(string n) => this.adicional.setNombre(n);

        public int Legajo
        {
            get { return adicional.Legajo; }
        }
        
        public int Calificacion
        {
            get { return adicional.Calificacion; }
            set { adicional.Calificacion = value; }
        }

        public virtual string mostrarCalificacion()
        {
            return adicional.mostrarCalificacion();
        }

        public virtual int responderPregunta(int preg)
        {
            return adicional.responderPregunta(preg);
        }
    }
}