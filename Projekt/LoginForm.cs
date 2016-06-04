using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Projekt
{
    public partial class LoginForm : Form
    {
        MySqlConnection conn;
        string connStr;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            connStr = "server=sql7.freemysqlhosting.net	;user=sql7121947;password=mTUfwszQiq;database=sql7121947;port=3306;";
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Nie można połączyć się z serwerem");
            }

            if (loginTextBox.Text == "" || 
                passwordTextBox.Text == "")
            {
                MessageBox.Show("Wpisz login oraz hasło");
                return;
            }

            string sql = "SELECT ID_UZYTKOWNIKA,UPRAWNIENIA FROM logowania where LOGIN='"+loginTextBox.Text+"'and HASLO='"+passwordTextBox.Text+"'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr=null;
            try
            {
                rdr = cmd.ExecuteReader();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            if (rdr.Read() == false)
            {
                MessageBox.Show("Zly login lub hasło"); rdr.Close();
                return;
            }

            string uzytkownik;
            string uprawnienia;
            uzytkownik = rdr[0].ToString();
            uprawnienia= rdr[1].ToString();
            rdr.Close();
            if (uprawnienia == "admin") { AdminPanelForm panel = new AdminPanelForm(connStr); panel.ShowDialog(); }
            else { UserPanelForm panel = new UserPanelForm(uzytkownik, connStr); panel.ShowDialog(); }
            return;
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            NewUserForm form = new NewUserForm(connStr);
            form.ShowDialog();
        }
    }
}
