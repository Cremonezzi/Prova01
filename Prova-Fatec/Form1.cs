using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_Fatec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adicao_Click(object sender, EventArgs e)
        {

            double PrimeiroNumero = double.Parse(num1.Text);
            double SegundoNumero = double.Parse(num2.Text);

            string solucao = (PrimeiroNumero + SegundoNumero).ToString();
            resultado.Text = solucao;
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            double PrimeiroNumero = double.Parse(num1.Text);
            double SegundoNumero = double.Parse(num2.Text);

            string solucao = (PrimeiroNumero - SegundoNumero).ToString();
            resultado.Text = solucao;
        }

        private void divisao_Click(object sender, EventArgs e)
        {
           if(num2.Text != "0")
            {
                double PrimeiroNumero = double.Parse(num1.Text);
                double SegundoNumero = double.Parse(num2.Text);

                string solucao = (PrimeiroNumero / SegundoNumero).ToString();
                resultado.Text = solucao;
            }

            else
            {
                resultado.Text = "Impossivel dividir por zero";
            }
          
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            double PrimeiroNumero = double.Parse(num1.Text);
            double SegundoNumero = double.Parse(num2.Text);

            string solucao = (PrimeiroNumero * SegundoNumero).ToString();
            resultado.Text = solucao;
        }

        private void num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DecimalLetra(sender, e);
        }

        private void num2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DecimalLetra(sender, e);
        }
    }
}
