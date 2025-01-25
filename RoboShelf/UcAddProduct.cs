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
    public partial class UcAddProduct : UserControl
    {

        private DataAccess Da { get; set; }

        public UcAddProduct()
        {
            this.Da = new DataAccess();
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtCategory.Text) || string.IsNullOrEmpty(txtDescription.Text) ||
                string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtStock.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure valid data types for numeric inputs
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price. Please enter a valid decimal number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Invalid stock. Please enter a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Insert query
                string query = @"INSERT INTO product (image_path, name, category, description, price, stock) 
                                 VALUES ('" + txtId.Text + "', '" + txtName.Text + "', '" + txtCategory.Text +
                                 "', '" + txtDescription.Text + "', " + price + ", " + stock + ");";

                // Execute query
                int result = this.Da.ExecuteDMLQuery(query);

                // Show success or error message based on the result
                if (result > 0)
                {
                    MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs(); // Clear inputs after successful insertion
                    //ucProduct ucp = new ucProduct();
                    //ucp.LoadProductData();
                }
                else
                {
                    MessageBox.Show("Failed to add product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtId.Clear();
            txtName.Clear();
            txtCategory.Clear();
            txtDescreption.Clear();
            txtPrice.Clear();
            txtStock.Clear();
        }
    }
}

