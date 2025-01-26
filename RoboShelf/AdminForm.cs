using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboShelf
{

    public partial class AdminForm : Form
    {
       private DataAccess Da {  get; set; }
        private LoginForm Lg { get; set; }
        public AdminForm(LoginForm lgf)
        {
            this.Lg = lgf;
            InitializeComponent();
            this.Da = new DataAccess();
            this.pnlForList.Controls.Add(this.gdvEmployeeList);
            LoadEmployeeData();
            //this.PopulateGridView();
        }
        


        public void LoadEmployeeData()
        {
           
            try
            {
                this.gdvEmployeeList.Rows.Clear();
                string query = "SELECT id,name, role FROM userInfoo where id LIKE '%e%'";
                DataTable dt = this.Da.ExecuteQueryTable(query);
               // string empId = dt.Rows[0].ToString();
               
                
                foreach (DataRow row in dt.Rows)
                {
                   string query2 = "SELECT SUM(bill) FROM salesData WHERE selledBy = '" + row["id"] + "';";
                    DataTable dt2 = this.Da.ExecuteQueryTable(query2);

                    string totalBill = (dt2.Rows[0][0] == DBNull.Value || dt2.Rows[0][0] == null) ? "0" : dt2.Rows[0][0].ToString();

                    this.gdvEmployeeList.Rows.Add(
                        row["id"].ToString(),
                        row["name"].ToString(),
                        row["role"].ToString(),
                        "$"+totalBill + ".00"



                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




       

        //Events for Add User Button.-----------
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.pnlForCUDUser.Controls.Clear();

            UcAddUser ucadd = new UcAddUser();
            this.pnlForCUDUser.Controls.Add(ucadd);

        }
        private void btnAddUser_MouseHover(object sender, EventArgs e)
        {
            btnAddUser.BackColor = Color.White;
            btnAddUser.ForeColor = Color.Black;
        }

        private void btnAddUser_MouseLeave(object sender, EventArgs e)
        {
            btnAddUser.BackColor = Color.CornflowerBlue;
            btnAddUser.ForeColor = Color.White;

        }

        //Events for Vew Product Button---------
        private void btnProduct_Click(object sender, EventArgs e)
        {
            ucProduct up = new ucProduct();
            this.pnlForList.Controls.Remove(this.lblEmployeeList);
            this.pnlForList.Controls.Remove(this.gdvEmployeeList);
            this.pnlForList.Controls.Add(up);
        }
        private void btnProduct_MouseHover(object sender, EventArgs e)
        {
            btnProduct.BackColor = Color.White;
            btnProduct.ForeColor = Color.Black;
        }
    

        private void btnProduct_MouseLeave(object sender, EventArgs e)
        {
            btnProduct.BackColor = Color.CornflowerBlue;
            btnProduct.ForeColor = Color.White;
        }

        //Events for Sales Report Button--------------------------------
        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            SalesReport sr = new SalesReport();
            sr.Show();
        }

        private void btnSalesReport_MouseHover(object sender, EventArgs e)
        {
            btnSalesReport.BackColor = Color.White;
            btnSalesReport.ForeColor = Color.Black;
        }

        private void btnSalesReport_MouseLeave(object sender, EventArgs e)
        {
            btnSalesReport.BackColor = Color.CornflowerBlue;
            btnSalesReport.ForeColor = Color.White;
        }

        //Events for Logout button.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //LoginForm loginForm = new LoginForm();
                this.Lg.Show();
                this.Close();
            }

        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.White;
            btnLogout.ForeColor = Color.Black;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.CornflowerBlue;
            btnLogout.ForeColor = Color.White;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnViewEmployee_Click(object sender, EventArgs e)
        {
            //LoadEmployeeData();
            //this.PopulateGridView();
            this.pnlForList.Controls.Clear();
           //LoadEmployeeData();
            this.pnlForList.Controls.Add(gdvEmployeeList);
        }

        private void btnViewEmployee_MouseHover(object sender, EventArgs e)
        {
            btnViewEmployee.BackColor = Color.White;
            btnViewEmployee.ForeColor = Color.Black;
        }

        private void btnViewEmployee_MouseLeave(object sender, EventArgs e)
        {
            btnViewEmployee.BackColor = Color.CornflowerBlue;
            btnViewEmployee.ForeColor = Color.White;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            this.pnlForCUDUser.Controls.Clear();
            UcAddProduct ucAdd = new UcAddProduct();
            this.pnlForCUDUser.Controls.Add(ucAdd);
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
