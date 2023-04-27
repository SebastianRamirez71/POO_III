using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2
{
    public class Circulo : FiguraGeometrica
    {
        public double Radio { get; set; }
        public override double CalcularArea()
        {
            double area = Math.PI * Math.Pow(Radio, 2);
            return area;
        }

        public override double CalcularPerimetro()
        {
            double perimetro = 2 * Math.PI * Radio;
            return perimetro;
        }
    }
}
