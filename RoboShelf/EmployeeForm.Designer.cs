namespace RoboShelf
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblLowstock = new System.Windows.Forms.Label();
            this.dgvLowStock = new System.Windows.Forms.DataGridView();
            this.idLowStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameLowStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLowStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gdvCart = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewButtonColumn();
            this.quantity = new System.Windows.Forms.DataGridViewButtonColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewButtonColumn();
            this.increase = new System.Windows.Forms.DataGridViewButtonColumn();
            this.decrease = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.gdvEmployee = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTotalSale = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(55, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1497, 589);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lblLowstock);
            this.panel7.Controls.Add(this.dgvLowStock);
            this.panel7.Location = new System.Drawing.Point(56, 310);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(494, 258);
            this.panel7.TabIndex = 5;
            // 
            // lblLowstock
            // 
            this.lblLowstock.AutoSize = true;
            this.lblLowstock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLowstock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLowstock.Font = new System.Drawing.Font("Segoe Fluent Icons", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowstock.Location = new System.Drawing.Point(132, 22);
            this.lblLowstock.Name = "lblLowstock";
            this.lblLowstock.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblLowstock.Size = new System.Drawing.Size(207, 34);
            this.lblLowstock.TabIndex = 1;
            this.lblLowstock.Text = "Low Stock Items";
            this.lblLowstock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvLowStock
            // 
            this.dgvLowStock.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLowStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLowStock,
            this.nameLowStock,
            this.stockLowStock});
            this.dgvLowStock.Location = new System.Drawing.Point(0, 80);
            this.dgvLowStock.Name = "dgvLowStock";
            this.dgvLowStock.RowHeadersWidth = 62;
            this.dgvLowStock.RowTemplate.Height = 28;
            this.dgvLowStock.Size = new System.Drawing.Size(489, 177);
            this.dgvLowStock.TabIndex = 0;
            // 
            // idLowStock
            // 
            this.idLowStock.HeaderText = "Id";
            this.idLowStock.MinimumWidth = 8;
            this.idLowStock.Name = "idLowStock";
            this.idLowStock.Width = 80;
            // 
            // nameLowStock
            // 
            this.nameLowStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameLowStock.HeaderText = "Name";
            this.nameLowStock.MinimumWidth = 8;
            this.nameLowStock.Name = "nameLowStock";
            // 
            // stockLowStock
            // 
            this.stockLowStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stockLowStock.HeaderText = "Stock";
            this.stockLowStock.MinimumWidth = 8;
            this.stockLowStock.Name = "stockLowStock";
            this.stockLowStock.Width = 80;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.lblId);
            this.panel4.Controls.Add(this.lblName4);
            this.panel4.Controls.Add(this.lblName);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(193, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 132);
            this.panel4.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(138, 80);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 32);
            this.lblId.TabIndex = 5;
            // 
            // lblName4
            // 
            this.lblName4.AutoSize = true;
            this.lblName4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName4.Location = new System.Drawing.Point(87, 22);
            this.lblName4.Name = "lblName4";
            this.lblName4.Size = new System.Drawing.Size(87, 32);
            this.lblName4.TabIndex = 4;
            this.lblName4.Text = "sddfffg";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 32);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(56, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 288);
            this.panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(92, 243);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(142, 42);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Controls.Add(this.lblTotalSale);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(3, 135);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(318, 92);
            this.panel6.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Sales";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnConfirm);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(639, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(913, 570);
            this.panel3.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(671, 499);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(169, 46);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Procced";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.gdvCart);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(50, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(801, 464);
            this.panel5.TabIndex = 1;
            // 
            // gdvCart
            // 
            this.gdvCart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gdvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.ProductPrice,
            this.quantity,
            this.subTotal,
            this.increase,
            this.decrease});
            this.gdvCart.Location = new System.Drawing.Point(21, 57);
            this.gdvCart.Name = "gdvCart";
            this.gdvCart.RowHeadersWidth = 62;
            this.gdvCart.RowTemplate.Height = 28;
            this.gdvCart.Size = new System.Drawing.Size(767, 400);
            this.gdvCart.TabIndex = 4;
            this.gdvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvCart_CellContentClick);
            // 
            // ProductId
            // 
            this.ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.MinimumWidth = 8;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Width = 150;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 8;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.MinimumWidth = 8;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            this.ProductPrice.Width = 80;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantityl";
            this.quantity.MinimumWidth = 8;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 50;
            // 
            // subTotal
            // 
            this.subTotal.HeaderText = "Subtotal";
            this.subTotal.MinimumWidth = 8;
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            this.subTotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.subTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.subTotal.Width = 50;
            // 
            // increase
            // 
            this.increase.HeaderText = "";
            this.increase.MinimumWidth = 8;
            this.increase.Name = "increase";
            this.increase.Width = 30;
            // 
            // decrease
            // 
            this.decrease.HeaderText = "";
            this.decrease.MinimumWidth = 8;
            this.decrease.Name = "decrease";
            this.decrease.Width = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cart";
            // 
            // gdvEmployee
            // 
            this.gdvEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gdvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.category,
            this.price,
            this.stock,
            this.description,
            this.addBtn});
            this.gdvEmployee.Location = new System.Drawing.Point(55, 708);
            this.gdvEmployee.Name = "gdvEmployee";
            this.gdvEmployee.RowHeadersWidth = 62;
            this.gdvEmployee.RowTemplate.Height = 28;
            this.gdvEmployee.Size = new System.Drawing.Size(1497, 631);
            this.gdvEmployee.TabIndex = 1;
            this.gdvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvEmployee_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.HeaderText = "Product Id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 8;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 8;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 8;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // addBtn
            // 
            this.addBtn.HeaderText = "";
            this.addBtn.MinimumWidth = 8;
            this.addBtn.Name = "addBtn";
            this.addBtn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.addBtn.Text = "Add To Cart";
            this.addBtn.Width = 150;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Location = new System.Drawing.Point(90, 640);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(517, 46);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search by Product or Category name";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lblTotalSale
            // 
            this.lblTotalSale.AutoSize = true;
            this.lblTotalSale.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSale.Location = new System.Drawing.Point(173, 31);
            this.lblTotalSale.Name = "lblTotalSale";
            this.lblTotalSale.Size = new System.Drawing.Size(0, 48);
            this.lblTotalSale.TabIndex = 3;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2378, 1590);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gdvEmployee);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "EmployeeForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gdvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewButtonColumn addBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gdvCart;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewButtonColumn ProductPrice;
        private System.Windows.Forms.DataGridViewButtonColumn quantity;
        private System.Windows.Forms.DataGridViewButtonColumn subTotal;
        private System.Windows.Forms.DataGridViewButtonColumn increase;
        private System.Windows.Forms.DataGridViewButtonColumn decrease;
        private System.Windows.Forms.Label lblName4;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvLowStock;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblLowstock;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLowStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameLowStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLowStock;
        private System.Windows.Forms.Label lblTotalSale;
    }
}