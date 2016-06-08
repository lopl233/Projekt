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
           // dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = new BindingList<Order>(DatabaseAccess.Instance.GetOrdersList(user));
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void UserPanelForm_Load(object sender, EventArgs e)
        {

        }

        private void Ośwież_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new BindingList<Order>(DatabaseAccess.Instance.GetOrdersList(user));
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                dataGridView2.DataSource = new BindingList<Product>(DatabaseAccess.Instance.GetOrderDetails((int)dataGridView1.Rows[index].Cells[0].Value).products);
            }
            catch (Exception) { }
        }

    }
}
