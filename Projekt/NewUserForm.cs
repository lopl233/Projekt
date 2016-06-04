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
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || 
                surenameTextBox.Text == "" || 
                adressTextBox.Text == "" || 
                loginTextBox.Text == "" || 
                passwordTextBox.Text == "")
            {
                MessageBox.Show("Uzupełnij wszystkie pola");
                return;
            }

            User usr = new User(nameTextBox.Text, surenameTextBox.Text, loginTextBox.Text,
                passwordTextBox.Text, adressTextBox.Text, "uzytkownik");

            try
            {
                DatabaseAccess.Instance.addUser(usr);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            MessageBox.Show("Użytkownik został stworzony.");
        }
    }
}
