using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaV01 {
    public class Vehiculo {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo(int marca, int modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public Vehiculo(int marca)
        {
            Marca = marca;
        }
    }
}
