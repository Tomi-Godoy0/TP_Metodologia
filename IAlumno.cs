namespace MetodologiaTP
{
    public interface IAlumno
    {
        string getNombre();
        int Legajo { get; }

        int Calificacion { get; set; }
        string mostrarCalificacion();
        int responderPregunta(int preg);
    }
}