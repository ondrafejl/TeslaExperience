using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaTeslaFejl
{
    public class DatabaseSingleton
    {
        private static SqlConnection conn = null;

        private DatabaseSingleton()
        {
        }

        /// <summary>
        /// metoda pro pripojeni k databazi
        /// </summary>
        /// <returns>vrrati pripojeni</returns>
        public static SqlConnection GetInstance()
        {
                if (conn == null)
                {
                    SqlConnectionStringBuilder consStringBuilder = new SqlConnectionStringBuilder();
                    consStringBuilder.UserID = ReadSetting("Name");
                    consStringBuilder.Password = ReadSetting("Password");
                    consStringBuilder.InitialCatalog = ReadSetting("Database");
                    consStringBuilder.DataSource = ReadSetting("DataSource");
                    consStringBuilder.ConnectTimeout = 30;
                    conn = new SqlConnection(consStringBuilder.ConnectionString);
                    conn.Open();
                }
                return conn;
        }

        /// <summary>
        /// metoda pro uzavreni pripojeni k databazi
        /// </summary>
        public static void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
            }
        }

        /// <summary>
        /// metoda co cte prihlaseni k databazi z konfiguracniho souboru
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private static string ReadSetting(string key)
        {
            var appSettings = ConfigurationManager.AppSettings;
            string result = appSettings[key] ?? "Not Found";
            return result;
        }
    }
}
