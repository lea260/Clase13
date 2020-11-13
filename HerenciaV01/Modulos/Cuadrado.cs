using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaV01.Modulos
{
    public sealed class Cuadrado: IFigura
    {
        readonly decimal lado;

        public readonly int hola;

        public Cuadrado(decimal lado)
        {
            hola = 10;
            this.lado = lado;
        }

        public decimal Area()
        {
            return lado * 4;
        }


        public decimal Perimetro()
        {
            return this.lado * 4;
        }
    }
}
