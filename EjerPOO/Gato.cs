using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO
{
    public class Gato : Animal
    {
        public string Raza { get; set; }
        public override void HacerSonido()
        {
            Console.WriteLine($"Miau, Nombre: {Nombre}, Edad: {Edad}, Raza: {Raza}");
        }
    }
}
