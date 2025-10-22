using System;

namespace MetodologiaTP
{
    // Clase 4 - Ejercicio 3
    public class AlumnoAdapter : Student
    {
        private IAlumno alumno;
        private int cali;

        public AlumnoAdapter(IAlumno al)
        {
            this.alumno = al;
            this.cali = 0;
        }

        public string getName() => this.alumno.getNombre();

        public int yourAnswerIs(int question) => this.alumno.responderPregunta(question); // Respuest del alumno

        public void setScore(int score)
        {
            this.cali = score;
            this.alumno.Calificacion = score;
        }

        public string showResult() => this.alumno.mostrarCalificacion();

        public bool equals(Student s) => this.cali == ((AlumnoAdapter)s).cali;
        public bool lessThan(Student s) => this.cali < ((AlumnoAdapter)s).cali;
        public bool greaterThan(Student s) => this.cali > ((AlumnoAdapter)s).cali;

    }
}