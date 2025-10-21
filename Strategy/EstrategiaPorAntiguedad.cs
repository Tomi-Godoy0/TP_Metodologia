namespace MetodologiaTP
{
    public class EstrategiaPorAntiguedad : IEstrategiaComparacion
    {
        public bool SosIgual(IComparable p1, IComparable p2) => ((Profesor)p1).Antiguedad == ((Profesor)p2).Antiguedad;
        public bool SosMenor(IComparable p1, IComparable p2) => ((Profesor)p1).Antiguedad < ((Profesor)p2).Antiguedad;
        public bool SosMayor(IComparable p1, IComparable p2) => ((Profesor)p1).Antiguedad > ((Profesor)p2).Antiguedad;
        
    }
}