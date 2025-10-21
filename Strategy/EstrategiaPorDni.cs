namespace MetodologiaTP
{
    public class EstrategiaPorDni : IEstrategiaComparacion
    {
        public bool SosIgual(IComparable a1, IComparable a2) => ((Alumno)a1).DNI == ((Alumno)a2).DNI;
        public bool SosMenor(IComparable a1, IComparable a2) => ((Alumno)a1).DNI < ((Alumno)a2).DNI;
        public bool SosMayor(IComparable a1, IComparable a2) => ((Alumno)a1).DNI > ((Alumno)a2).DNI;
    }
}