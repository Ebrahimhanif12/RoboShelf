using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RoboShelf
{
    public partial class UcUpdateProduct : UserControl
    {
        private string ID {  get; set; }
        public UcUpdateProduct(string id, string name, string category, string price, string stock, string description, string imagePath)
        {

            InitializeComponent();
            this.ID = id;
            this.txtName.Text = name;
            txtCategory.Text = category;
            txtPrice.Text = price;
            txtQuantity.Text = stock;
            txtDescreption.Text = description;
            txtImagePath.Text = imagePath;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess da = new DataAccess();
                // Construct the update query
                string query = $@"
                    UPDATE product 
                    SET 
                        name = '{this.txtName.Text}', 
                        category = '{txtCategory.Text}', 
                        price = {txtPrice.Text}, 
                        stock = {txtQuantity.Text}, 
                        description = '{txtDescription.Text}', 
                        image_path = '{txtImagePath.Text}' 
                    WHERE id = '{this.ID}'";

                // Execute the update query
                int rowsAffected = da.ExecuteDMLQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product updated successfully!");
                    // Optionally, refresh the product list in the parent control
                    this.Parent.Controls.Remove(this);
                    var parentForm = this.FindForm() as AdminForm;
                    
                   

                }
                else
                {
                    MessageBox.Show("Failed to update the product.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    
}
