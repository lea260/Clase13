using System;
using System.Collections.Generic;
using System.Text;


namespace ClaseAbstracta
{
    public class Acutangulo : TrianguloBase
    {
        public Acutangulo(int ladoA, int ladoB, int ladoC):base(ladoA,ladoB,ladoC)
        {

        }
        public override decimal Area()
        {
            throw new NotImplementedException();
        }

        public override decimal Perimetro()
        {
            throw new NotImplementedException();
        }
    }
}
