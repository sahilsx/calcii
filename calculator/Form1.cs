using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Double resultvalue = 0;
        string operationperformed = "";
        bool isoperationpf = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") ||(isoperationpf))
                textBox1.Clear();

            if (textBox1.Text == "00")
                textBox1.Clear();
            isoperationpf = false;

            Button button = (Button)sender;
            if(button.Text==".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;

            }
            else
            textBox1.Text = textBox1.Text + button.Text;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
           

           
                operationperformed = button.Text;
                resultvalue = Double.Parse(textBox1.Text);

                isoperationpf = true;
           
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            textBox1.Text= textBox1.Text.Remove(textBox1.Text.Length-1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)

        {
            
            switch (operationperformed)
            {
                case "+":
                   
                    textBox1.Text = (resultvalue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":

                    textBox1.Text = (resultvalue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":

                    textBox1.Text = (resultvalue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":

                    textBox1.Text = (resultvalue / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }






        }
    }
}

