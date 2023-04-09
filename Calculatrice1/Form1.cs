using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice1
{
    public partial class Form1 : Form
    {
         double res, num;
        int calculation;
        public Form1()
        {
            InitializeComponent();
        }
        private void Operation()
        {
            switch (calculation)
            {
                
                case 1:
                    res = num + double.Parse(textBox1.Text);
                    textBox1.Text = Convert.ToString(res);
                    break;

                case 2:
                    res = num - double.Parse(textBox1.Text);
                    textBox1.Text = Convert.ToString(res);
                    break;

                case 3:
                    res = num * double.Parse(textBox1.Text);
                    textBox1.Text = Convert.ToString(res);
                    break;

                case 4:
                    res = num / double.Parse(textBox1.Text); 
                    textBox1.Text = Convert.ToString(res);
                    break;

            }

        }

            private void Disabl()
        {
            textBox1.Enabled = false;
            button1.Enabled = false;
            button10.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;



        }
        private void Marche()
        {
            textBox1.Enabled = true;
            button1.Enabled = true;
            button10.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;

        }




        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") { 
                num = double.Parse(textBox1.Text);
                calculation = 3;
                textBox1.Text = "";
                // label1.Text = num + " *";
            }
            else
            {
                label1.Text = "Entrer un nbr Svp!!";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Marche();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.TextLength;
            if (lenght > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            else
            {
                textBox1.Text = "";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num = double.Parse(textBox1.Text);
                calculation = 1;
                textBox1.Text = "";
                // label1.Text =num + " +";
            }
            else
            {
                label1.Text = "Entrer un nbr Svp!!";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Operation();
            label1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num = double.Parse(textBox1.Text);
                calculation = 2;
                textBox1.Text = "";
                //label1.Text = num + " -";
            }
            else
            {
                label1.Text = "Entrer un nbr Svp!!";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num = double.Parse(textBox1.Text);
                calculation = 4;
                textBox1.Text = "";
                // label1.Text = num + " /";
            }
            else {
                label1.Text = "Entrer un nbr Svp!!";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Disabl();
        }
    }
}
