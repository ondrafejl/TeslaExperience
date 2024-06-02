using Microsoft.Data.SqlClient;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OmegaTeslaFejl
{
    /// <summary>
    /// stranka pro reigstraci nove jizdy 
    /// </summary>
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// metoda pro vybrani ridice - vybarvi se ridic cerne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //ridic

            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;

            button2.BackColor = Color.White;
            button2.ForeColor = Color.Black;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;

            pocitani();
        }

        /// <summary>
        /// metoda pro vybrani pasazera - vybarvi se cerne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //pasazer

            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;

            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;

            pocitani();
        }

        /// <summary>
        /// metoda pro vybrani performance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //basic

            button3.BackColor = Color.Black;
            button3.ForeColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;

            button4.BackColor = Color.White;
            button4.ForeColor = Color.Black;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;

            pocitani();
        }

        /// <summary>
        /// metoda pro vybrani modelu s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            //performance

            button4.BackColor = Color.Black;
            button4.ForeColor = Color.White;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;

            button3.BackColor = Color.White;
            button3.ForeColor = Color.Black;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;

            pocitani();
        }

        /// <summary>
        /// metoda pro pocitani ceny pri konfigurovani sveho balicku jizdy
        /// </summary>
        public void pocitani()
        {
            if (button1.BackColor == Color.Black && button3.BackColor == Color.Black)
            {
                //3100
                label2.Text = "Cena: 3100Kč";
            }
            else if (button1.BackColor == Color.Black && button4.BackColor == Color.Black)
            {
                //3500
                label2.Text = "Cena: 3500Kč";
            }
            else if (button2.BackColor == Color.Black && button3.BackColor == Color.Black)
            {
                //2100
                label2.Text = "Cena: 2100Kč";
            }
            else if (button2.BackColor == Color.Black && button4.BackColor == Color.Black)
            {
                //2500
                label2.Text = "Cena: 2500Kč";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// metoda pro vraceni se na hlavni uvodni obrazovku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click_1(object sender, EventArgs e)
        {
            TeslaExperience form1 = new TeslaExperience();
            form1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// metoda pro vybrani mista vyzvednuti - spse jecna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Black;
            button7.ForeColor = Color.White;
            button7.FlatAppearance.BorderColor = Color.White;
            button7.FlatAppearance.BorderSize = 2;
            button7.FlatStyle = FlatStyle.Flat;

            button5.BackColor = Color.White;
            button5.ForeColor = Color.Black;
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatStyle = FlatStyle.Flat;

            button6.BackColor = Color.White;
            button6.ForeColor = Color.Black;
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatStyle = FlatStyle.Flat;
        }

        /// <summary>
        /// metoda pro vyzvednuti nadrazi liben
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Black;
            button6.ForeColor = Color.White;
            button6.FlatAppearance.BorderColor = Color.White;
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatStyle = FlatStyle.Flat;

            button7.BackColor = Color.White;
            button7.ForeColor = Color.Black;
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatAppearance.BorderSize = 2;
            button7.FlatStyle = FlatStyle.Flat;

            button5.BackColor = Color.White;
            button5.ForeColor = Color.Black;
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatStyle = FlatStyle.Flat;
        }

        /// <summary>
        /// metoda pro vyzvednuti u fortuny areny
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Black;
            button5.ForeColor = Color.White;
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatStyle = FlatStyle.Flat;

            button7.BackColor = Color.White;
            button7.ForeColor = Color.Black;
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatAppearance.BorderSize = 2;
            button7.FlatStyle = FlatStyle.Flat;

            button6.BackColor = Color.White;
            button6.ForeColor = Color.Black;
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatStyle = FlatStyle.Flat;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// metoda pro ulozeni a vytvoreni noveho jizdare
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            // Získání hodnot z políček
            string jmeno = textBox1.Text;
            string prijmeni = textBox2.Text;
            string adresa = textBox3.Text;
            string telefon = textBox6.Text;
            string email = textBox5.Text;
            string password = textBox4.Text;
            bool driver = button1.BackColor == Color.Black; // Pokud tlačítko "Řidič" je černé, je řidič True, jinak False
            bool performance = button4.BackColor == Color.Black; // Pokud tlačítko "Tesla model 3 Performance" je černé, je performance True, jinak False
            DateTime datum = dateTimePicker1.Value; // Datum
            string cena = label2.Text;
            string vyzvednuti;

            // Kontrola, zda jsou všechna pole vyplněna
            if (string.IsNullOrWhiteSpace(jmeno) ||
                string.IsNullOrWhiteSpace(prijmeni) ||
                string.IsNullOrWhiteSpace(adresa) ||
                string.IsNullOrWhiteSpace(telefon) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Prosím, vyplňte všechna pole.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (button5.BackColor == Color.Black)
            {
                vyzvednuti = "SPŠE Ječná";
            }
            else if (button7.BackColor == Color.Black)
            {
                vyzvednuti = "Nádraží Libeň";
            }
            else
            {
                vyzvednuti = "Fortuna Arena";
            }

            //novy uzivatel z nactenych informaci
            Jizdar newUser = new Jizdar(jmeno, prijmeni, adresa, Convert.ToInt32(telefon), email, password, driver, performance, datum, vyzvednuti, cena);

            //dao jizdar pro ulozeni
            JizdarDAO jizdarDAO = new JizdarDAO();

            try
            {
                jizdarDAO.Save(newUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured. Email likely already in use");
                return;
            }

            MessageBox.Show("Uživatel úspěšně zaregistrován!");

            //prepnuti zpet na hlavni obrazovku
            TeslaExperience form1 = new TeslaExperience();
            form1.Show();
            this.Hide();
        }
    }
}