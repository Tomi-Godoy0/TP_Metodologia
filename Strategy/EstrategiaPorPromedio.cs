namespace MetodologiaTP
{
    public class EstrategiaPorPromedio : IEstrategiaComparacion
    {
        public bool SosIgual(IComparable a1, IComparable a2) => ((Alumno)a1).Promedio == ((Alumno)a2).Promedio;
        public bool SosMenor(IComparable a1, IComparable a2) => ((Alumno)a1).Promedio < ((Alumno)a2).Promedio;
        public bool SosMayor(IComparable a1, IComparable a2) => ((Alumno)a1).Promedio > ((Alumno)a2).Promedio;
    }
}