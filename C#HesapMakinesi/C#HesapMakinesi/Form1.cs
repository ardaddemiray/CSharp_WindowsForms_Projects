using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sayi1, sayi2;
        string islem;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (hesapBox.Text == "0")
            {
                hesapBox.Text = "1";
            }
            else
            {
                hesapBox.Text += "1";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (hesapBox.Text == "0")
            {
                hesapBox.Text = "2";
            }
            else
            {
                hesapBox.Text += "2";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (hesapBox.Text == "0")
            {
                hesapBox.Text = "3";
            }
            else
            {
                hesapBox.Text += "3";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (hesapBox.Text == "0")
            {
                hesapBox.Text = "4";
            }
            else
            {
                hesapBox.Text += "4";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (hesapBox.Text == "0")
            {
                hesapBox.Text = "5";
            }
            else
            {
                hesapBox.Text += "5";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (hesapBox.Text == "0")
            {
                hesapBox.Text = "6";
            }
            else
            {
                hesapBox.Text += "6";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (hesapBox.Text == "0")
            {
                hesapBox.Text = "7";
            }
            else
            {
                hesapBox.Text += "7";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (hesapBox.Text == "0")
            {
                hesapBox.Text = "8";
            }
            else
            {
                hesapBox.Text += "8";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (hesapBox.Text == "0")
            {
                hesapBox.Text = "9";
            }
            else
            {
                hesapBox.Text += "9";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (hesapBox.Text == "0")
            {
                hesapBox.Text = "0";
            }
            else
            {
                hesapBox.Text += "0";
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            hesapBox.Text = "0";
        }

        private void backspace_btn_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(hesapBox.Text) > 0)
            {
                hesapBox.Text = hesapBox.Text.Remove(hesapBox.Text.Length - 1,1);
            }
            if (hesapBox.Text.Length == 0)
            {
                hesapBox.Text= "0";
            }
        }

        private void artiButton_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(hesapBox.Text);
            islem = "+";
            hesapBox.Text = "0";
        }

        private void eksiButton_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(hesapBox.Text);
            islem = "-";
            hesapBox.Text = "0";
        }

        private void carpButton_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(hesapBox.Text);
            islem = "*";
            hesapBox.Text = "0";
        }

        private void bolmeButton_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(hesapBox.Text);
            islem = "/";
            hesapBox.Text = "0";
        }

        private void esittirButton_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(hesapBox.Text);
            if (islem == "+")
            {
                hesapBox.Text= Convert.ToString(sayi1+sayi2);
            }
            sayi2 = Convert.ToDouble(hesapBox.Text);
            if (islem == "-")
            {
                hesapBox.Text = Convert.ToString(sayi1 - sayi2);
            }
            sayi2 = Convert.ToDouble(hesapBox.Text);
            if (islem == "*")
            {
                hesapBox.Text = Convert.ToString(sayi1 * sayi2);
            }
            sayi2 = Convert.ToDouble(hesapBox.Text);
            if (islem == "/")
            {
                hesapBox.Text = Convert.ToString(sayi1 / sayi2);
            }
        }

        private void karekokButton_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(hesapBox.Text);

            hesapBox.Text = Convert.ToString(Math.Sqrt(sayi1));
        }

        private void kareButton_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(hesapBox.Text);

            hesapBox.Text = Convert.ToString(Math.Pow(sayi1, 2));
        }

        private void virgul_btn_Click(object sender, EventArgs e)
        {
            if (hesapBox.Text.IndexOf(",") < 1)
            {
                hesapBox.Text+= ",";
            }
        }
    }
}
