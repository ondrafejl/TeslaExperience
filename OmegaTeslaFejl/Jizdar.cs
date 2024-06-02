using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaTeslaFejl
{
    public class Jizdar : IBaseClass
    {
        /// <summary>
        /// vlastnosti jízdaře
        /// </summary>
        private int id;
        private string jmeno;
        private string prijmeni;
        private string adresa;
        private int telefon;
        private string email;
        private string password;
        private bool driver;
        private bool performance;
        private DateTime datum;
        private string vyzvednuti;
        private string cena;

        /// <summary>
        /// konstruktor pro vytvoreni jizdare
        /// </summary>
        /// <param name="jmeno">jmeno jizdare</param>
        /// <param name="prijmeni">prijmeni jizdare</param>
        /// <param name="adresa">adresa jizdare</param>
        /// <param name="telefon">telefon jizdare</param>
        /// <param name="email">email jizdare</param>
        /// <param name="password">heslo pro nasledne zobrazeni sve jizdy</param>
        /// <param name="driver">ridic true pasazer false</param>
        /// <param name="performance">performance true basic flase </param>
        /// <param name="datum">datum uskutecneni jizdy</param>
        /// <param name="vyzvednuti">misto vyzvednuti</param>
        /// <param name="cena">cena jizdy</param>
        public Jizdar(string jmeno, string prijmeni, string adresa, int telefon, string email, string password, bool driver, bool performance, DateTime datum, string vyzvednuti, string cena)
        { 
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.adresa = adresa;
            this.telefon = telefon;
            this.email = email;
            this.password = password;
            this.driver = driver;
            this.performance = performance;
            this.datum = datum;
            this.vyzvednuti = vyzvednuti;
            this.cena = cena;
        }

        /// <summary>
        /// gettery a settery
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }

        public string Prijmeni
        {
            get { return prijmeni; }
            set { prijmeni = value; }
        }

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }

        public int Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool Driver
        {
            get { return driver; }
            set { driver = value; }
        }

        public bool Performance
        {
            get { return performance; }
            set { performance = value; }
        }

        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        public string Vyzvednuti
        {
            get { return vyzvednuti; }
            set { vyzvednuti = value; }
        }

        public string Cena
        {
            get { return cena; }
            set { cena = value; }
        }
    }
}
