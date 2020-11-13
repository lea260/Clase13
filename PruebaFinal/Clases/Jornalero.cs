namespace PruebaFinal.Clases
{
    public class Jornalero : Empleado, IEmpleado, IBolson 
    {       
        private int diasTrabajos;
        public static decimal jornal=100;
        public Jornalero(int edad, string nombre, string apellido, 
            int diasTrabajados) : 
            base(edad, nombre, apellido)
        {
            this.diasTrabajos = diasTrabajados;
        }

        public decimal CalcularSueldo()
        {
            decimal salario = diasTrabajos * jornal;
            if (GanaBolson())
            {
                salario += bolson;
            }

            return salario;
        }

        public bool GanaBolson()
        {
            bool bolson = false;
            if (base.antiguedad > 3)
            {
                bolson = true;
            }
            return bolson;
        }

    }
}
