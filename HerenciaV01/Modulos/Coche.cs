﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaV01.Modulos
{
    public class Coche : Vehiculo
    {
        public string Traccion { get; set; }
        public Coche(string marca, string modelo, string traccion) : base(marca, modelo)
        {
            Traccion = traccion;
        }
        public int Comun()
        {
            return 25;
        }
                
        public override void Acelerar()
        {
            Console.WriteLine("El coche acelera arranca");
            
        }
    }
}
