using Microsoft.Data.SqlClient;
using System;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaTeslaFejl
{
    public class JizdarDAO : IDAO<Jizdar>
    {
        /// <summary>
        /// metoda pro smazani jizdare z databaze
        /// </summary>
        /// <param name="jizdar"></param>
        public void Delete(Jizdar jizdar)
        {
            SqlConnection conn = DatabaseSingleton.GetInstance();

            using (SqlCommand command = new SqlCommand("DELETE FROM jizdar WHERE id = @id", conn))
            {
                command.Parameters.Add(new SqlParameter("@id", jizdar.Id));
                command.ExecuteNonQuery();
                jizdar.Id = 0;
            }
        }

        /// <summary>
        /// metoda pro ziskani informaci o jizdarich
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Jizdar> GetAll()
        {
            SqlConnection conn = DatabaseSingleton.GetInstance();

            using (SqlCommand command = new SqlCommand("SELECT * FROM jizdar", conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Jizdar jizdar = new Jizdar(
                            reader["jmeno"].ToString(),
                            reader["prijmeni"].ToString(),
                            reader["adresa"].ToString(),
                            Convert.ToInt32(reader["telefon"]),
                            reader["email"].ToString(),
                            reader["password"].ToString(),
                            Convert.ToBoolean(reader["driver"]),
                            Convert.ToBoolean(reader["performance"]),
                            Convert.ToDateTime(reader["datum"]),
                            reader["vyzvednuti"].ToString(),
                            reader["cena"].ToString()
                        );
                        yield return jizdar;
                    }
                }
            }
        }

        /// <summary>
        /// metoda pro ziskani informaci o jizdarich
        /// </summary>
        /// <returns></returns>
        public Jizdar? GetByID(int id)
        {
            Jizdar? jizdar = null;
            SqlConnection connection = DatabaseSingleton.GetInstance();

            using (SqlCommand command = new SqlCommand("SELECT * FROM jizdar WHERE id = @id", connection))
            {
                command.Parameters.Add(new SqlParameter("@id", id));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        jizdar = new Jizdar(
                            reader["jmeno"].ToString(),
                            reader["prijmeni"].ToString(),
                            reader["adresa"].ToString(),
                            Convert.ToInt32(reader["telefon"]),
                            reader["email"].ToString(),
                            reader["password"].ToString(),
                            Convert.ToBoolean(reader["driver"]),
                            Convert.ToBoolean(reader["performance"]),
                            Convert.ToDateTime(reader["datum"]),
                            reader["vyzvednuti"].ToString(),
                            reader["cena"].ToString()
                        );
                    }
                }
            }
            return jizdar;
        }

        /// <summary>
        /// metoda pro ulozeni noveho jizdare do databaze
        /// </summary>
        /// <param name="jizdar"></param>
        public void Save(Jizdar jizdar)
        {
            SqlConnection conn = DatabaseSingleton.GetInstance();
            SqlCommand command = null;

            if (jizdar.Id < 1)
            {
                using (command = new SqlCommand("INSERT INTO jizdar (jmeno, prijmeni, adresa, telefon, email, password, driver, performance, datum, vyzvednuti, cena) " +
                    "VALUES (@jmeno, @prijmeni, @adresa, @telefon, @Email, @password, @driver, @performance, @datum, @vyzvednuti, @cena)", conn))
                {
                    command.Parameters.Add(new SqlParameter("@jmeno", jizdar.Jmeno));
                    command.Parameters.Add(new SqlParameter("@prijmeni", jizdar.Prijmeni));
                    command.Parameters.Add(new SqlParameter("@adresa", jizdar.Adresa));
                    command.Parameters.Add(new SqlParameter("@telefon", jizdar.Telefon));
                    command.Parameters.Add(new SqlParameter("@Email", jizdar.Email));
                    command.Parameters.Add(new SqlParameter("@password", jizdar.Password));
                    command.Parameters.Add(new SqlParameter("@driver", jizdar.Driver));
                    command.Parameters.Add(new SqlParameter("@performance", jizdar.Performance));
                    command.Parameters.Add(new SqlParameter("@datum", jizdar.Datum));
                    command.Parameters.Add(new SqlParameter("@vyzvednuti", jizdar.Vyzvednuti));
                    command.Parameters.Add(new SqlParameter("@cena", jizdar.Cena));
                    command.ExecuteNonQuery();

                    command.CommandText = "SELECT @@IDENTITY";
                    jizdar.Id = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            else
            {
                using (command = new SqlCommand("UPDATE jizdar SET jmeno = @jmeno, prijmeni = @prijmeni, adresa = @adresa, telefon = @telefon, email = @Email, password = @password, driver = @driver, performance = @performance, datum = @datum, vyzvednuti = @vyzvednuti, cena = @cena WHERE id = @id", conn))
                {
                    command.Parameters.Add(new SqlParameter("@id", jizdar.Id));
                    command.Parameters.Add(new SqlParameter("@jmeno", jizdar.Jmeno));
                    command.Parameters.Add(new SqlParameter("@prijmeni", jizdar.Prijmeni));
                    command.Parameters.Add(new SqlParameter("@adresa", jizdar.Adresa));
                    command.Parameters.Add(new SqlParameter("@telefon", jizdar.Telefon));
                    command.Parameters.Add(new SqlParameter("@Email", jizdar.Email));
                    command.Parameters.Add(new SqlParameter("@password", jizdar.Password));
                    command.Parameters.Add(new SqlParameter("@driver", jizdar.Driver));
                    command.Parameters.Add(new SqlParameter("@performance", jizdar.Performance));
                    command.Parameters.Add(new SqlParameter("@datum", jizdar.Datum));
                    command.Parameters.Add(new SqlParameter("@vyzvednuti", jizdar.Vyzvednuti));
                    command.Parameters.Add(new SqlParameter("@cena", jizdar.Cena));
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// metoda pro odstraneni vsech jizdaru
        /// </summary>
        public void RemoveAll()
        {
            SqlConnection conn = DatabaseSingleton.GetInstance();

            using (SqlCommand command = new SqlCommand("DELETE FROM jizdar", conn))
            {
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// metoda pro ziskani informaci o jizdari podle emailu a hesla 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Jizdar? GetByEmailAndPassword(string email, string password)
        {
            Jizdar? jizdar = null;
            SqlConnection connection = DatabaseSingleton.GetInstance();

            using (SqlCommand command = new SqlCommand("SELECT * FROM jizdar WHERE email = @Email AND password = @Password COLLATE Latin1_General_CS_AS", connection))
            {
                command.Parameters.Add(new SqlParameter("@Email", email));
                command.Parameters.Add(new SqlParameter("@Password", password));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        jizdar = new Jizdar(
                            reader["jmeno"].ToString(),
                            reader["prijmeni"].ToString(),
                            reader["adresa"].ToString(),
                            Convert.ToInt32(reader["telefon"]),
                            reader["email"].ToString(),
                            reader["password"].ToString(),
                            Convert.ToBoolean(reader["driver"]),
                            Convert.ToBoolean(reader["performance"]),
                            Convert.ToDateTime(reader["datum"]),
                            reader["vyzvednuti"].ToString(),
                            reader["cena"].ToString()
                        );
                    }
                }
            }
            return jizdar;
        }
    }
}
