namespace RoboShelf
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pnlForList = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblEmployeeList = new System.Windows.Forms.Label();
            this.gdvEmployeeList = new System.Windows.Forms.DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlForCUDUser = new System.Windows.Forms.Panel();
            this.btnViewEmployee = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlForList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btnViewEmployee);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnSalesReport);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 762);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(53, 647);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(188, 50);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            this.btnLogout.MouseHover += new System.EventHandler(this.btnLogout_MouseHover);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSalesReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalesReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesReport.Location = new System.Drawing.Point(53, 567);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(188, 50);
            this.btnSalesReport.TabIndex = 3;
            this.btnSalesReport.Text = "   Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = false;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            this.btnSalesReport.MouseLeave += new System.EventHandler(this.btnSalesReport_MouseLeave);
            this.btnSalesReport.MouseHover += new System.EventHandler(this.btnSalesReport_MouseHover);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(53, 406);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(188, 49);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "View Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            this.btnProduct.MouseLeave += new System.EventHandler(this.btnProduct_MouseLeave);
            this.btnProduct.MouseHover += new System.EventHandler(this.btnProduct_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(53, 327);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(188, 53);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            this.btnAddUser.MouseLeave += new System.EventHandler(this.btnAddUser_MouseLeave);
            this.btnAddUser.MouseHover += new System.EventHandler(this.btnAddUser_MouseHover);
            // 
            // pnlForList
            // 
            this.pnlForList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlForList.Controls.Add(this.btnRefresh);
            this.pnlForList.Controls.Add(this.lblEmployeeList);
            this.pnlForList.Controls.Add(this.gdvEmployeeList);
            this.pnlForList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlForList.Location = new System.Drawing.Point(303, 441);
            this.pnlForList.Name = "pnlForList";
            this.pnlForList.Size = new System.Drawing.Size(882, 321);
            this.pnlForList.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(736, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 55);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "   Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblEmployeeList
            // 
            this.lblEmployeeList.AutoSize = true;
            this.lblEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeList.Location = new System.Drawing.Point(319, 24);
            this.lblEmployeeList.Name = "lblEmployeeList";
            this.lblEmployeeList.Size = new System.Drawing.Size(178, 29);
            this.lblEmployeeList.TabIndex = 2;
            this.lblEmployeeList.Text = "Employee List";
            // 
            // gdvEmployeeList
            // 
            this.gdvEmployeeList.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.gdvEmployeeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.userName,
            this.userRole,
            this.totalSale});
            this.gdvEmployeeList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gdvEmployeeList.Location = new System.Drawing.Point(0, 73);
            this.gdvEmployeeList.Name = "gdvEmployeeList";
            this.gdvEmployeeList.RowHeadersWidth = 62;
            this.gdvEmployeeList.RowTemplate.Height = 28;
            this.gdvEmployeeList.Size = new System.Drawing.Size(882, 248);
            this.gdvEmployeeList.TabIndex = 0;
            // 
            // userId
            // 
            this.userId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userId.HeaderText = "Id";
            this.userId.MinimumWidth = 8;
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            // 
            // userName
            // 
            this.userName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userName.HeaderText = "Name";
            this.userName.MinimumWidth = 8;
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // userRole
            // 
            this.userRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userRole.HeaderText = "Role";
            this.userRole.MinimumWidth = 8;
            this.userRole.Name = "userRole";
            this.userRole.ReadOnly = true;
            // 
            // totalSale
            // 
            this.totalSale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalSale.HeaderText = "Total Sales";
            this.totalSale.MinimumWidth = 8;
            this.totalSale.Name = "totalSale";
            this.totalSale.ReadOnly = true;
            // 
            // pnlForCUDUser
            // 
            this.pnlForCUDUser.Location = new System.Drawing.Point(321, 29);
            this.pnlForCUDUser.Name = "pnlForCUDUser";
            this.pnlForCUDUser.Size = new System.Drawing.Size(851, 394);
            this.pnlForCUDUser.TabIndex = 3;
            // 
            // btnViewEmployee
            // 
            this.btnViewEmployee.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnViewEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewEmployee.Location = new System.Drawing.Point(53, 484);
            this.btnViewEmployee.Name = "btnViewEmployee";
            this.btnViewEmployee.Size = new System.Drawing.Size(188, 49);
            this.btnViewEmployee.TabIndex = 5;
            this.btnViewEmployee.Text = "View Employee";
            this.btnViewEmployee.UseVisualStyleBackColor = false;
            this.btnViewEmployee.Click += new System.EventHandler(this.btnViewEmployee_Click);
            this.btnViewEmployee.MouseLeave += new System.EventHandler(this.btnViewEmployee_MouseLeave);
            this.btnViewEmployee.MouseHover += new System.EventHandler(this.btnViewEmployee_MouseHover);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 762);
            this.Controls.Add(this.pnlForCUDUser);
            this.Controls.Add(this.pnlForList);
            this.Controls.Add(this.panel1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlForList.ResumeLayout(false);
            this.pnlForList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmployeeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlForList;
        private System.Windows.Forms.DataGridView gdvEmployeeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSale;
        private System.Windows.Forms.Label lblEmployeeList;
        private System.Windows.Forms.Panel pnlForCUDUser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnViewEmployee;
    }
}