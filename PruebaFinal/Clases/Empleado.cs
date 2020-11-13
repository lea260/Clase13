using System;

namespace PruebaFinal.Clases
{
    public abstract class Empleado 
    {
        public const decimal bolson = 1000;
        protected int antiguedad; //años de antigüedad
        private int edad;
        private string nombre;
        private string apellido;
                
        public Empleado(int edad, string nombre, string apellido, 
            int antiguedad=4)
        {
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellido;
            this.antiguedad = antiguedad;
        }
        
        //public int Edad { get => edad; set => edad = value; }



        //public abstract decimal CalcularSueldo();
    }
    
}
