using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taller_final
{
    public class Valor
    {
        private double valorkmgd;

        private double valormiligramos;

        private double valorgramos;
 
        private double valordecagramos;

        public Valor() 
        {
            double  miligramos;

             miligramos = 0.001;
             
            this.valormiligramos = miligramos;

            double gramos;

            gramos = 1;

            this.valorgramos = gramos;

            double decagramos;

            decagramos = 0.1;

            this.valordecagramos = decagramos;
        
        }
        
        public void setValorkmgd(double convertir) 
        {
            this.valorkmgd = convertir;
        
        }
        public double getValorkmgd() 
        {
            return this.valorkmgd;
        
        }

        public double getvalorgramos() 
        {
            return this.valorgramos;
        
        }
    public double getvalordecagramos()
       {

    return this.valordecagramos;

       }

    public double getvalormiligramos()
{
return this.valormiligramos;

}





    }
}
