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
        static MySqlCommand sqlCmd = DatabaseConnection.sqlCmd;
        static MySqlParameter nazivParam = new MySqlParameter("@naziv", MySqlDBType.String, 0);
        static MySqlParameter karakteristikaParam = new MySqlParameter("@karakteristika", MySqlDBType.String, 0);

        static DatabaseUpiti()
        {
            sqlCmd.Connection = DatabaseConnection.sqlConn;
            sqlCmd.Parameters.Add(nazivParam);
            sqlCmd.Parameters.Add(karakteristikaParam);
        }

        public static void StvoriPlanIzBaze()
        {
            StvoriČvoroveIzBaze();
            StvoriBridoveIzBaze();
        }

        public static void StvoriČvoroveIzBaze()
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

        public static void StvoriBridoveIzBaze()
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
                MessageBox.Show("Greška pri čitanju iz baze! " + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string OpisČvora(string ime)
        {
            string opis;

            try
            {
                DatabaseConnection.CheckSqlConnection();

                sqlCmd.CommandText = "SELECT Opis FROM Cvorovi WHERE Naziv = @naziv";
                
                nazivParam.Value = ime;

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
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri čitanju iz baze! " + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                opis = "Greška";
            }

            return opis;
        }

        public static string OpisBrida(string ime)
        {
            string opis;

            try
            {
                DatabaseConnection.CheckSqlConnection();

                MySqlCommand sqlCmd = DatabaseConnection.sqlCmd;
                sqlCmd.Connection = DatabaseConnection.sqlConn;
                sqlCmd.CommandText = "SELECT Opis FROM Bridovi WHERE Naziv = @naziv";
                
                nazivParam.Value = ime;

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
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri čitanju iz baze! " + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                opis = "Greška";
            }

            return opis;
        }

        public static Tuple<HashSet<Čvor>, HashSet<Brid> > ČvoroviIBridoviSaSvojstvom(string karakteristika)
        {
            Tuple<HashSet<Čvor>, HashSet<Brid>> rješenje =
                new Tuple<HashSet<Čvor>, HashSet<Brid>>(new HashSet<Čvor>(), new HashSet<Brid>());

            try
            {
                DatabaseConnection.CheckSqlConnection();

                MySqlCommand sqlCmd = DatabaseConnection.sqlCmd;
                sqlCmd.Connection = DatabaseConnection.sqlConn;
                sqlCmd.CommandText = "SELECT Cvorovi.Naziv " +
                    "FROM Cvorovi LEFT OUTER JOIN Karakteristike ON Cvorovi.ID = Karakteristike.ID_necega " +
                    "WHERE Karakteristike.Naziv = @karakteristika AND Karakteristike.Type = 'Cvor'";
                
                karakteristikaParam.Value = karakteristika;

                sqlCmd.Prepare();
                MySqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                    rješenje.Item1.Add(Plan.skupČvorova[(string)sqlReader["Naziv"]]);

                sqlReader.Close();

                sqlCmd.CommandText = "SELECT Bridovi.Naziv " +
                    "FROM Bridovi LEFT OUTER JOIN Karakteristike ON Bridovi.ID = Karakteristike.ID_necega " +
                    "WHERE Karakteristike.Naziv = @karakteristika AND Karakteristike.Type = 'Brid'";

                sqlCmd.Prepare();
                sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                    rješenje.Item2.Add(Plan.skupBridova[(string)sqlReader["Naziv"]]);

                sqlReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri čitanju iz baze! " + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                rješenje = null;
            }

            return rješenje;
        }
    }
}
