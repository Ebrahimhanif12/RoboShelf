﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RoboShelf
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            try
            {
                if (String.IsNullOrEmpty(this.txtUserId.Text) || string.IsNullOrEmpty(this.txtPassword.Text))
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                string sql = "select * from UserInfoo where id = '" + this.txtUserId.Text + "' and password = '" + this.txtPassword.Text + "'";
                DataAccess da = new DataAccess();

                DataSet ds = da.ExecuteQuery(sql);
                var name = ds.Tables[0].Rows[0][1].ToString();
                var id = ds.Tables[0].Rows[0][0].ToString();
               
                if (ds.Tables[0].Rows.Count == 1)
                {
                   // this.Visible = false;
                   // MessageBox.Show("Valid User");
                    
                    //MessageBox.Show("Role: " + ds.Tables[0].Rows[0][2] +" ");
                    if (ds.Tables[0].Rows[0][3].ToString().Trim().Equals("admin"))
                    {
                        MessageBox.Show("Admin" +name);
                    }


                    else if (ds.Tables[0].Rows[0][3].ToString().Trim().Equals("employee"))

                    {
                       // MessageBox.Show("Employee " + name + " " +id);
                        new EmployeeForm(id, name).Show();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }
                da.Sqlcon.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }







        }
    }
}
