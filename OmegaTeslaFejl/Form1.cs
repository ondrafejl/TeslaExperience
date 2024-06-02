namespace OmegaTeslaFejl
{
    /// <summary>
    /// uvodni obrazovka cele registracni aplikace
    /// </summary>
    public partial class TeslaExperience : Form
    {
        public TeslaExperience()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// tlacitko pro presmerovani na registraci jizdy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        /// <summary>
        /// tlacitko pro presmerovani na prihlaseni kvuli zjisteni informaci o dane jizde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}