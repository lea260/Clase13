using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseAbstracta
{
    public abstract class TrianguloBase
    {
        public abstract decimal Perimetro();
        public abstract decimal Area();
        public double CalcularAreaTrianguloConHipotenusa(int lado, int hipotenusa)
        {
            double ladob= Math.Sqrt(Math.Pow(hipotenusa,2) - Math.Pow(lado,2));
            return lado * ladob / 2;
        }
    }


}
