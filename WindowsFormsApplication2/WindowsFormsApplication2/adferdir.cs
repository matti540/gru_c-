using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication2
{
    class adferdir
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        string tengistrengur = null;
        string fyrirspurn = null;
        MySqlConnection sqltenging;
        MySqlCommand nySQLskipun;
        MySqlDataReader sqllesari = null;

        public void TengingVidGagnagrunn()
        {
            server = "82.148.66.15";
            database = "gru_h7_lokaverkefni";
            uid = "GRU_H7";
            password = "mypassword";
            tengistrengur = "server= " + server + ";userid= " + uid + ";password= " + password + ";database= " + database;
            sqltenging = new MySqlConnection(tengistrengur);
        }

        public bool OpenConnection()
        {
            try
            {
                sqltenging.Open();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SettInnSqlToflu(string fyrirspurn)
        {
            if (OpenConnection() == true)
            {
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void Uppfaera(string fyrirspurn)
        {
            if (OpenConnection() == true)
            {
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public string FinnaEinstakling(string id)
        {
            string lina = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT id_medlimur, nafn, netfang, simanumer FROM id WHERE id_medlimur='" + id + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        lina += (sqllesari.GetValue(i).ToString()) + ":";
                    }
                }
                sqltenging.Close();
            }
            return lina;
        }

        public void Eyda(string id)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "DELETE FROM id WHERE id_medlimur = '" + id + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public List<string> LesautSQLToflu(string fyrirspurn)
        {
            List<string> Faerlsur = new List<string>();
            string lina = null;
            if (OpenConnection() == true)
            {
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        lina += (sqllesari.GetValue(i).ToString()) + ":";
                    }
                    Faerlsur.Add(lina);
                    lina = null;
                }
                CloseConnection();
            }
            return Faerlsur;
        }

        public string[] FinnaAkvedinOgSkilaTilBaka(string username, string password)
        {
            string[] gogn = new string[5];
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT * FROM members WHERE username ='" + username + "' and password = '" + password + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    gogn[0] = sqllesari.GetValue(0).ToString();
                    gogn[1] = sqllesari.GetValue(1).ToString();
                    gogn[2] = sqllesari.GetValue(2).ToString();
                    gogn[3] = sqllesari.GetValue(3).ToString();
                    gogn[4] = sqllesari.GetValue(4).ToString();
                }
                sqllesari.Close();
                CloseConnection();
                return gogn;
            }
            return gogn;
        }

        private bool CloseConnection()
        {
            try
            {
                sqltenging.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
