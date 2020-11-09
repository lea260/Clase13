using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaV01 {
    public class Coche : Vehiculo
    {
        public string Traccion { get; set; }
        public Coche(string marca, string modelo, string traccion) : base(marca, modelo)
        {
            Traccion = traccion;
        }
        
        
        


    }
}
