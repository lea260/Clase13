using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseAbstracta
{
    
    public abstract class TrianguloBase
    {
        protected int ladoA;
        protected int ladoB;
        protected int ladoC;
        public TrianguloBase(int ladoA, int ladoB, int ladoC)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
        }
        public virtual decimal Perimetro() {
            return 10;
        }
        public virtual decimal Area() {
            return 10;
        }
        public double CalcularAreaTrianguloConHipotenusa(int lado, int hipotenusa)
        {
            double ladob= Math.Sqrt(Math.Pow(hipotenusa,2) - Math.Pow(lado,2));
            return lado * ladob / 2;
        }
    }
}
