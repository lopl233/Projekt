using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public sealed class DatabaseAccess
    {
        private static readonly DatabaseAccess instance = new DatabaseAccess();
        public static DatabaseAccess Instance { get { return instance; } }


        private static String connectionStr = "server=sql7.freemysqlhosting.net	;user=sql7121947;password=mTUfwszQiq;database=sql7121947;port=3306;";
        private MySqlConnection mySqlConn;

        private DatabaseAccess() {}

        public void openConnection()
        {
            mySqlConn = new MySqlConnection(connectionStr);
            mySqlConn.Open();
        }

        public void closeConnection()
        {
            mySqlConn.Close();
        }

        public User getUserFromDatabase(String login, String password)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM uzytkownicy where LOGIN=@Login and HASLO=@Pass", mySqlConn);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Pass", password);

            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read() == false)
            {
                throw new Exception("No such user found!");
            }

            User usr = new User(rdr["IMIE"].ToString(), rdr["NAZWISKO"].ToString(), 
                                rdr["LOGIN"].ToString(), rdr["HASLO"].ToString(), 
                                rdr["ADRES"].ToString(), rdr["UPRAWNIENIA"].ToString());
            rdr.Close();
            return usr;
        }

        public void addUser(User usr)
        {
            string sql = "INSERT INTO uzytkownicy (LOGIN, HASLO, UPRAWNIENIA, IMIE, NAZWISKO ,ADRES) VALUES" +
                "(@Login, @Pass, @Uprawnienia, @Imie, @Nazwisko, @Adres);";
            MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
            cmd.Parameters.AddWithValue("@Login", usr.login);
            cmd.Parameters.AddWithValue("@Pass", usr.password);
            cmd.Parameters.AddWithValue("@Uprawnienia", usr.uprawnienia);
            cmd.Parameters.AddWithValue("@Imie", usr.imie);
            cmd.Parameters.AddWithValue("@Nazwisko", usr.nazwisko);
            cmd.Parameters.AddWithValue("@Adres", usr.adres);
            cmd.ExecuteNonQuery();
        }

        public void addProduct(Product product)
        {

        }

        public List<Product> getProductsList()
        {
            List<Product> products = new List<Product>();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM produkty", mySqlConn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                products.Add(new Product(rdr.GetInt32("ID"), 
                                         rdr["NAZWA"].ToString(), 
                                         rdr.GetDouble("CENA"),
                                         rdr.GetInt32("ILOSC")));
            }
            rdr.Close();
            return products;
        }
    }
}
