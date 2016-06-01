using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form3 : Form
    {
        string ID_UZYTKOWNIKA;
        string connstr;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string ID_UZYTKOWNIKA,string connstr)
        {
            this.ID_UZYTKOWNIKA = ID_UZYTKOWNIKA;
            this.connstr = connstr;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
