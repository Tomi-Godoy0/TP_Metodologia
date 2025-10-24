namespace MetodologiaTP
{
    // Clase 5 - Ejercicio 3
    public class Aula 
    {
        private Teacher teacher;

        public void comenzar()
        {
            teacher = new Teacher();
            Console.WriteLine("Comenzamos la clase");
        }

        public void nuevoAlumno(IAlumno alumno)
        {
            //Implementamos funciones de MDPI
            //Adaptamos alumno para usar al student. Porque .goToClass necesita a un student.
            this.teacher.goToClass(new AlumnoAdapter(alumno)); 
            Console.WriteLine($"Ingresa en la clase el alumno: {alumno.getNombre()}");
        }

        public void claseLista() //La clase esta lista para empezar
        {
            Console.WriteLine("Clase lista, el salón esta lleno");
            this.teacher.teachingAClass();
            Console.WriteLine("Clase concluida");
        }
    }

}