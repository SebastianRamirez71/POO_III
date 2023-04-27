using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2
{
    public class Cuadrado : FiguraGeometrica
    {
        public double Lado { get; set; }
        public override double CalcularArea()
        {
            double area = Lado * Lado;
            return area;
        }

        public override double CalcularPerimetro()
        {
            double perimetro = Lado * 4;
            return perimetro;
        }
    }
}
