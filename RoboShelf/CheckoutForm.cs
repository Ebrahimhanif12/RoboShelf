using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboShelf
{
    public partial class CheckoutForm : Form
    {
        private DataAccess Da {  get; set; }
        public DataTable CartData { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        private decimal TotalPrice { get; set; }
        private EmployeeForm Ef { get; set; }

        public CheckoutForm(DataTable cartData,string employeeName, string employeeId, decimal totalPrice, EmployeeForm ef)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            //this.Ef = ef= new EmployeeForm(employeeId)
            this.Ef = ef;
            this.CartData = cartData;
            this.EmployeeId = employeeId;
            this.TotalPrice = totalPrice;
            LoadCheckoutData();
            this.lblTest.Text = this.EmployeeId;



        }

        private void LoadCheckoutData()
        {
            // Display employee ID
            //lblEmployeeId.Text = "Employee ID: " + EmployeeId;

            // Display cart items dynamically as labels
            int yPosition = 60;
            foreach (DataRow row in CartData.Rows)
            {
                string productName = row["Product Name"].ToString();
                string price = row["Price"].ToString();
                string quantity = row["Quantity"].ToString();
                string total = row["Total"].ToString();

                // Create a label for the cart item
                Label lblCartItem = new Label
                {
                    Text = $"{quantity} * {productName} | Price: {price} | Total: {total}",
                    AutoSize = true,
                    Location = new System.Drawing.Point(20, yPosition)
                };

                pnlCart.Controls.Add(lblCartItem);

                yPosition += lblCartItem.Height + 5;

                // Create a horizontal line (Panel as a divider)
                Panel horizontalLine = new Panel
                {
                    Height = 2,
                    Width = pnlCart.Width - 40,
                    BackColor = Color.Gray,
                    Location = new System.Drawing.Point(20, yPosition)
                };

                // Add the horizontal line to the panel
                pnlCart.Controls.Add(horizontalLine);





                yPosition += 10; // Adjust position for the next label
            }

            // Display total price
            lblTotalPrice.Text = " +Total Price: $" + TotalPrice.ToString("0.00");
        }

        private int AutoIdGenerate(string query)
        {
            try
            {
                // Query to get the maximum ID from the customer table
                
                var dt = this.Da.ExecuteQueryTable(query);

                // Get the current maximum ID or start with 0 if the table is empty
                int oldId = dt.Rows[0][0] != DBNull.Value ? Convert.ToInt32(dt.Rows[0][0]) : 0;

                // Increment to generate the new ID
                return oldId + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating new ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return -1 to indicate an error
            }
        }

          




        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SaveCustomerInfo();
        }

        private void SaveCustomerInfo()
        {
            // Input fields
            string customerName = txtCustomerName.Text.Trim();
            string customerEmail = txtCustomerEmail.Text.Trim();
            string customerPhone = txtCustomerPhone.Text.Trim();
            string paymentMethod = comboboxPayment.Text.Trim();

            // Validation
            if (string.IsNullOrEmpty(customerName) ||
                string.IsNullOrEmpty(customerEmail) || !IsValidEmail(customerEmail) ||
                string.IsNullOrEmpty(customerPhone) || !IsValidPhone(customerPhone) ||
                string.IsNullOrEmpty(paymentMethod))
            {
                string errorMessage = string.IsNullOrEmpty(customerName)
                    ? "Please enter the customer's name."
                    : (string.IsNullOrEmpty(customerEmail) || !IsValidEmail(customerEmail))
                    ? "Please enter a valid email address."
                    : (string.IsNullOrEmpty(customerPhone) || !IsValidPhone(customerPhone))
                    ? "Please enter a valid phone number."
                    : "Please select a payment method.";

                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Auto-generate IDs
            int customerId = AutoIdGenerate("SELECT MAX(id) FROM customer;");
            int invoiceId = AutoIdGenerate("SELECT MAX(invoiceId) FROM salesData");

            try
            {
                // Insert queries
                string customerInsertQuery = $@"
        INSERT INTO customer (id, name, email, phone, payment, paymentMethod) 
        VALUES ('{customerId}', '{customerName}', '{customerEmail}', '{customerPhone}', {this.TotalPrice}, '{paymentMethod}')";

                string salesInsertQuery = $@"
        INSERT INTO salesData (invoiceId, customerId, bill, selledBy) 
        VALUES ('{invoiceId}', '{customerId}', '{this.TotalPrice}', '{this.EmployeeId}')";

                // Execute queries
                int count = 0;
                count = this.Da.ExecuteDMLQuery(customerInsertQuery);
                count += this.Da.ExecuteDMLQuery(salesInsertQuery);

                if (count == 2)
                {
                    MessageBox.Show("Transaction completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear data
                    CartData.Clear();
                    pnlCart.Controls.Clear();
                    txtCustomerName.Clear();
                    txtCustomerEmail.Clear();
                    txtCustomerPhone.Clear();
                    comboboxPayment.SelectedIndex = -1;

                    // Navigate to EmployeeForm
                    this.Visible = false;
                    this.Ef.ClearCart();
                    this.Ef.LoadTotalSalesAmount(); // Reload the sales amount to ensure it's updated
                    this.Ef.RefreshCart();         // Optional: Clear or update the cart in the EmployeeForm if needed
                    this.Ef.Show();
                }
                else
                {
                    MessageBox.Show("Failed to save sales data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Utility Methods for Validation
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhone(string phone)
        {
            // Example: Ensure phone number contains only digits and is 10-15 characters long
            return phone.All(char.IsDigit) && phone.Length >= 10 && phone.Length <= 15;
        }



    }
}