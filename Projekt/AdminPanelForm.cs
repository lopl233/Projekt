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
        private AdminPanelForm() { }

        public AdminPanelForm(User usr)
        {
            InitializeComponent();
            ProductsDataGridView.AutoGenerateColumns = false;
            OrdersDataGridView.AutoGenerateColumns = false;
            ProductsDataGridView.DataSource = new BindingList<Product>(DatabaseAccess.Instance.GetProductsList());
            OrdersDataGridView.DataSource = new BindingList<Order>(DatabaseAccess.Instance.GetOrdersList());
        }

        private void refreshProductsList_Click(object sender, EventArgs e)
        {
            ProductsDataGridView.DataSource = new BindingList<Product>(DatabaseAccess.Instance.GetProductsList());
        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) // if column name has been clicked
            {
                return;
            }

            if (e.ColumnIndex == ProductsDataGridView.Columns["UpdateProductGridViewButton"].Index)
            {
                Product updatedProduct = new Product((int) ProductsDataGridView["IDGridViewTextBox", e.RowIndex].Value,
                                                     (string) ProductsDataGridView["NazwaGridViewTextBox", e.RowIndex].Value,
                                                     (double) ProductsDataGridView["CenaGridViewTextBox", e.RowIndex].Value,
                                                     (int) ProductsDataGridView["IloscGridViewTextBox", e.RowIndex].Value);
                DatabaseAccess.Instance.UpdateProduct(updatedProduct);
                return;
            }

            if (e.ColumnIndex == ProductsDataGridView.Columns["RemoveProductGridViewButton"].Index)
            {
                DatabaseAccess.Instance.RemoveProduct((int) ProductsDataGridView["IDGridViewTextBox", e.RowIndex].Value);
                ProductsDataGridView.DataSource = new BindingList<Product>(DatabaseAccess.Instance.GetProductsList());
                return;
            }
        }

        private void AddNewProductButton_Click(object sender, EventArgs e)
        {
            NewProductForm form = new NewProductForm();
            form.Show();
        }

        private void RefreshOrdersListButton_Click(object sender, EventArgs e)
        {
            OrdersDataGridView.DataSource = new BindingList<Order>(DatabaseAccess.Instance.GetOrdersList());
        }

        private void OrdersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) // if column name has been clicked
            {
                return;
            }

            if (e.ColumnIndex == OrdersDataGridView.Columns["UpdateOrderStatusGridViewButton"].Index)
            {
                string newStatus = OrdersDataGridView["StatusGridViewComboBox", e.RowIndex].Value.ToString();
                int id = (int)OrdersDataGridView["OrderIDGridViewTextBox", e.RowIndex].Value;
                DatabaseAccess.Instance.UpdateOrderStatus(id, newStatus);
                OrdersDataGridView.DataSource = new BindingList<Order>(DatabaseAccess.Instance.GetOrdersList());
                MessageBox.Show("Status zaktualizowany");
                return;
            }

            if (e.ColumnIndex == OrdersDataGridView.Columns["RemoveOrderGridViewButton"].Index)
            {
                DatabaseAccess.Instance.RemoveOrder((int)OrdersDataGridView["OrderIDGridViewTextBox", e.RowIndex].Value);
                OrdersDataGridView.DataSource = new BindingList<Order>(DatabaseAccess.Instance.GetOrdersList());
                MessageBox.Show("Zamowienie usunięte");
                return;
            }

            if (e.ColumnIndex == OrdersDataGridView.Columns["ShowOrderDetailsGridViewButton"].Index)
            {
                OrderDetailsForm form = new OrderDetailsForm((int) OrdersDataGridView["OrderIDGridViewTextBox", e.RowIndex].Value);
                form.Show();
                return;
            }
        }
    }
}
