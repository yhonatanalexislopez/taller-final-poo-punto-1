using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace taller_final
{
    public partial class Form1 : Form
     {
        Gramos gramos = new Gramos();
        Miligramos miligramos = new Miligramos();
        Decagramos decagramos = new Decagramos();

        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            gramos.setValorkmgd(double.Parse(txtpeso.Text));

            if (rdbgramos.Checked==true)
            {
                lblresultado.Text = Convert.ToString(gramos.calcularGramos());
            
            }

            decagramos.setValorkmgd(double.Parse(txtpeso.Text));

            if (rdbdecagramos.Checked == true) 
            {
                lblresultado.Text = Convert.ToString(decagramos.calculardecagramos());
            
            }

            miligramos.setValorkmgd(double.Parse(txtpeso.Text));

            if (rdbmiligramos.Checked==true)
            {
                lblresultado.Text = Convert.ToString(miligramos.calcularmiligramos());
            
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtpeso.Text = string.Empty;
            rdbgramos.Checked = false;
            rdbdecagramos.Checked = false;
            rdbmiligramos.Checked = false;
        }

       
    }
}
