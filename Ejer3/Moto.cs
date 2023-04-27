using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3
{
    public class Moto : IVehiculo
    {
        public int Cilindrada { get; set; }

        public void Acelerar(int velocidad)
        {
            Console.WriteLine($"Acelerando moto a {velocidad} km");
        }

        public void Apagar()
        {
            Console.WriteLine($"Apagando Motocicleta {Cilindrada}");
        }

        public void Encender()
        {
            Console.WriteLine($"Encendiendo Motocicleta {Cilindrada}");
        }

        public void Frenar()
        {
            Console.WriteLine($"Frenando Motocicleta {Cilindrada}");
        }
    }
}
