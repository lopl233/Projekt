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
            ListaProduktow.DataSource = new BindingList<Product>(DatabaseAccess.Instance.GetProductsList());
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

        private void button1_Click(object sender, EventArgs e)
        {
            int index=ListaProduktow.SelectedRows[0].Index;
            String ProduktID = ListaProduktow.Rows[index].Cells["Id"].Value.ToString();
            String Nazwa = ListaProduktow.Rows[index].Cells["Nazwa"].Value.ToString();
            String cena = ListaProduktow.Rows[index].Cells["Cena"].Value.ToString();
            String iloscMAX= ListaProduktow.Rows[index].Cells["Ilosc"].Value.ToString();

            foreach (DataGridViewRow row in Koszyk.Rows)
            {
                try
                {
                    if (row.Cells["Id"].Value.ToString() == ProduktID) { MessageBox.Show("Produkt jest już w koszyku"); return; }
                }
                catch(Exception){ }
            }
            int ilosc2;
            if (ilosc.Text == "") ilosc2 = 1;
            else ilosc2 = Int32.Parse(ilosc.Text);
            if (Int32.Parse(iloscMAX) < ilosc2) { MessageBox.Show("Nie ma tyle sztuk w sklepie");return; }
            Koszyk.Rows.Add(ProduktID,Nazwa,ilosc2.ToString() , Double.Parse(cena) * ilosc2);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index;
            try
            {
                index = Koszyk.SelectedRows[0].Index;
            }
            catch (Exception) { MessageBox.Show("Nie wybrano produktu");return; }

            Koszyk.Rows.RemoveAt(index);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DatabaseAccess.Instance.CreateOrder(user).ToString());
        }
    }
}
