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
    public partial class AdminPanelForm : Form
    {
        string connstr;

        public AdminPanelForm(User usr)
        {
            InitializeComponent();
        }
    }
}
