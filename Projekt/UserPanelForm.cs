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
    public partial class UserPanelForm : Form
    {
        string ID_UZYTKOWNIKA;
        string connstr;

        private UserPanelForm()
        {
            InitializeComponent();
        }

        public UserPanelForm(string ID_UZYTKOWNIKA,string connstr)
        {
            this.ID_UZYTKOWNIKA = ID_UZYTKOWNIKA;
            this.connstr = connstr;
            InitializeComponent();
        }
    }
}
