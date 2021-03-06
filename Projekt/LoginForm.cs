﻿using System;
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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Wpisz login oraz hasło");
                return;
            }

            User usr;
            try
            {
                usr = DatabaseAccess.Instance.GetUser(loginTextBox.Text, passwordTextBox.Text);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            
            if (usr.uprawnienia == "admin")
            {
                AdminPanelForm panel = new AdminPanelForm(usr);
                this.Hide();
                panel.ShowDialog();
                this.Show();
            }
            else
            {
                UserPanelForm panel = new UserPanelForm(usr);
                this.Hide();
                panel.ShowDialog();
                this.Show();
            }

            return;
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            NewUserForm form = new NewUserForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender,e);
            }
        }
    }
}
