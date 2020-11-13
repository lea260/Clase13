using System;

namespace HerenciaV01.Modulos
{
    public class TrianguloRectangulo : IFigura
    {
        public decimal LadoA { get; set; }
        public decimal LadoB { get; set; }
        public decimal Hipotenusa { get; set; }

        public TrianguloRectangulo(decimal ladoA, decimal ladoB)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            Hipotenusa = CalculateHipotenusa(ladoA, ladoB);
        }

        private decimal CalculateHipotenusa(decimal ladoa, decimal ladob)
        {
            //
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
