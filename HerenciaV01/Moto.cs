using System;
using System.Threading;

namespace HerenciaV01 {
    public class Moto : Vehiculo 
    {

        private int cilindrada;
        private decimal altura;

        public int Cilindrada { get => cilindrada; set => cilindrada = value; }
        public decimal Altura { get => altura; set => altura = value; }

        public Moto(string marca, string modelo, int cilindrada) : base(marca, modelo)
        {
            if (string.IsNullOrEmpty(marca))
            {
                throw new ArgumentException($"'{nameof(modelo)}' cannot be null or empty", nameof(marca));
            }
            if (cilindrada<50)
            {
                throw new ArgumentOutOfRangeException("marca", "marca debe ser mayor o igual a 50");
            }

            if (string.IsNullOrEmpty(modelo))
            {
                //$ string interpolation. 
                throw new ArgumentException($"'{nameof(modelo)}' cannot be null or empty", nameof(modelo));
            }
        }
        //new sobreescribe el metodo arrancar, de vehiculo
        public new void Arrancar()
        {
            Console.WriteLine("La moto aranca");
        }
    }
}
