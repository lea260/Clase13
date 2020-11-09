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
            Moto moto = new Coche("honda", "gtx","2 ruedas");
            Coche coche = new Coche("jumbo", "jum2",1000);
            Console.WriteLine(moto.Marca);
            Console.WriteLine(moto.Modelo);
            Console.ReadKey();
        }
    }
}
