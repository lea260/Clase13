using System;
using System.Collections.Generic;

namespace HerenciaV01
{
    //IComparable
    public class Vehiculo : IComparable<Vehiculo>
    {
        //public decimal VelocidadMaxima { get; set; }
        //public int NumeroRuedas { get; set; }
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        

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

        public int CompareTo(Vehiculo other)
        {
            int retornar=0;
            if (this.Id < other.Id)
            {
                retornar = 1;
            }
            else if (this.Id> other.Id)
            {
                retornar = -1;
            }
            else
            {
                retornar = 0;
            }

            return retornar;
        }
    }
}
