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
            Moto moto = new Moto("honda", "gtx");
            Moto moto2 = new Moto("jumbo", "jum2");
            Console.WriteLine(moto.Marca);
            Console.WriteLine(moto.Modelo);
            Console.ReadKey();
        }
    }
}
