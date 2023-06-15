using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tabuada.Controller;

namespace Tabuada.View
{
    public partial class FormTabuada : Form
    {
        public FormTabuada()
        {
            InitializeComponent();
        }

     

   

        private void txboxnumero_TextChanged(object sender, EventArgs e)
        {
            tabuadaclasse tabu = new tabuadaclasse();

            if (txboxnumero.Text != string.Empty)
            {
                int i = Convert.ToInt32(txboxnumero.Text);
                string resultado = tabu.calcularTabuada(8);
                listBoxresul.Items.Add(resultado.ToString());
            }
            else
            {
                MessageBox.Show("Digite um número.");


            }
        }
    }
}
