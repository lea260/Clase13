using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerenciaV01;


namespace Prue {
    class Program {
        static void Main(string[] args)
        {
            Moto moto = new Moto("honda", "gtx",1000);
            Coche coche = new Coche("jumbo", "jum2", "2 ruedas");
            Vehiculo vehiculo = (Vehiculo)moto;
            Console.WriteLine(vehiculo.Marca);
            Console.WriteLine(moto.Modelo);
            Console.ReadKey();
        }
    }
}
