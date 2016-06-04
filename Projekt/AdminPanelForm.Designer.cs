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
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.RefreshProductsListButton = new System.Windows.Forms.Button();
            this.OrdersTabPage = new System.Windows.Forms.TabPage();
            this.IDGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwaGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IloscGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateProductGridViewButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RemoveProductGridViewButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddNewProductButton = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.ProductsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ProductsTabPage);
            this.TabControl.Controls.Add(this.OrdersTabPage);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(781, 373);
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
            this.ProductsTabPage.Size = new System.Drawing.Size(773, 347);
            this.ProductsTabPage.TabIndex = 0;
            this.ProductsTabPage.Text = "Produkty";
            this.ProductsTabPage.UseVisualStyleBackColor = true;
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.AllowUserToAddRows = false;
            this.ProductsDataGridView.AllowUserToDeleteRows = false;
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
            // RefreshProductsListButton
            // 
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
            this.OrdersTabPage.Location = new System.Drawing.Point(4, 22);
            this.OrdersTabPage.Name = "OrdersTabPage";
            this.OrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTabPage.Size = new System.Drawing.Size(773, 347);
            this.OrdersTabPage.TabIndex = 1;
            this.OrdersTabPage.Text = "Zamówienia";
            this.OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // IDGridViewTextBox
            // 
            this.IDGridViewTextBox.DataPropertyName = "id";
            this.IDGridViewTextBox.HeaderText = "ID";
            this.IDGridViewTextBox.Name = "IDGridViewTextBox";
            // 
            // NazwaGridViewTextBox
            // 
            this.NazwaGridViewTextBox.DataPropertyName = "nazwa";
            this.NazwaGridViewTextBox.HeaderText = "Nazwa";
            this.NazwaGridViewTextBox.Name = "NazwaGridViewTextBox";
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
            this.UpdateProductGridViewButton.Text = "Zaktualizuj";
            this.UpdateProductGridViewButton.UseColumnTextForButtonValue = true;
            // 
            // RemoveProductGridViewButton
            // 
            this.RemoveProductGridViewButton.HeaderText = "Usuń";
            this.RemoveProductGridViewButton.Name = "RemoveProductGridViewButton";
            this.RemoveProductGridViewButton.Text = "Usuń";
            this.RemoveProductGridViewButton.UseColumnTextForButtonValue = true;
            // 
            // AddNewProductButton
            // 
            this.AddNewProductButton.Location = new System.Drawing.Point(88, 319);
            this.AddNewProductButton.Name = "AddNewProductButton";
            this.AddNewProductButton.Size = new System.Drawing.Size(128, 23);
            this.AddNewProductButton.TabIndex = 3;
            this.AddNewProductButton.Text = "Dodaj nowy produkt";
            this.AddNewProductButton.UseVisualStyleBackColor = true;
            this.AddNewProductButton.Click += new System.EventHandler(this.AddNewProductButton_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ProductsTabPage;
        private System.Windows.Forms.TabPage OrdersTabPage;
        private System.Windows.Forms.Button RefreshProductsListButton;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwaGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IloscGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaGridViewTextBox;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateProductGridViewButton;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveProductGridViewButton;
        private System.Windows.Forms.Button AddNewProductButton;
    }
}