using System;

namespace PruebaFinal.Clases
{
    public abstract class Empleado
    {
        private int edad;
        private string nombre;
        private string apellido;        


        public Empleado(int edad, string nombre, string apellido)
        {
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public abstract double CalcularSueldo();
    }
    
}
