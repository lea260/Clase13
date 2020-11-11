using System;

namespace HerenciaV01
{
    public class TrianguloRectangulo : IFigura
    {
        private decimal ladoA;
        private decimal ladoB;
        private decimal hipotenusa;
        public decimal LadoA { get => ladoA; set => ladoA = value; }
        public decimal LadoB { get => ladoB; set => ladoB = value; }
        public decimal Hipotenusa { get => hipotenusa; set => hipotenusa = value; }

        public TrianguloRectangulo(decimal ladoA, decimal ladoB)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            //Hipotenusa = CalculateHipotenusa(ladoA, ladoB);            
        }
        public TrianguloRectangulo(decimal ladoA, decimal ladoB, decimal hipotenusa) :
            this(ladoA, ladoB)
        {            
            //LadoA = ladoA;
            //LadoB = ladoB;
            //Hipotenusa = CalculateHipotenusa(ladoA, ladoB);
            this.Hipotenusa = hipotenusa;
        }

        private decimal CalculateHipotenusa(decimal ladoa, decimal ladob)
        {            
            decimal hipotenusa = (decimal)Math.Sqrt((double)(ladoa * ladoa + ladob * ladob));
            //decimal hipotenusa2 = Convert.ToDecimal(Math.Sqrt((double)(ladoa * ladoa + ladob * ladob)));
            //Convert.ToDecimal(Math.Sqrt((double)(ladoa * ladoa + ladob * ladob)));
            return hipotenusa;
        }

        public decimal Area()
        {
            return LadoA * LadoB / 2;
        }

        public decimal Perimetro()
        {
            return LadoA + LadoB + Hipotenusa;
        }
    }
}
