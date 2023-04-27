using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3
{
    public interface IVehiculo
    {
        public void Encender();
        public void Apagar();
        public void Frenar();

        public void Acelerar(int velocidad);
        
        
        

    }
}
