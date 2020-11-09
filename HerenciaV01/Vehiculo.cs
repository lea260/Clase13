using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaV01 {
    public class Vehiculo {
        public decimal VelocidadMaxima { get; set; }
        public int NumeroRuedas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
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
