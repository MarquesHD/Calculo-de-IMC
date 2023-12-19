using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                float peso = Convert.ToSingle(textBox1.Text);
                float altura = Convert.ToSingle(textBox2.Text);

                float calculo = peso / (altura*altura);
                calculo = calculo * 10000; // para cortar os zeros inicias por exemplo: 0.00270321 para 27.0321
                textBox3.Text = calculo.ToString();
            }
            else
            {
                textBox3.Text = "Informações não validas.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_MouseMove(object sender, MouseEventArgs e)
        {
            label10.Text = "Deve estar em cm.";
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.Text = "?";
        }
    }
}
