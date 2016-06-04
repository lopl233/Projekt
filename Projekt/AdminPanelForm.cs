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
        }

        private void refreshProductsList_Click(object sender, EventArgs e)
        {
            ProductsDataGridView.DataSource = new BindingList<Product>(DatabaseAccess.Instance.getProductsList());
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
                DatabaseAccess.Instance.updateProduct(updatedProduct);
                return;
            }

            if (e.ColumnIndex == ProductsDataGridView.Columns["RemoveProductGridViewButton"].Index)
            {
                DatabaseAccess.Instance.removeProduct((int) ProductsDataGridView["IDGridViewTextBox", e.RowIndex].Value);
                ProductsDataGridView.DataSource = new BindingList<Product>(DatabaseAccess.Instance.getProductsList());
                return;
            }
        }

        private void AddNewProductButton_Click(object sender, EventArgs e)
        {
            NewProductForm form = new NewProductForm();
            form.Show();
        }
    }
}
