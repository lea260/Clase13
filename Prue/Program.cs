using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerenciaV01;


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
            Console.ReadKey();
        }
    }
}
