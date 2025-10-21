namespace MetodologiaTP
{
    public interface IEstrategiaComparacion
    {
        bool SosIgual(IComparable a1, IComparable a2);
        bool SosMenor(IComparable a1, IComparable a2);
        bool SosMayor(IComparable a1, IComparable a2);
    }
}