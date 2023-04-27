using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3
{
    public class Auto : IVehiculo
    {
        public string Marca { get; set; }

        public void Acelerar(int velocidad)
        {
            Console.WriteLine($"Acelerando moto a {velocidad} km");
        }

        public void Apagar()
        {
            Console.WriteLine($"Apagando Auto {Marca}");
        }

        public void Encender()
        {
            Console.WriteLine($"Encendiendo Auto {Marca}");
        }

        public void Frenar()
        {
            Console.WriteLine($"Frenando Auto {Marca}");
        }
    }
}
