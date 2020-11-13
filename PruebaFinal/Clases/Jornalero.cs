using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaFinal.Clases
{
    public class Jornalero : Empleado
    {
        public int diasTrabajos;
        public double jornal;
        public Jornalero(int edad, string nombre, string apellido) : base(edad, nombre, apellido)
        {
        }

        public override double CalcularSueldo()
        {
            return jornal * diasTrabajos;
        }
    }
}
