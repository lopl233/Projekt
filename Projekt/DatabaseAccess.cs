using MySql.Data.MySqlClient;
using MySql.Data.Types;
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

        private static String connectionStr = "server=sql7.freemysqlhosting.net; database=sql7123531;user=sql7123531;password=URnwzMnstl";
        private MySqlConnection mySqlConn;

        private DatabaseAccess() {}

        public void OpenConnection()
        {
            mySqlConn = new MySqlConnection(connectionStr);
          
                mySqlConn.Open();
            
        }

        public void CloseConnection()
        {
            mySqlConn.Close();
        }

        public User GetUser(String login, String password)
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

        public User GetUser(int userId)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM uzytkownicy where ID=@ID", mySqlConn);
            cmd.Parameters.AddWithValue("@ID", userId);

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

        public void AddUser(User usr)
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

        public void AddProduct(Product product)
        {
            string sql = "INSERT INTO produkty (NAZWA, CENA, ILOSC) VALUES (@Nazwa, @Cena, @Ilosc);";
            MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
            cmd.Parameters.AddWithValue("@Nazwa", product.nazwa);
            cmd.Parameters.AddWithValue("@Cena", product.cena);
            cmd.Parameters.AddWithValue("@Ilosc", product.ilosc);
            cmd.ExecuteNonQuery();
        }

        public void UpdateProduct(Product product)
        {
            string sql = "UPDATE produkty SET NAZWA=@Nazwa, CENA=@Cena, ILOSC=@Ilosc WHERE ID=@ID";
            MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
            cmd.Parameters.AddWithValue("@ID", product.id);
            cmd.Parameters.AddWithValue("@Nazwa", product.nazwa);
            cmd.Parameters.AddWithValue("@Cena", product.cena);
            cmd.Parameters.AddWithValue("@Ilosc", product.ilosc);
            cmd.ExecuteNonQuery();
        }

        public void RemoveProduct(int id)
        {
            string sql = "DELETE FROM produkty WHERE ID=@ID";
            MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
        }

        public List<Product> GetProductsList()
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

        public List<Order> GetOrdersList()
        {
            List<Order> orders = new List<Order>();

            string sql = "SELECT zamowienia.*, uzytkownicy.IMIE FROM zamowienia " +
                "JOIN uzytkownicy ON zamowienia.ID_UZYTKOWNIKA=uzytkownicy.ID;";

            MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                orders.Add(new Order(rdr.GetInt32("NR_ZAMOWIENIA"),
                                     rdr.GetInt32("ID_UZYTKOWNIKA"),
                                     rdr["STATUS"].ToString(),
                                     rdr.GetMySqlDateTime("DATA"),
                                     rdr["IMIE"].ToString()));
            }
            rdr.Close();
            return orders;
        }

        public List<Order> GetOrdersList(User usr)
        {
            List<Order> orders = new List<Order>();

            string sql = "SELECT zamowienia.NR_ZAMOWIENIA,zamowienia.STATUS,zamowienia.ID_UZYTKOWNIKA,uzytkownicy.IMIE,zamowienia.DATA FROM zamowienia " +
               "JOIN uzytkownicy ON zamowienia.ID_UZYTKOWNIKA=uzytkownicy.ID WHERE LOGIN='"+usr.login+"' AND HASLO='"+usr.password+"'";
            MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);

   
 
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                orders.Add(new Order(rdr.GetInt32("NR_ZAMOWIENIA"),
                                     rdr.GetInt32("ID_UZYTKOWNIKA"),
                                     rdr["STATUS"].ToString(),
                                     rdr.GetMySqlDateTime("DATA"),
                                     rdr["IMIE"].ToString()));
            }
            rdr.Close();
            return orders;
        }

        public void RemoveOrder(int id)
        {
            string sql = "DELETE FROM zamowienia WHERE ID=@ID";
            MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
        }

        public void UpdateOrderStatus(int id, string status)
        {
            string sql = "UPDATE zamowienia SET STATUS=@Status WHERE NR_ZAMOWIENIA=@ID";
            MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.ExecuteNonQuery();
        }

        public OrderDetails GetOrderDetails(int orderId)
        {
            List<Product> productsList = new List<Product>();

            string sql = "SELECT zamowienia_detale.ILOSC, produkty.NAZWA, produkty.CENA, produkty.ID FROM zamowienia_detale " +
                "JOIN produkty ON zamowienia_detale.ID_PRODUKTU=produkty.ID WHERE zamowienia_detale.NR_ZAMOWIENIA=@ID;";

            MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
            cmd.Parameters.AddWithValue("@ID", orderId);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                productsList.Add(new Product(rdr.GetInt32("ID"),
                                     rdr["NAZWA"].ToString(),
                                     rdr.GetDouble("CENA"),
                                     rdr.GetInt32("ILOSC")));
            }
            rdr.Close();
            return new OrderDetails(orderId, productsList);
        }
    }
}
