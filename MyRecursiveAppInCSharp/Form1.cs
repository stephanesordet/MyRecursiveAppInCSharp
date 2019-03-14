using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRecursiveAppInCSharp
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

       

        private void btn_send_Click(object sender, EventArgs e)
        {
            int resultat = 0;
            lblResult.Text = "Resultat";

            if (int.TryParse(txtInput.Text, out resultat))
            {
                if (resultat >= 1)
                {
                    lblResult.Text += " : " + Factoriel(resultat).ToString();
                }
                else
                {
                    MessageBox.Show("Veuillez entrer une valeur supérieure ou égale à 1 !");
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre !");
            }
        }

        private int Factoriel(int nb_init)
        {
            if (nb_init == 1)
            {
                return nb_init;
            }
            else
            {
                return nb_init * Factoriel(nb_init - 1);
            }
        }
    }
}
