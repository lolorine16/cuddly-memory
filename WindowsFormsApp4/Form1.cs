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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string operateur;
            if (radioButton1.Checked)
            {
                operateur = "plus";
            }
            else if (radioButton2.Checked)
            {
                operateur = "fois";
            }
            else if (radioButton3.Checked)
            {
                operateur = "moin";
            } else
            {
                operateur = "nul";
            }

            int nb1 = int.Parse(textBox1.Text);
            int nb2 = int.Parse(textBox2.Text);

            if (operateur == "plus")
            {
                label6.Text = "+";
                int op = nb1 + nb2;
                textBox3.Text = Convert.ToString(op);
            } else if (operateur == "moin")
            {
                label6.Text = "-";
                int op = nb1 - nb2;
                textBox3.Text = Convert.ToString(op);
            } else if (operateur == "fois")
            {
                label6.Text = "/";
                int op = nb1 / nb2;
                textBox3.Text += Convert.ToString(op);
            } else
            {
                label6.Text = " ";
            }
        }
    }
}
