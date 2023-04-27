using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO
{
    public class Perro : Animal
    {
        public string Tamaño { get; set; }
        public override void HacerSonido()
        {
            Console.WriteLine($"Guau, Nombre{Nombre}, Edad: {Edad}, Tamaño: {Tamaño}");
        }
    }
}
