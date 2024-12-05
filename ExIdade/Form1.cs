using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CalcularIdadeEmDias(int anos, int meses, int dias)
        {

            int idadeEmDias = (anos * 365) + (meses * 30) + dias;
            return idadeEmDias;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anos = int.Parse(txtAnos.Text);  
            int meses = int.Parse(txtMeses.Text);   
            int dias = int.Parse(txtDias.Text);
            
            
            int idadeEmDias = CalcularIdadeEmDias(anos, meses, dias);

            
            txtResult.Text = idadeEmDias.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAnos.Clear();
            txtMeses.Clear();
            txtDias.Clear();
            txtResult.Clear();
            txtResult.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
