using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO
{
    public class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public virtual void HacerSonido()
        {
            
        }
    }
}
