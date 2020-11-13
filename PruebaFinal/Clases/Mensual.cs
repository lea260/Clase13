using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaFinal.Clases
{
    public class Mensual : Empleado, IEmpleado, IBolson
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
            decimal salario = sueldoMensual;
            if (GanaBolson())
            {
                salario += bolson;
            }
            return salario;
        }

        public bool GanaBolson()
        {
            bool bolson = false;
            if (base.antiguedad > 5)
            {
                bolson = true;
            }
            return bolson;
        }


    }

}
