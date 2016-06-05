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
    public partial class NewProductForm : Form
    {
        public NewProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ProductNameTextBox.Text == "")
            {
                MessageBox.Show("Produkt musi mieć nazwę");
                return;
            }

            double cena = 0;
            if (ProductPriceTextBox.Text != "")
            {
                cena = Double.Parse(ProductPriceTextBox.Text);
                // TODO parsing might not work and exception is thrown
            }

            int ilosc = 0;
            if (ProductQuantityTextBox.Text != "")
            {
                ilosc = int.Parse(ProductQuantityTextBox.Text);
                // TODO parsing might not work and exception is thrown
            }

            Product newProduct = new Product(-1, ProductNameTextBox.Text, cena, ilosc);
            DatabaseAccess.Instance.AddProduct(newProduct);
            MessageBox.Show("Produkt został dodany");
        }
    }
}
