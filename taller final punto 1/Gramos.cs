using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taller_final
{

    public class Gramos:Valor
    {
        public double calcularGramos() 
        {
            return (this.getValorkmgd() * this.getvalorgramos());
        
        
        }

    }
}
