using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculo_do_INSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double sb, inss, sl;
            try
            {
                sb = Convert.ToDouble(txtsb.Text);
                inss = Convert.ToDouble(txtinss.Text);
                //Calculando e exibindo salário líquido
                sl = sb - sb * inss / 100;
                txtsl.Text = sl.ToString("##,##0.00");
                //Calculando e exibindo o desconto de INSS
                //Obs. Utilizei a mesma variável sl para desc.
                sl = sb * inss / 100;
                MessageBox.Show("Desconto de INSS R$" + sl.ToString("##,##0.00"),
                    "Alerta de desconto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Favor verifique os dados da entrada");
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtsb.Clear();
            txtinss.Clear();
            txtsl.Clear();
            txtsb.Focus();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja finalizar", "Confirme",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            Close();
        }
    }
}
