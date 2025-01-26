using System;
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
        //Event for Login Button.
        private void btnLogin_Click(object sender, EventArgs e)
        {

            //Exception handling by try and catch block.
            try
            { 
                //Validating if text boxes are empty or not.
                if (String.IsNullOrEmpty(this.txtUserId.Text) || string.IsNullOrEmpty(this.txtPassword.Text))
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }
                //If text boxes or id and password field are not empty, then checking the id and password in Database.
                string sql = "select * from UserInfoo where id = '" + this.txtUserId.Text + "' and password = '" + this.txtPassword.Text + "'";
                //DataAccess class is a class in our project where All Sql query operation method implemented including database connection. It is because we will not have to write aql queries and methods in every time in every class.
                DataAccess da = new DataAccess();

                DataSet ds = da.ExecuteQuery(sql);
                var name = ds.Tables[0].Rows[0][1].ToString();
                var id = ds.Tables[0].Rows[0][0].ToString();
                //if id and password match in database then Row.count will 1
                if (ds.Tables[0].Rows.Count == 1)
                {
                    

                   //if Rows.count == 1 , it mean the user is valid and then checking if user is admin or employee.If admin it will open admin form and if employee it will open employeeform.
                    if (ds.Tables[0].Rows[0][3].ToString().Trim().Equals("admin"))
                    {
                       
                        this.txtUserId.Clear();
                        this.txtPassword.Clear();
                        this.Visible = false;
                        new AdminForm(this).Show();


                    }


                    else if (ds.Tables[0].Rows[0][3].ToString().Trim().Equals("employee"))

                    {
                       
                        this.txtUserId.Clear();
                        this.txtPassword.Clear();
                        this.Visible = false;
                        new EmployeeForm(id, name,this).Show();
                    } 
                    
                }
                //If id and password not match in data base then Invalid user messageBox will dsplay.
                else
                {

                    MessageBox.Show("Invalid User");
                }
               
            }
            catch(Exception exc)
            {
                MessageBox.Show("Invalid User " );
            }







        }
    }
}
