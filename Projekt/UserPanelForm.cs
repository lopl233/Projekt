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
        User user;
        private UserPanelForm() { }

        public UserPanelForm(User usr)
        {
            this.user = usr;
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = new BindingList<Order>(DatabaseAccess.Instance.GetOrdersList(user));
        }

        private void UserPanelForm_Load(object sender, EventArgs e)
        {

        }

        private void Ośwież_Click(object sender, EventArgs e)
        {

        }
    }
}
