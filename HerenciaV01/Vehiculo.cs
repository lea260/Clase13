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

        public Vehiculo(int marca)
        {
            
        }
    }
}
