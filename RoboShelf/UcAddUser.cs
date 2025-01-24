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
   
    public partial class UcAddUser : UserControl
    {
        

        public UcAddUser()
        {
            InitializeComponent();
           
            
        }
        

        //DataAccess da = new DataAccess();
        
        private void AddUser()
        {
            DataAccess da = new DataAccess();
            try
            {
                if (string.IsNullOrEmpty(this.txtId.Text) || string.IsNullOrEmpty(this.txtName.Text) ||
                string.IsNullOrEmpty(this.txtPassword.Text) || string.IsNullOrEmpty(this.txtRole.Text))
                {
                    MessageBox.Show("Please fill all the empty field.");
                }

                else
                {
                    var sql = "insert into userInfoo values('" + this.txtId.Text + "', '" + this.txtName.Text + "','" +
                        this.txtPass.Text + "','" + this.txtRole.Text + "');"; 
                        int count = da.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("User has been added properly");

                        if (this.ParentForm is AdminForm adminForm)
                        {
                            adminForm.LoadEmployeeData();
                        }
                    }
                    else
                        MessageBox.Show("User hasn't been added properly");
                }
               // AdminForm af = new AdminForm();
                //af.LoadEmployeeData();

               



            }

            catch (Exception ex) 
            {
                MessageBox.Show("An error has occured, please check: " + ex.Message);
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
            
        {
            
            AddUser();
           // AdminForm af = new AdminForm();


           
            
            
        }
    }
}
