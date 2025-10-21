namespace MetodologiaTP
{
    public class EstrategiaPorLegajo : IEstrategiaComparacion
    {
        public bool SosIgual(IComparable a1, IComparable a2) => ((Alumno)a1).Legajo == ((Alumno)a2).Legajo;
        public bool SosMenor(IComparable a1, IComparable a2) => ((Alumno)a1).Legajo < ((Alumno)a2).Legajo;
        public bool SosMayor(IComparable a1, IComparable a2) => ((Alumno)a1).Legajo > ((Alumno)a2).Legajo;
        
    }
}