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
    public partial class OrderDetailsForm : Form
    {
        private OrderDetailsForm()
        {
            InitializeComponent();
        }

        public OrderDetailsForm(int orderId)
        {
            InitializeComponent();
            OrderProductsGridView.DataSource = new BindingList<Product>(DatabaseAccess.Instance.GetOrderDetails(orderId).products);
        }
    }
}
