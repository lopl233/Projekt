namespace Projekt
{
    partial class AdminPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ProductsTabPage = new System.Windows.Forms.TabPage();
            this.AddNewProductButton = new System.Windows.Forms.Button();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.IDGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwaGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IloscGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateProductGridViewButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RemoveProductGridViewButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RefreshProductsListButton = new System.Windows.Forms.Button();
            this.OrdersTabPage = new System.Windows.Forms.TabPage();
            this.RefreshOrdersListButton = new System.Windows.Forms.Button();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.OrderIDGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDateGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderUserNameGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGridViewComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UpdateOrderStatusGridViewButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RemoveOrderGridViewButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ShowOrderDetailsGridViewButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TabControl.SuspendLayout();
            this.ProductsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.OrdersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.ProductsTabPage);
            this.TabControl.Controls.Add(this.OrdersTabPage);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(792, 373);
            this.TabControl.TabIndex = 0;
            // 
            // ProductsTabPage
            // 
            this.ProductsTabPage.Controls.Add(this.AddNewProductButton);
            this.ProductsTabPage.Controls.Add(this.ProductsDataGridView);
            this.ProductsTabPage.Controls.Add(this.RefreshProductsListButton);
            this.ProductsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ProductsTabPage.Name = "ProductsTabPage";
            this.ProductsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProductsTabPage.Size = new System.Drawing.Size(784, 347);
            this.ProductsTabPage.TabIndex = 0;
            this.ProductsTabPage.Text = "Produkty";
            this.ProductsTabPage.UseVisualStyleBackColor = true;
            // 
            // AddNewProductButton
            // 
            this.AddNewProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNewProductButton.Location = new System.Drawing.Point(87, 318);
            this.AddNewProductButton.Name = "AddNewProductButton";
            this.AddNewProductButton.Size = new System.Drawing.Size(128, 23);
            this.AddNewProductButton.TabIndex = 3;
            this.AddNewProductButton.Text = "Dodaj nowy produkt";
            this.AddNewProductButton.UseVisualStyleBackColor = true;
            this.AddNewProductButton.Click += new System.EventHandler(this.AddNewProductButton_Click);
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDGridViewTextBox,
            this.NazwaGridViewTextBox,
            this.IloscGridViewTextBox,
            this.CenaGridViewTextBox,
            this.UpdateProductGridViewButton,
            this.RemoveProductGridViewButton});
            this.ProductsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.Size = new System.Drawing.Size(761, 306);
            this.ProductsDataGridView.TabIndex = 2;
            this.ProductsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellContentClick);
            // 
            // IDGridViewTextBox
            // 
            this.IDGridViewTextBox.DataPropertyName = "id";
            this.IDGridViewTextBox.HeaderText = "ID";
            this.IDGridViewTextBox.Name = "IDGridViewTextBox";
            this.IDGridViewTextBox.ReadOnly = true;
            // 
            // NazwaGridViewTextBox
            // 
            this.NazwaGridViewTextBox.DataPropertyName = "nazwa";
            this.NazwaGridViewTextBox.HeaderText = "Nazwa";
            this.NazwaGridViewTextBox.Name = "NazwaGridViewTextBox";
            this.NazwaGridViewTextBox.ReadOnly = true;
            // 
            // IloscGridViewTextBox
            // 
            this.IloscGridViewTextBox.DataPropertyName = "ilosc";
            this.IloscGridViewTextBox.HeaderText = "Ilość";
            this.IloscGridViewTextBox.Name = "IloscGridViewTextBox";
            // 
            // CenaGridViewTextBox
            // 
            this.CenaGridViewTextBox.DataPropertyName = "cena";
            this.CenaGridViewTextBox.HeaderText = "Cena";
            this.CenaGridViewTextBox.Name = "CenaGridViewTextBox";
            // 
            // UpdateProductGridViewButton
            // 
            this.UpdateProductGridViewButton.HeaderText = "Zaktualizuj";
            this.UpdateProductGridViewButton.Name = "UpdateProductGridViewButton";
            this.UpdateProductGridViewButton.ReadOnly = true;
            this.UpdateProductGridViewButton.Text = "Zaktualizuj";
            this.UpdateProductGridViewButton.UseColumnTextForButtonValue = true;
            // 
            // RemoveProductGridViewButton
            // 
            this.RemoveProductGridViewButton.HeaderText = "Usuń";
            this.RemoveProductGridViewButton.Name = "RemoveProductGridViewButton";
            this.RemoveProductGridViewButton.ReadOnly = true;
            this.RemoveProductGridViewButton.Text = "Usuń";
            this.RemoveProductGridViewButton.UseColumnTextForButtonValue = true;
            // 
            // RefreshProductsListButton
            // 
            this.RefreshProductsListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RefreshProductsListButton.Location = new System.Drawing.Point(6, 318);
            this.RefreshProductsListButton.Name = "RefreshProductsListButton";
            this.RefreshProductsListButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshProductsListButton.TabIndex = 0;
            this.RefreshProductsListButton.Text = "Odśwież";
            this.RefreshProductsListButton.UseVisualStyleBackColor = true;
            this.RefreshProductsListButton.Click += new System.EventHandler(this.refreshProductsList_Click);
            // 
            // OrdersTabPage
            // 
            this.OrdersTabPage.Controls.Add(this.RefreshOrdersListButton);
            this.OrdersTabPage.Controls.Add(this.OrdersDataGridView);
            this.OrdersTabPage.Location = new System.Drawing.Point(4, 22);
            this.OrdersTabPage.Name = "OrdersTabPage";
            this.OrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTabPage.Size = new System.Drawing.Size(784, 347);
            this.OrdersTabPage.TabIndex = 1;
            this.OrdersTabPage.Text = "Zamówienia";
            this.OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // RefreshOrdersListButton
            // 
            this.RefreshOrdersListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RefreshOrdersListButton.Location = new System.Drawing.Point(7, 318);
            this.RefreshOrdersListButton.Name = "RefreshOrdersListButton";
            this.RefreshOrdersListButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshOrdersListButton.TabIndex = 1;
            this.RefreshOrdersListButton.Text = "Odśwież";
            this.RefreshOrdersListButton.UseVisualStyleBackColor = true;
            this.RefreshOrdersListButton.Click += new System.EventHandler(this.RefreshOrdersListButton_Click);
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToDeleteRows = false;
            this.OrdersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderIDGridViewTextBox,
            this.OrderDateGridViewTextBox,
            this.OrderUserNameGridViewTextBox,
            this.StatusGridViewComboBox,
            this.UpdateOrderStatusGridViewButton,
            this.RemoveOrderGridViewButton,
            this.ShowOrderDetailsGridViewButton});
            this.OrdersDataGridView.Location = new System.Drawing.Point(7, 7);
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.ReadOnly = true;
            this.OrdersDataGridView.Size = new System.Drawing.Size(771, 305);
            this.OrdersDataGridView.TabIndex = 0;
            this.OrdersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersDataGridView_CellContentClick);
            // 
            // OrderIDGridViewTextBox
            // 
            this.OrderIDGridViewTextBox.DataPropertyName = "orderId";
            this.OrderIDGridViewTextBox.HeaderText = "Nr zamówienia";
            this.OrderIDGridViewTextBox.Name = "OrderIDGridViewTextBox";
            this.OrderIDGridViewTextBox.ReadOnly = true;
            // 
            // OrderDateGridViewTextBox
            // 
            this.OrderDateGridViewTextBox.DataPropertyName = "date";
            this.OrderDateGridViewTextBox.HeaderText = "Data zamówienia";
            this.OrderDateGridViewTextBox.Name = "OrderDateGridViewTextBox";
            this.OrderDateGridViewTextBox.ReadOnly = true;
            // 
            // OrderUserNameGridViewTextBox
            // 
            this.OrderUserNameGridViewTextBox.DataPropertyName = "userName";
            this.OrderUserNameGridViewTextBox.HeaderText = "Użytkownik";
            this.OrderUserNameGridViewTextBox.Name = "OrderUserNameGridViewTextBox";
            this.OrderUserNameGridViewTextBox.ReadOnly = true;
            // 
            // StatusGridViewComboBox
            // 
            this.StatusGridViewComboBox.DataPropertyName = "status";
            this.StatusGridViewComboBox.HeaderText = "Status";
            this.StatusGridViewComboBox.Items.AddRange(new object[] {
            "Wykonane",
            "Oczekujące"});
            this.StatusGridViewComboBox.Name = "StatusGridViewComboBox";
            this.StatusGridViewComboBox.ReadOnly = true;
            // 
            // UpdateOrderStatusGridViewButton
            // 
            this.UpdateOrderStatusGridViewButton.HeaderText = "Zaktulizuj status";
            this.UpdateOrderStatusGridViewButton.Name = "UpdateOrderStatusGridViewButton";
            this.UpdateOrderStatusGridViewButton.ReadOnly = true;
            this.UpdateOrderStatusGridViewButton.Text = "Zaktulizuj status";
            this.UpdateOrderStatusGridViewButton.UseColumnTextForButtonValue = true;
            // 
            // RemoveOrderGridViewButton
            // 
            this.RemoveOrderGridViewButton.HeaderText = "Odrzuć zamówienie";
            this.RemoveOrderGridViewButton.Name = "RemoveOrderGridViewButton";
            this.RemoveOrderGridViewButton.ReadOnly = true;
            this.RemoveOrderGridViewButton.Text = "Odrzuć zamówienie";
            this.RemoveOrderGridViewButton.UseColumnTextForButtonValue = true;
            // 
            // ShowOrderDetailsGridViewButton
            // 
            this.ShowOrderDetailsGridViewButton.HeaderText = "Pokaż szczegóły";
            this.ShowOrderDetailsGridViewButton.Name = "ShowOrderDetailsGridViewButton";
            this.ShowOrderDetailsGridViewButton.ReadOnly = true;
            this.ShowOrderDetailsGridViewButton.Text = "Pokaż szczegóły";
            this.ShowOrderDetailsGridViewButton.UseColumnTextForButtonValue = true;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 397);
            this.Controls.Add(this.TabControl);
            this.Name = "AdminPanelForm";
            this.Text = "Panel Admina";
            this.TabControl.ResumeLayout(false);
            this.ProductsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.OrdersTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ProductsTabPage;
        private System.Windows.Forms.TabPage OrdersTabPage;
        private System.Windows.Forms.Button RefreshProductsListButton;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.Button AddNewProductButton;
        private System.Windows.Forms.Button RefreshOrdersListButton;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderIDGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDateGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderUserNameGridViewTextBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn StatusGridViewComboBox;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateOrderStatusGridViewButton;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveOrderGridViewButton;
        private System.Windows.Forms.DataGridViewButtonColumn ShowOrderDetailsGridViewButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwaGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IloscGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaGridViewTextBox;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateProductGridViewButton;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveProductGridViewButton;
    }
}