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
    public partial class Form2 : Form
    {
        string connstr;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string connstr)
        {
            this.connstr = connstr;
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
