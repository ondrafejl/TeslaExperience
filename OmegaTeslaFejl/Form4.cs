using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmegaTeslaFejl
{
    public partial class Form4 : Form
    {

        private Jizdar prihlaseny;

        public Form4(Jizdar prihlasen)
        {
            InitializeComponent();
            this.prihlaseny = prihlasen;

            textBox10.Text = prihlaseny.Datum.ToString("dd.MM.yyyy");
            textBox9.Text = prihlaseny.Driver ? "Řidič" : "Spolujezdec";
            textBox8.Text = prihlaseny.Performance ? "Performance" : "Basic";
            textBox7.Text = prihlaseny.Vyzvednuti;
            textBox6.Text = prihlaseny.Cena.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //back
            TeslaExperience form1 = new TeslaExperience();
            form1.Show();
            this.Hide();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

