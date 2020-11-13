using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaFinal.Clases
{
    public class Mensual : Empleado, IEmpleado
    {
        public decimal sueldoMensual;
        public Mensual(int edad, string nombre, string apellido) : 
            base(edad, nombre, apellido)
        {

        }
        public Mensual(int edad, string nombre, string apellido, decimal sueldoMensual) : 
            this(edad, nombre, apellido)
        {
            this.sueldoMensual = sueldoMensual;
        }

        public decimal CalcularSueldo()
        {
            return sueldoMensual;
        }
    }

}
