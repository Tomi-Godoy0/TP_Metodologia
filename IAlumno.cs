namespace MetodologiaTP
{
    public interface IAlumno
    {
        string getNombre();
        void setNombre(string n);
        int Legajo { get; }

        int Calificacion { get; set; }
        string mostrarCalificacion();
        int responderPregunta(int preg);
    }
}