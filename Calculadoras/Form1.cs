using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculadoras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var p = double.Parse(textBox4.Text, CultureInfo.InvariantCulture);
                var a = double.Parse(textBox5.Text, CultureInfo.InvariantCulture);
                CalculoImc calc = new CalculoImc();
                var resultado = calc.CalcclassifiIMC(p, a);
                label7.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }
    }
}