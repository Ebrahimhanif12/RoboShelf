using System;
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
        
        public DataTable CartData { get; set; }
        public string EmployeeId { get; set; }
        private decimal TotalPrice { get; set; }

        public CheckoutForm(DataTable cartData, string employeeId, decimal totalPrice)
        {
            InitializeComponent();

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

        

    }
}
