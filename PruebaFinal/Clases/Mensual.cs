using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaFinal.Clases
{
    public class Mensual : Empleado
    {
        double sueldoMensual;
        public Mensual(int edad, string nombre, string apellido) : base(edad, nombre, apellido)
        {

        }
        public Mensual(int edad, string nombre, string apellido, double sueldoMensual) : this(edad, nombre, apellido)
        {
            this.sueldoMensual = sueldoMensual;
        }

        public override double CalcularSueldo()
        {
            return sueldoMensual;
        }
    }
}
