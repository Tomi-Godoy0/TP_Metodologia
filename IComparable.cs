using System;

namespace MetodologiaTP
{	
    public interface IComparable
    {
        bool SosIgual(IComparable c);
        bool SosMenor(IComparable c);
        bool SosMayor(IComparable c);
    }
}
