using System;

namespace MetodologiaTP
{
    public abstract class Persona : IComparable
    {
        private string nombre;
        private int dni;

        public Persona(string n, int d)
        {
            this.nombre = n;
            this.dni = d;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; } //Se agrego el setter de nombre.
        }

        public int DNI
        {
            get { return this.dni; }
        }

        //Comparo por DNI
        public virtual bool SosIgual(IComparable c) => this.dni == ((Persona)c).DNI;
        
        public virtual bool SosMenor(IComparable c) => this.dni < ((Persona)c).DNI;
        
        public virtual bool SosMayor(IComparable c) => this.dni > ((Persona)c).DNI;
    }
}
