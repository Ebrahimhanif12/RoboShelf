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
            this.gvbProduct = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProductList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvbProduct)).BeginInit();
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
            this.productCategoey,
            this.productPrice,
            this.productStock});
            this.gvbProduct.Location = new System.Drawing.Point(0, 73);
            this.gvbProduct.Name = "gvbProduct";
            this.gvbProduct.RowHeadersWidth = 62;
            this.gvbProduct.RowTemplate.Height = 28;
            this.gvbProduct.Size = new System.Drawing.Size(905, 409);
            this.gvbProduct.TabIndex = 0;
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
            // productCategoey
            // 
            this.productCategoey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productCategoey.FillWeight = 89.48863F;
            this.productCategoey.HeaderText = "Category";
            this.productCategoey.MinimumWidth = 8;
            this.productCategoey.Name = "productCategoey";
            this.productCategoey.ReadOnly = true;
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
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductList.Location = new System.Drawing.Point(314, 27);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(227, 44);
            this.lblProductList.TabIndex = 1;
            this.lblProductList.Text = "Product List";
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblProductList);
            this.Controls.Add(this.gvbProduct);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(882, 505);
            ((System.ComponentModel.ISupportInitialize)(this.gvbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvbProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoey;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStock;
        private System.Windows.Forms.Label lblProductList;
    }
}
