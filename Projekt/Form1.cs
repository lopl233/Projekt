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
        public Form1()
        {

            string connStr = "server=localhost;user=root;database=Projekt;port=3306;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {conn.Open();}
            catch (Exception ex)
            { MessageBox.Show("Nie można połączyć się z serwerem"); }
            conn.Close();


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
