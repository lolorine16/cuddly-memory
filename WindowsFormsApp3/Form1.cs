using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string identifiant = textBox1.Text;
            string motdepasse = textBox2.Text;

            if (identifiant == "lolorine16" && motdepasse == "motdepasse") 
            {
                MessageBox.Show("Vous vous etes connecter avec succes !");
                label3.Text = "Bienvenue lolorine 16 !";
            } else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect");
            }
        }
    }
}
