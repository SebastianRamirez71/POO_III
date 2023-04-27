using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2
{
    public class Rectangulo : FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            double area = Base * Altura;
            return area;
        }

        public override double CalcularPerimetro()
        {
            double perimetro = (2 * Altura + 2 * Base);
            return perimetro;
        }
    }
}
