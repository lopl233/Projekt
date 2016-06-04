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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.productsTabPage = new System.Windows.Forms.TabPage();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshProductsList = new System.Windows.Forms.Button();
            this.ordersTabPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.productsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.productsTabPage);
            this.tabControl1.Controls.Add(this.ordersTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 373);
            this.tabControl1.TabIndex = 0;
            // 
            // productsTabPage
            // 
            this.productsTabPage.Controls.Add(this.productsDataGridView);
            this.productsTabPage.Controls.Add(this.refreshProductsList);
            this.productsTabPage.Location = new System.Drawing.Point(4, 22);
            this.productsTabPage.Name = "productsTabPage";
            this.productsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.productsTabPage.Size = new System.Drawing.Size(773, 347);
            this.productsTabPage.TabIndex = 0;
            this.productsTabPage.Text = "Produkty";
            this.productsTabPage.UseVisualStyleBackColor = true;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.Size = new System.Drawing.Size(761, 306);
            this.productsDataGridView.TabIndex = 2;
            // 
            // refreshProductsList
            // 
            this.refreshProductsList.Location = new System.Drawing.Point(6, 318);
            this.refreshProductsList.Name = "refreshProductsList";
            this.refreshProductsList.Size = new System.Drawing.Size(75, 23);
            this.refreshProductsList.TabIndex = 0;
            this.refreshProductsList.Text = "Odśwież";
            this.refreshProductsList.UseVisualStyleBackColor = true;
            this.refreshProductsList.Click += new System.EventHandler(this.refreshProductsList_Click);
            // 
            // ordersTabPage
            // 
            this.ordersTabPage.Location = new System.Drawing.Point(4, 22);
            this.ordersTabPage.Name = "ordersTabPage";
            this.ordersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ordersTabPage.Size = new System.Drawing.Size(773, 347);
            this.ordersTabPage.TabIndex = 1;
            this.ordersTabPage.Text = "Zamówienia";
            this.ordersTabPage.UseVisualStyleBackColor = true;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 397);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminPanelForm";
            this.Text = "Panel Admina";
            this.tabControl1.ResumeLayout(false);
            this.productsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage productsTabPage;
        private System.Windows.Forms.TabPage ordersTabPage;
        private System.Windows.Forms.Button refreshProductsList;
        private System.Windows.Forms.DataGridView productsDataGridView;
    }
}