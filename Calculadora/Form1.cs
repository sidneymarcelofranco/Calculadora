using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";
        string resultado = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtBoxMain.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtBoxMain.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtBoxMain.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtBoxMain.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtBoxMain.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtBoxMain.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtBoxMain.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBoxMain.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBoxMain.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBoxMain.Text += "9";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtBoxMain.Text = "";
            lblOperacao.Text = "";
            resultado = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBoxMain.Text))
            {
                valor1 = decimal.Parse(txtBoxMain.Text, CultureInfo.InvariantCulture);
                operacao = "SOMA";
                lblOperacao.Text = txtBoxMain.Text + "+";
                txtBoxMain.Text = "";
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //if (!String.IsNullOrEmpty(valor1.ToString()) || !String.IsNullOrEmpty(valor2.ToString()))
            if (valor1!=0 && valor1 != 0)
            {
                valor2 = decimal.Parse(txtBoxMain.Text, CultureInfo.InvariantCulture);
                lblOperacao.Text += txtBoxMain.Text;
                if (operacao == "SOMA")
                {
                    txtBoxMain.Text = (valor1 + valor2).ToString();
                    valor1 = 0;
                    valor2 = 0;
                }
                else if (operacao == "SUBT")
                {
                    txtBoxMain.Text = (valor1 - valor2).ToString();
                    valor1 = 0;
                    valor2 = 0;

                }
                else if (operacao == "MULT")
                {
                    txtBoxMain.Text = (valor1 * valor2).ToString();
                    valor1 = 0;
                    valor2 = 0;

                }
                else if (operacao == "DIV")
                {
                    txtBoxMain.Text = (valor1 / valor2).ToString();
                    valor1 = 0;
                    valor2 = 0;

                }


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtBoxMain.Text, CultureInfo.InvariantCulture);
            operacao = "SUBT";
            lblOperacao.Text = txtBoxMain.Text + "-";
            txtBoxMain.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtBoxMain.Text, CultureInfo.InvariantCulture);
            operacao = "MULT";
            lblOperacao.Text = txtBoxMain.Text + "x";
            txtBoxMain.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtBoxMain.Text, CultureInfo.InvariantCulture);
            operacao = "DIV";
            lblOperacao.Text = txtBoxMain.Text + "/";
            txtBoxMain.Text = "";
        }
    }
}