using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaV01
{
    public class Cuadrado: IFigura
    {
        readonly decimal lado;

        public Cuadrado(decimal lado)
        {
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
