using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taller_final
{
    public class Miligramos:Decagramos
    {
        public double calcularmiligramos() 
        {
            return (this.getValorkmgd() * this.getvalormiligramos());
        }
    }
}
