using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmegaTeslaFejl
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// metoda pro vraceni se zpet na hlavni obrazovku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            TeslaExperience form1 = new TeslaExperience();
            form1.Show();
            this.Hide();
        }

        /// <summary>
        /// metoda pro prihlaseni a zobrazeni informaci o dane jjizde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox5.Text;
            string password = textBox4.Text;

            // Kontrola, zda jsou textová pole prázdná
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Prosím, vyplňte všechna pole.");
                return;
            }

            //vymazani vstupnich policek
            textBox5.Clear();
            textBox4.Clear();

            JizdarDAO jizdarDAO = new JizdarDAO();

            try
            {
                Jizdar? jizdar = jizdarDAO.GetByEmailAndPassword(email, password);

                if (jizdar != null)
                {
                    Form4 form4 = new Form4(jizdar);
                    form4.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Žádná registrace nenalezena.");
                }

            } catch (Exception ex)
            {
                MessageBox.Show("spatne logovaci udaje");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
