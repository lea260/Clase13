using System;
using System.Threading;

namespace HerenciaV01 {
    public class Moto : Vehiculo 
    {
         
        public int Cilindrada { get; set; }
        public decimal Altura { get; set; }

        public Moto(string marca, string modelo, int cilindrada ) :base(marca, modelo)
        {
        
        }
        //new sobreescribe el metodo arrancar, de vehiculo
        public new void Arrancar()
        {
            Console.WriteLine("La moto aranca");
        }




    }
}
