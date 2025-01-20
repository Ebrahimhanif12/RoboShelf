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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gdvCart = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gdvEmployee = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewButtonColumn();
            this.quantity = new System.Windows.Forms.DataGridViewButtonColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewButtonColumn();
            this.increase = new System.Windows.Forms.DataGridViewButtonColumn();
            this.decrease = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCart)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(55, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1641, 699);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnConfirm);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(677, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 676);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.gdvCart);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(50, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(816, 582);
            this.panel5.TabIndex = 1;
            // 
            // gdvCart
            // 
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
            this.gdvCart.Size = new System.Drawing.Size(775, 494);
            this.gdvCart.TabIndex = 4;
            this.gdvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvCart_CellContentClick);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(56, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 592);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(25, 361);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(343, 198);
            this.panel4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Sales Today";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(361, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 37);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gdvEmployee
            // 
            this.gdvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.category,
            this.price,
            this.stock,
            this.description,
            this.addBtn});
            this.gdvEmployee.Location = new System.Drawing.Point(55, 804);
            this.gdvEmployee.Name = "gdvEmployee";
            this.gdvEmployee.RowHeadersWidth = 62;
            this.gdvEmployee.RowTemplate.Height = 28;
            this.gdvEmployee.Size = new System.Drawing.Size(1641, 631);
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
            this.txtSearch.Location = new System.Drawing.Point(89, 743);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(517, 46);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search by Product or Category name";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(697, 617);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(169, 46);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Procced";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // ProductId
            // 
            this.ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.MinimumWidth = 8;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
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
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1795, 1241);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gdvEmployee);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "EmployeeForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "EmployeeForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}