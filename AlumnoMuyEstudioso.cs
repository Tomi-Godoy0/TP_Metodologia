namespace MetodologiaTP
{
    // Clase 4 - Ejercicio 2
    public class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string n, int d, int l, double p) : base(n, d, l, p){}

        public override int responderPregunta(int preg)
        {
            return preg % 3;
        }
    }
}