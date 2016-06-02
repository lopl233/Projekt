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
    public partial class Form4 : Form
    {
        string connstr;
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(string connstr)
        {
            this.connstr=connstr;

            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connstr);
            try
            { conn.Open(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Nie można połączyć się z serwerem");
            }
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || maskedTextBox1.Text == "")
            {
                MessageBox.Show("Uzupełnij wszystkie pola");
                conn.Close();
                return;
            }

            string sql ="INSERT INTO 'klienci' ('ID_KLIENTA' ,'IMIE' ,'NAZWISKO' ,'ADRES')VALUES((SELECT MAX(ID_KLIENTA)+1 FROM klienci),'"
                + textBox1.Text + "','"
                + textBox2.Text + "','"
                + textBox3.Text + "')";


            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { ex.ToString(); conn.Close(); }
            conn.Close();
        }
    }
}
