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
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        string connStr;
        public Form1()
        {

            connStr = "server=sql7.freemysqlhosting.net	;user=sql7121947;password=mTUfwszQiq;database=sql7121947;port=3306;";
            conn = new MySqlConnection(connStr);
            try
            {conn.Open();}
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Nie można połączyć się z serwerem"); }


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || maskedTextBox1.Text == "") { MessageBox.Show("Wpisz login oraz hasło");return; }

            string sql = "SELECT ID_UZYTKOWNIKA,UPRAWNIENIA FROM logowania where LOGIN='"+textBox1.Text+"'and HASLO='"+maskedTextBox1.Text+"'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr=null;
            try
            {
                rdr = cmd.ExecuteReader();
            }catch(Exception ex) { MessageBox.Show(e.ToString()); }
            if (rdr.Read() == false) { MessageBox.Show("Zly login lub hasło"); rdr.Close(); return; }
            string uzytkownik;
            string uprawnienia;
            uzytkownik = rdr[0].ToString();
            uprawnienia= rdr[1].ToString();
            rdr.Close();
            if (uprawnienia == "admin") { Form2 panel = new Form2(connStr); panel.ShowDialog(); }
            else { Form3 panel = new Form3(uzytkownik, connStr); panel.ShowDialog(); }
            return;


        }
    }
}
