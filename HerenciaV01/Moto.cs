using System;
using System.Threading;

namespace HerenciaV01 {
    public class Moto : Vehiculo 
    {
         
        public int NumeroRuedas { get; set; }
        public decimal Altura { get; set; }

        public Moto(string marca, string modelo ) :base(marca, modelo)
        {
        
        }

        public Moto(string marca) : base(marca)
        {

        }



        public void Arrancar()
        {
            Console.WriteLine("La moto aranca");
        }
        public void Acelerar()
        {
            Console.WriteLine("La moto acelera");
        }
        public void Apagar()
        {
            Console.WriteLine("La moto para");
        }
    }
}
