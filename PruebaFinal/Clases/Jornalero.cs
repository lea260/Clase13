using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaFinal.Clases
{
    public class Jornalero : Empleado
    {
        public int diasTrabajos;
        public static decimal jornal=100;
        public Jornalero(int edad, string nombre, string apellido, int diasTrabajados) : 
            base(edad, nombre, apellido)
        {
            this.diasTrabajos = diasTrabajados;
        }

        public override decimal CalcularSueldo()
        {
            decimal salario= diasTrabajos*jornal;
            return salario;
        }
    }
}
