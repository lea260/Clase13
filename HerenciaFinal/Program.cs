using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaFinal.Clases;

namespace ConsolaV02
{
    class Program
    {
        static void Main(string[] args)
        {            
            Jornalero emp01 = new Jornalero(18, "Juan","Peres",20);
            Jornalero emp02 = new Jornalero(26, "Alicia", "Fontes", 15);
            Mensual emp03 = new Mensual(21, "Alicia", "Fontes",1000);
            List<IEmpleado> listEmpleados = new List<IEmpleado>() { emp01, emp02, emp03 };            
            decimal sueldoTotal = 0;
            Jornalero.jornal = 200;
            foreach (var item in listEmpleados)
            {
                sueldoTotal += item.CalcularSueldo();                
            }
            Console.WriteLine("----------------sueldo------------------");
            Console.WriteLine("sueldo: "+sueldoTotal.ToString());
            Console.ReadKey();
        }
    }
}
