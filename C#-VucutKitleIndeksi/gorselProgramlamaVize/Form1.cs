using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselProgramlamaVize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double boy = Convert.ToDouble(textBox1.Text) / 100;
            double kilo = Convert.ToDouble(textBox2.Text);
            double belCevresi = Convert.ToDouble(textBox3.Text);

            double vki = (kilo / (boy * boy));
            listBox1.Items.Add("Vücut kitle endeksiniz : " + vki);

            if(radioButton1.Checked==true && belCevresi >= 80 && belCevresi < 88 && vki > 25)
            {
                listBox1.Items.Add("Risk Grubu (Uyarı sınırında)");

            }
            else if (belCevresi > 88 && vki > 30)
            {
                listBox1.Items.Add("Yüksek Risk Grubu (Eylem sınırında)");
            }
            else if(radioButton2.Checked==true && belCevresi >= 94 && belCevresi <102 && vki > 25)
            {
                listBox1.Items.Add("Risk Grubu (Uyarı sınırında)");
            }
            else if (belCevresi > 102 && vki > 30)
            {
                listBox1.Items.Add("Yüksek Risk Grubu (Eylem sınırında)");
            }
            else
            {
                listBox1.Items.Add("Vücut değerleriniz gayet normal");
            }
        }
    }
}
