using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using MySqlDataReader = MySql.Data.MySqlClient.MySqlDataReader;
using MySqlParameter = MySql.Data.MySqlClient.MySqlParameter;
using MySqlDBType = MySql.Data.MySqlClient.MySqlDbType;
using System.Windows.Forms;

namespace GPSaplikacija
{
    static class DatabaseUpiti
    {
        public static void StvoriPlanIzBaze()
        {
            StvoriČvoroveIzBaze();
            StvoriBridoveIzBaze();
        }

        static void StvoriČvoroveIzBaze()
        {
            try
            {
                DatabaseConnection.CheckSqlConnection();

                MySqlCommand sqlCmd = DatabaseConnection.sqlCmd;
                sqlCmd.Connection = DatabaseConnection.sqlConn;
                sqlCmd.CommandText = "SELECT Naziv, X, Y FROM Cvorovi";

                MySqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    string naziv = sqlReader["Naziv"].ToString();
                    double x = (double)sqlReader["X"],
                           y = (double)sqlReader["Y"];
                    Plan.DodajČvor(x, y, naziv);
                }

                sqlReader.Close();
            }
            catch
            {
                MessageBox.Show("Greška pri čitanju iz baze!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static void StvoriBridoveIzBaze()
        {
            try
            {
                DatabaseConnection.CheckSqlConnection();

                MySqlCommand sqlCmd = DatabaseConnection.sqlCmd;
                sqlCmd.Connection = DatabaseConnection.sqlConn;
                sqlCmd.CommandText = "SELECT Pocetni.Naziv AS PocetniCvor, " +
                    "Zavrsni.Naziv AS ZavrsniCvor, " +
                    "Bridovi.Naziv AS NazivBrida, " +
                    "Bridovi.Vrijeme " +
                    "FROM Bridovi " +
                    "LEFT OUTER JOIN Cvorovi AS Pocetni ON Bridovi.Cvor1 = Pocetni.ID " +
                    "LEFT OUTER JOIN Cvorovi AS Zavrsni ON Bridovi.Cvor2 = Zavrsni.ID";

                MySqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    string početni = sqlReader["PocetniCvor"].ToString(),
                           završni = sqlReader["ZavrsniCvor"].ToString(),
                           naziv = sqlReader["NazivBrida"].ToString();
                    double vrijeme = (double)sqlReader["Vrijeme"];
                    Plan.DodajBrid(naziv, početni, završni, vrijeme); // možda provjeriti rezultat izvršavanja?
                }

                sqlReader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Greška pri čitanju iz baze!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static string OpisČvora(string ime)
        {
            string opis;

            try
            {
                DatabaseConnection.CheckSqlConnection();

                MySqlCommand sqlCmd = DatabaseConnection.sqlCmd;
                sqlCmd.Connection = DatabaseConnection.sqlConn;
                sqlCmd.CommandText = "SELECT Opis FROM Cvorovi WHERE Naziv = @naziv";

                MySqlParameter nazivParam = new MySqlParameter("@id", MySqlDBType.String, 0);
                nazivParam.Value = ime;
                sqlCmd.Parameters.Add(nazivParam);

                sqlCmd.Prepare();
                MySqlDataReader sqlReader = sqlCmd.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    sqlReader.Read();
                    opis = (string)sqlReader["Opis"];
                }
                else
                {
                    opis = "Nema opisa";
                }

                sqlReader.Close();
            }
            catch
            {
                MessageBox.Show("Greška pri čitanju iz baze!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                opis = "Greška";
            }

            return opis;
        }

        static string OpisBrida(string ime)
        {
            string opis;

            try
            {
                DatabaseConnection.CheckSqlConnection();

                MySqlCommand sqlCmd = DatabaseConnection.sqlCmd;
                sqlCmd.Connection = DatabaseConnection.sqlConn;
                sqlCmd.CommandText = "SELECT Opis FROM Bridovi WHERE Naziv = @naziv";

                MySqlParameter nazivParam = new MySqlParameter("@id", MySqlDBType.String, 0);
                nazivParam.Value = ime;
                sqlCmd.Parameters.Add(nazivParam);

                sqlCmd.Prepare();
                MySqlDataReader sqlReader = sqlCmd.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    sqlReader.Read();
                    opis = (string)sqlReader["Opis"];
                }
                else
                {
                    opis = "Nema opisa";
                }

                sqlReader.Close();
            }
            catch
            {
                MessageBox.Show("Greška pri čitanju iz baze!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                opis = "Greška";
            }

            return opis;
        }
    }
}
