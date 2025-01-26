namespace RoboShelf
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gvbProduct = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProductList = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvbProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvbProduct
            // 
            this.gvbProduct.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.gvbProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvbProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvbProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.productName,
            this.productCategory,
            this.productPrice,
            this.productStock,
            this.productDescription,
            this.productImagePath});
            this.gvbProduct.Location = new System.Drawing.Point(-10, 84);
            this.gvbProduct.Name = "gvbProduct";
            this.gvbProduct.RowHeadersWidth = 62;
            this.gvbProduct.RowTemplate.Height = 28;
            this.gvbProduct.Size = new System.Drawing.Size(1019, 329);
            this.gvbProduct.TabIndex = 0;
            this.gvbProduct.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvbProduct_CellMouseDown);
            // 
            // productId
            // 
            this.productId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productId.FillWeight = 142.0455F;
            this.productId.HeaderText = "Id";
            this.productId.MinimumWidth = 8;
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            this.productId.Width = 50;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.FillWeight = 89.48863F;
            this.productName.HeaderText = "Product Name";
            this.productName.MinimumWidth = 8;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // productCategory
            // 
            this.productCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productCategory.FillWeight = 89.48863F;
            this.productCategory.HeaderText = "Category";
            this.productCategory.MinimumWidth = 8;
            this.productCategory.Name = "productCategory";
            this.productCategory.ReadOnly = true;
            // 
            // productPrice
            // 
            this.productPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productPrice.FillWeight = 89.48863F;
            this.productPrice.HeaderText = "Price";
            this.productPrice.MinimumWidth = 8;
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            this.productPrice.Width = 80;
            // 
            // productStock
            // 
            this.productStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productStock.FillWeight = 89.48863F;
            this.productStock.HeaderText = "Stock";
            this.productStock.MinimumWidth = 8;
            this.productStock.Name = "productStock";
            this.productStock.ReadOnly = true;
            this.productStock.Width = 80;
            // 
            // productDescription
            // 
            this.productDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productDescription.HeaderText = "Description";
            this.productDescription.MinimumWidth = 8;
            this.productDescription.Name = "productDescription";
            this.productDescription.ReadOnly = true;
            // 
            // productImagePath
            // 
            this.productImagePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productImagePath.HeaderText = "ImagePath";
            this.productImagePath.MinimumWidth = 8;
            this.productImagePath.Name = "productImagePath";
            this.productImagePath.ReadOnly = true;
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductList.Location = new System.Drawing.Point(379, 41);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(151, 29);
            this.lblProductList.TabIndex = 1;
            this.lblProductList.Text = "Product List";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gvbProduct);
            this.panel1.Controls.Add(this.lblProductList);
            this.panel1.Location = new System.Drawing.Point(3, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 662);
            this.panel1.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(43, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(311, 30);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "Search Here...";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Right click on product to update or delete";
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(143, 68);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search by product or categore name";
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(1012, 696);
            ((System.ComponentModel.ISupportInitialize)(this.gvbProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvbProduct;
        private System.Windows.Forms.Label lblProductList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn productImagePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
    }
}
