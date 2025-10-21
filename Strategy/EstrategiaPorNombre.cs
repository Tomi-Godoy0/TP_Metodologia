namespace MetodologiaTP
{
    public class EstrategiaPorNombre : IEstrategiaComparacion
    {
        public bool SosIgual(IComparable a1, IComparable a2)//Equal: Determina si esta instancia y otro string tienen el mismo valor.
        {
            return ((Alumno)a1).Nombre.Equals(((Alumno)a2).Nombre);
        }
        public bool SosMenor(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).Nombre.CompareTo(((Alumno)a2).Nombre) < 0; //CompareTo: compara si es va antes o después alfabeticamente.
        }
        public bool SosMayor(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).Nombre.CompareTo(((Alumno)a2).Nombre) > 0;
        }
    }
}