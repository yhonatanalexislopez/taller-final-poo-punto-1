using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taller_final
{
    public class Decagramos:Gramos
    {
        public double calculardecagramos() 
        {
            return (this.getValorkmgd() * this.getvalordecagramos());
        
        
        }
    }
}
