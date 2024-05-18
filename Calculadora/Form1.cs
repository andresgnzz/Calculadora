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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        string op = "";
        double num1 = 0;
        double num2 = 0;
        double m = 0;
        double res = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += button0.Text;
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += buttonPunto.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
            op = "";
        }

        private void buttonDEL_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void buttonMas_Click(object sender, EventArgs e)
        {
            if(op != "")
            {
                num2 = double.Parse(textBox1.Text);
                switch (op)
                {
                    case "+":
                        res = num1 + num2;
                        break;
                    case "-":
                        res = num1 - num2;
                        break;
                    case "*":
                        res = num1 * num2;
                        break;
                    case "/":
                        res = num1 / num2;
                        break;
                }
                textBox1.Text = res.ToString();
                Historial.AppendText(num2.ToString());
                Historial.AppendText(" = ");
                Historial.AppendText(res.ToString());
                Historial.AppendText("\r\n");
                num1 = res;
            }

            num1 = double.Parse(textBox1.Text);
            Historial.AppendText("\r\n");
            Historial.AppendText(num1.ToString());
            Historial.AppendText(" + ");
            textBox1.Text = "0";
            op = "+";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (op != "")
            {
                num2 = double.Parse(textBox1.Text);
                switch (op)
                {
                    case "+":
                        res = num1 + num2;
                        break;
                    case "-":
                        res = num1 - num2;
                        break;
                    case "*":
                        res = num1 * num2;
                        break;
                    case "/":
                        res = num1 / num2;
                        break;
                }
                textBox1.Text = res.ToString();
                Historial.AppendText(num2.ToString());
                Historial.AppendText(" = ");
                Historial.AppendText(res.ToString());
                Historial.AppendText("\r\n");
                num1 = res;
            }

            num1 = double.Parse(textBox1.Text);
            Historial.AppendText("\r\n");
            Historial.AppendText(num1.ToString());
            Historial.AppendText(" - ");
            textBox1.Text = "0";
            op = "-";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (op != "")
            {
                num2 = double.Parse(textBox1.Text);
                switch (op)
                {
                    case "+":
                        res = num1 + num2;
                        break;
                    case "-":
                        res = num1 - num2;
                        break;
                    case "*":
                        res = num1 * num2;
                        break;
                    case "/":
                        res = num1 / num2;
                        break;
                }
                textBox1.Text = res.ToString();
                Historial.AppendText(num2.ToString());
                Historial.AppendText(" = ");
                Historial.AppendText(res.ToString());
                Historial.AppendText("\r\n");
                num1 = res;
            }

            num1 = double.Parse(textBox1.Text);
            Historial.AppendText("\r\n");
            Historial.AppendText(num1.ToString());
            Historial.AppendText(" * ");
            textBox1.Text = "0";
            op = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (op != "")
            {
                num2 = double.Parse(textBox1.Text);
                switch (op)
                {
                    case "+":
                        res = num1 + num2;
                        break;
                    case "-":
                        res = num1 - num2;
                        break;
                    case "*":
                        res = num1 * num2;
                        break;
                    case "/":
                        res = num1 / num2;
                        break;
                }
                textBox1.Text = res.ToString();
                Historial.AppendText(num2.ToString());
                Historial.AppendText(" = ");
                Historial.AppendText(res.ToString());
                Historial.AppendText("\r\n");
                num1 = res;
            }

            num1 = double.Parse(textBox1.Text);
            Historial.AppendText("\r\n");
            Historial.AppendText(num1.ToString());
            Historial.AppendText(" / ");
            textBox1.Text = "0";
            op = "/";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox1.Text);
            
            switch(op)
            {
                case "+":
                    res = num1 + num2;
                    break;
                case "-":
                    res = num1 - num2;
                    break;
                case "*":
                    res = num1 * num2;
                    break;
                case "/":
                    res = num1 / num2;
                    break;
            }

            textBox1.Text = res.ToString();
            Historial.AppendText(num2.ToString());
            Historial.AppendText(" = ");
            Historial.AppendText(res.ToString());
            Historial.AppendText("\r\n");
        }

        private void Historial_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMem_Click(object sender, EventArgs e)
        {
            m = double.Parse(textBox1.Text);
            MEMORIAS.Items.Add(m);         
        }

        private void MEMORIAS_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = MEMORIAS.Text;
        }
    }
}
