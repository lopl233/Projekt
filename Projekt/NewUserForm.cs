using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projekt
{
    public partial class NewUserForm : Form
    {
        string connstr;

        private NewUserForm()
        {
            InitializeComponent();
        }

        public NewUserForm(string connstr)
        {
            this.connstr = connstr;
            InitializeComponent();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connstr);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Nie można połączyć się z serwerem");
            }

            if (nameTextBox.Text == "" || 
                surenameTextBox.Text == "" || 
                adressTextBox.Text == "" || 
                loginTextBox.Text == "" || 
                passwordTextBox.Text == "")
            {
                MessageBox.Show("Uzupełnij wszystkie pola");
                conn.Close();
                return;
            }

            string sql = "INSERT INTO klienci (ID_KLIENTA,IMIE ,NAZWISKO ,ADRES)VALUES((SELECT MAX(ID_UZYTKOWNIKA) FROM logowania),'"
                + nameTextBox.Text + "','"
                + surenameTextBox.Text + "','"
                + adressTextBox.Text + "')";
            string sql2 = "INSERT INTO logowania (ID_UZYTKOWNIKA,LOGIN,HASLO,UPRAWNIENIA) VALUES((SELECT MAX(ID_KLIENTA)+1 FROM klienci),'"
                + loginTextBox.Text + "','"
                + passwordTextBox.Text + "','uzytkownik')";
       
            MySqlCommand cmd = new MySqlCommand(sql2, conn);
            try
            {
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Utworzono konto");
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Login zajęty. Exception: " + ex.ToString());
            }
            conn.Close();
        }
    }
}
