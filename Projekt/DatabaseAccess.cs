using System;
using System.IO;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public sealed class DatabaseAccess
    {
        private static readonly DatabaseAccess instance = new DatabaseAccess();
        public static DatabaseAccess Instance { get { return instance; } }

        private static String connectionStr = "Data Source=database.db;Version=3;";
        private SQLiteConnection sqlConnection;

        private DatabaseAccess() {}

        public void OpenConnection()
        {
            // createDatabase();
            
            sqlConnection = new SQLiteConnection(connectionStr);
            try
            {
                sqlConnection.Open();
            } catch(SQLiteException exception)
            {
                createDatabase();
                sqlConnection.Open();
            
        }

        }

        public void CloseConnection()
        {
            sqlConnection.Close();
        }

        public void createDatabase()
        {
            SQLiteConnection.CreateFile("database.db");
            SQLiteConnection sqlConnection = new SQLiteConnection(connectionStr);
            sqlConnection.Open();
            new SQLiteCommand(File.ReadAllText("scheme.sql"), sqlConnection).ExecuteNonQuery();
        }

        public User GetUser(String login, String password)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM uzytkownicy where LOGIN=@Login and HASLO=@Pass", sqlConnection);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Pass", password);

            SQLiteDataReader rdr = cmd.ExecuteReader();
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
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM uzytkownicy where ID=@ID", sqlConnection);
            cmd.Parameters.AddWithValue("@ID", userId);

            SQLiteDataReader rdr = cmd.ExecuteReader();
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
            SQLiteCommand cmd = new SQLiteCommand(sql, sqlConnection);
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
            SQLiteCommand cmd = new SQLiteCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@Nazwa", product.nazwa);
            cmd.Parameters.AddWithValue("@Cena", product.cena);
            cmd.Parameters.AddWithValue("@Ilosc", product.ilosc);
            cmd.ExecuteNonQuery();
        }

        public void UpdateProduct(Product product)
        {
            string sql = "UPDATE produkty SET NAZWA=@Nazwa, CENA=@Cena, ILOSC=@Ilosc WHERE ID=@ID";
            SQLiteCommand cmd = new SQLiteCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@ID", product.id);
            cmd.Parameters.AddWithValue("@Nazwa", product.nazwa);
            cmd.Parameters.AddWithValue("@Cena", product.cena);
            cmd.Parameters.AddWithValue("@Ilosc", product.ilosc);
            cmd.ExecuteNonQuery();
        }

        public void RemoveProduct(int id)
        {
            string sql = "DELETE FROM produkty WHERE ID=@ID";
            SQLiteCommand cmd = new SQLiteCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
        }

        public List<Product> GetProductsList()
        {
            List<Product> products = new List<Product>();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM produkty", sqlConnection);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                products.Add(new Product(rdr.GetInt32(rdr.GetOrdinal("ID")), 
                                         rdr["NAZWA"].ToString(), 
                                         rdr.GetDouble(rdr.GetOrdinal("CENA")),
                                         rdr.GetInt32(rdr.GetOrdinal("ILOSC"))));
            }
            rdr.Close();
            return products;
        }

        public List<Order> GetOrdersList()
        {
            List<Order> orders = new List<Order>();

            string sql = "SELECT zamowienia.*, uzytkownicy.IMIE FROM zamowienia " +
                "JOIN uzytkownicy ON zamowienia.ID_UZYTKOWNIKA=uzytkownicy.ID;";

            SQLiteCommand cmd = new SQLiteCommand(sql, sqlConnection);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                orders.Add(new Order(rdr.GetInt32(rdr.GetOrdinal("NR_ZAMOWIENIA")),
                                     rdr.GetInt32(rdr.GetOrdinal("ID_UZYTKOWNIKA")),
                                     rdr["STATUS"].ToString(),
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
            SQLiteCommand cmd = new SQLiteCommand(sql, sqlConnection);

   
 
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                orders.Add(new Order(rdr.GetInt32(rdr.GetOrdinal("NR_ZAMOWIENIA")),
                                     rdr.GetInt32(rdr.GetOrdinal("ID_UZYTKOWNIKA")),
                                     rdr["STATUS"].ToString(),
                                     rdr["IMIE"].ToString()));
            }
            rdr.Close();
            return orders;
        }

        public void RemoveOrder(int id)
        {
            string sql = "DELETE FROM zamowienia WHERE ID=@ID";
            SQLiteCommand cmd = new SQLiteCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
        }

        public void UpdateOrderStatus(int id, string status)
        {
            string sql = "UPDATE zamowienia SET STATUS=@Status WHERE NR_ZAMOWIENIA=@ID";
            SQLiteCommand cmd = new SQLiteCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.ExecuteNonQuery();
        }

        public OrderDetails GetOrderDetails(int orderId)
        {
            List<Product> productsList = new List<Product>();

            string sql = "SELECT zamowienia_detale.ILOSC, produkty.NAZWA, produkty.CENA, produkty.ID FROM zamowienia_detale " +
                "JOIN produkty ON zamowienia_detale.ID_PRODUKTU=produkty.ID WHERE zamowienia_detale.NR_ZAMOWIENIA=@ID;";

            SQLiteCommand cmd = new SQLiteCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@ID", orderId);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                productsList.Add(new Product(rdr.GetInt32(rdr.GetOrdinal("ID")),
                                     rdr["NAZWA"].ToString(),
                                     rdr.GetDouble(rdr.GetOrdinal("CENA")),
                                     rdr.GetInt32(rdr.GetOrdinal("ILOSC"))));
            }
            rdr.Close();
            return new OrderDetails(orderId, productsList);
        }
    }
}
