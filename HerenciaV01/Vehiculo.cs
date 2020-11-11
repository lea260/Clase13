﻿using System;
using System.Collections.Generic;

namespace HerenciaV01
{
    //IComparable
    public class Vehiculo : IComparable<Vehiculo>
    {
        //public decimal VelocidadMaxima { get; set; }
        //public int NumeroRuedas { get; set; }
        private int id;
        private string marca;
        private string modelo;

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }

        public Vehiculo(string marca, string modelo) 
        {            
            Marca = marca;
            Modelo = modelo;
        }

        public Vehiculo(int id, string marca, string modelo)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;            
        }

        public void Arrancar()
        {
            Console.WriteLine("El vehiculo arranca");
            
        }
        //virtual, el metodo se puede redefinir sobreescribir (enn clase hija)
        public virtual void Acelerar()
        {
            Console.WriteLine("El vehiculo acelera");
        }
        public void Apagar()
        {
            Console.WriteLine("El vehiculo apaga");
        }

        /*public int Compare(Vehiculo x, Vehiculo y)
        {
            return 1;
        }*/
        /// <summary>
        /// si this precede a other, this retorno <0 
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Vehiculo other)
        {
            //if el id de la primera es menor que other retorno -1,
            //this precede
            int retornar=0;
            if (this.Id < other.Id)
            {
                retornar = -1;
            }
            else if (this.Id> other.Id)
            {
                retornar = 1;
            }
            else
            {
                retornar = 0;
            }

            return retornar;
        }
    }
}
