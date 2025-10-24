namespace MetodologiaTP
{
    //Clase 5 - Ejercicio 1
    public class AlumnoProxy : IAlumno
    {
        private Alumno alumnoReal;
        private string nombreProxy;
        private int opcion;

        public AlumnoProxy(string nombre, int opcion)
        {
            this.nombreProxy = nombre;
            this.opcion = opcion;
            Console.WriteLine($"Alumno: {this.nombreProxy} implementado por Proxy");
        }

        //Implementamos la interface IAlumno
        //Problema que resuelve el proxy
        public string getNombre()
        {
            return this.nombreProxy;
        }

        //Problema que no puede resolver el proxy.

        public int responderPregunta(int preg)
        {
            crearAlumnoNoCreado(opcion);
            return this.alumnoReal.responderPregunta(preg); //Delego la responsabilidad a quien lo sabe hacer
        }

        public void setNombre(string n)
        {
            crearAlumnoNoCreado(opcion);
            this.alumnoReal.setNombre(n);  
        }

        public int Legajo {
            get
            {
                crearAlumnoNoCreado(opcion);
                return this.alumnoReal.Legajo;
            } 
        }

        public int Calificacion {
            get
            {
                crearAlumnoNoCreado(opcion);
                return this.alumnoReal.Calificacion;
            }

            set
            {
                crearAlumnoNoCreado(opcion);
                this.alumnoReal.Calificacion = value;
            } 
        }

        public string mostrarCalificacion()
        {
            crearAlumnoNoCreado(opcion);
            return this.alumnoReal.mostrarCalificacion();
        }
        
        //Se ejecuta este método cuándo tiene que crear la parte más compleja del alumno
        public void crearAlumnoNoCreado(int opcion) 
        {
            //Si ya esta creado no lo crea de nuevo. Si no esta el IF lo crea 10 veces
            //Si no esta creado todo el alumno, lo va a crear
            if (this.alumnoReal == null)
            {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
                alumnoReal.setNombre(this.nombreProxy);
                Console.WriteLine($"Creo el alumno real. Alumno: {nombreProxy}");
            }
        }
    }
}