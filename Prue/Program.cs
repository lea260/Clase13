using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerenciaV01.Modulos;

namespace Conosola01
{
    class Program {
        static void Main(string[] args)
        {
            Moto moto = new Moto("honda", "gtx",1000);
            Coche coche = new Coche("jumbo", "jum2", "2 ruedas");
            Vehiculo vehiculo = (Vehiculo)moto;
            //moto.Arrancar();
            moto.Arrancar();
            coche.Acelerar();
            IFigura cuadrado = new Cuadrado(5);
            IFigura triangulo = new TrianguloRectangulo(5, 6);
            List<IFigura> lista = new List<IFigura>();
            lista.Add(cuadrado);
            lista.Add(triangulo);
            foreach (var item in lista)
            {
                Console.WriteLine(item.Area());
                Console.WriteLine(item.Perimetro());                
            }
            Console.WriteLine("----------");
            
            Vehiculo auto = new Vehiculo(1, "uno", "modelo01");
            Vehiculo auto2 = new Vehiculo(3, "tres", "modelo03");
            Vehiculo auto3 = new Vehiculo(2, "dos", "modelo02");
            List<Vehiculo> listaVehi = new List<Vehiculo>();
            listaVehi.Add(auto);
            listaVehi.Add(auto2);
            listaVehi.Add(auto3);            
            foreach (var item in listaVehi)
            {
                Console.WriteLine($"id:{item.Id} marca:{item.Marca}modelo{item.Modelo}");
            }
            listaVehi.Sort();
            Console.WriteLine("---------ordenados-------------");
            foreach (var item in listaVehi)
            {
                Console.WriteLine($"id:{item.Id} marca:{item.Marca}modelo{item.Modelo}");
            }
            List<IFigura> list = new List<IFigura>();




            Console.ReadKey();
        }
    }
}
