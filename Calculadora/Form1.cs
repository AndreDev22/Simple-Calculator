using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : MetroForm
    {
        double nNum1, nNum2;
        char cOper = ' ';


        public Form1()
        {
            InitializeComponent();
        }

        private void fnCalcula()
        {
            double.TryParse(txtValor.Text, out nNum2);

            switch (cOper)
            {
                case '+': txtValor.Text = (nNum1 + nNum2).ToString(); break;
                case '-': txtValor.Text = (nNum1 - nNum2).ToString(); break;
                case '*': txtValor.Text = (nNum1 * nNum2).ToString(); break;
                case '/': txtValor.Text = (nNum1 / nNum2).ToString(); break;
                default: MessageBox.Show("Operação não implementada"); break;
            }

            cOper = ' ';
        }

        private void fnPreencherValor(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtValor.Tag) == 1)
                txtValor.Text = "";
            txtValor.Text += ((Button)sender).Text;
            txtValor.Tag = 0;
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtValor.Tag = 0;
            cOper = ' ';
        }

        private void cmdResultado_Click(object sender, EventArgs e)
        {


            fnCalcula();
        }

        private void cmdInverte_Click(object sender, EventArgs e)
        {
            txtValor.Text = (double.Parse(txtValor.Text) * -1).ToString();
        }

        private void cmdDecimal_Click(object sender, EventArgs e)
        {
            if (!txtValor.Text.Contains(","))
                txtValor.Text += ",";
            //if (txtValor.Text.IndexOf(",")<0)
            //    txtValor.Text += ",";
        }

        private void fnPressionaTecla(object sender, KeyEventArgs e)
        {
            //txtValor.Text= e.KeyCode.ToString();

            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                case Keys.NumPad1:
                case Keys.NumPad2:
                case Keys.NumPad3:
                case Keys.NumPad4:
                case Keys.NumPad5:
                case Keys.NumPad6:
                case Keys.NumPad7:
                case Keys.NumPad8:
                case Keys.NumPad9:
                    if (Convert.ToInt16(txtValor.Tag) == 1)
                        txtValor.Text = "";
                    txtValor.Text += (e.KeyValue - 96).ToString();
                    txtValor.Tag = 0;
                    break;
                case Keys.Escape:
                    cmdLimpar_Click(null, null);
                    break;
                case Keys.Add:
                    fnOperacao(cmdAdicao, null);
                    break;
                case Keys.Subtract:
                    fnOperacao(cmdSubtracao, null);
                    break;
                case Keys.Multiply:
                    fnOperacao(cmdMultiplicacao, null);
                    break;
                case Keys.Divide:
                    fnOperacao(cmdDivisao, null);
                    break;
                case Keys.Back:
                    btnDel_Click(null, null);
                    break;
                case Keys.Return:
                    fnCalcula();
                    break;


            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtValor.Text != null)
                txtValor.Text = txtValor.Text.Remove(txtValor.Text.Length - 1);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
        }

        private void btnFat_Click(object sender, EventArgs e)
        {
            int aux;
            if (int.TryParse(txtValor.Text, out aux))
            {
                cOper = ' ';
                txtValor.Tag = 1;
                for (int i = aux - 1; i > 0; i--)
                {
                    aux = aux * i;
                }
                nNum1 = aux;
                txtValor.Text = nNum1.ToString();
                return;
            }
            MessageBox.Show("Digite apenas números inteiros para calcular o fatorial!");
        }

        private void btn1Div_Click(object sender, EventArgs e)
        {
            cOper = ' ';
            txtValor.Tag = 1;
            nNum1 = 1 / double.Parse(txtValor.Text);
            txtValor.Text = nNum1.ToString();
        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            cOper = ' ';
            txtValor.Tag = 1;
            nNum1 = Math.Pow(double.Parse(txtValor.Text), 2);
            txtValor.Text = nNum1.ToString();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            cOper = ' ';
            txtValor.Tag = 1;
            nNum1 = Math.Sqrt(double.Parse(txtValor.Text));
            txtValor.Text = nNum1.ToString();
        }

        private void fnOperacao(object sender, EventArgs e)
        {
            if (cOper != ' ')
                fnCalcula();

            nNum1 = double.Parse(txtValor.Text);
            cOper = ((Button)sender).Text[0];
            //RETIRADO PARA MANTER O VALOR QUANDO O USUARIO SELECIONAR UMA OPERACAO
            //txtValor.Text = "";
            txtValor.Tag = 1;
        }
    }
}
