using System;
using System.Collections.Generic;
using System.Text;
using ClaseAbstracta;

namespace HerenciaV01.Modulos
{
    public class Escaleno : TrianguloBase
    {

        public Escaleno(int ladoA,int ladoB,int ladoC): base(ladoA,ladoB,ladoC)
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
