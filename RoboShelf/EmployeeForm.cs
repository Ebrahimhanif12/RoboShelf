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


    public partial class EmployeeForm : Form


    {
        public string EmployeeName {  get; set; }
        public string EmployeeId { get; set; }
        public LoginForm Lf {  get; set; }

        private List<CartItem> cartItems = new List<CartItem>();
        private DataAccess Da { get; set; }
        public EmployeeForm(string employeeId, string employeeName) 

        {
            this.Da = new DataAccess();

            InitializeComponent();
            LoadProductData();
            this.EmployeeName = employeeName;
            this.EmployeeId = employeeId;
            this.lblName4.Text = this.EmployeeName;
            this.lblId.Text = employeeId;
        }



        //Function for load all products.
        private void LoadProductData()
        {
            try
            {
                string query = "SELECT id,name, category, price, stock, description FROM product"; // Change 'employee' to your actual table name
                DataTable dt = Da.ExecuteQueryTable(query);

                foreach (DataRow row in dt.Rows)
                {
                    gdvEmployee.Rows.Add(
                        row["id"].ToString(),
                        row["name"].ToString(),
                        row["category"].ToString(),
                        row["price"].ToString(),
                        row["stock"].ToString(),
                        row["description"].ToString(),
                        "Add To Cart"


                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //Function for update database by stock 
        private void UpdateProductStockInDatabase(int productId, int newStock)
        {
            try
            {
                string query = $"UPDATE product SET stock = {newStock} WHERE id = {productId}";
                Da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating stock in database: {ex.Message}");
            }
        }

        //Function for handling add to cart button
        private void AddToCart(int productId, string name, decimal price, int stock)
        {
            var existingItem = cartItems.FirstOrDefault(item => item.ProductId == productId);

            if (existingItem != null)
            {
                if (existingItem.Quantity < stock)
                {
                    existingItem.Quantity++;
                    UpdateProductStockInDatabase(productId, stock - 1); // Reduce stock in database
                }
                else
                {
                    MessageBox.Show("Not enough stock!");
                }
            }
            else
            {
                if (stock > 0)
                {
                    cartItems.Add(new CartItem
                    {
                        ProductId = productId,
                        Name = name,
                        Price = price,
                        Quantity = 1
                    });
                    UpdateProductStockInDatabase(productId, stock - 1); // Reduce stock in database
                }
                else
                {
                    MessageBox.Show("Stock is empty!");
                }
            }

            RefreshCart();
            RefreshProductData();
        }

        //Function for Refresh cart
        private void RefreshCart()
        {
            gdvCart.Rows.Clear();

            foreach (var item in cartItems)
            {
                gdvCart.Rows.Add(item.ProductId, item.Name, item.Price, item.Quantity, item.Subtotal, "+", "-");
            }
        }
        //Add To cart Buton Event
        private void gdvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gdvEmployee.Columns["addBtn"].Index && e.RowIndex >= 0)
            {
                int productId = Convert.ToInt32(gdvEmployee.Rows[e.RowIndex].Cells["id"].Value);
                string name = gdvEmployee.Rows[e.RowIndex].Cells["name"].Value.ToString();
                decimal price = Convert.ToDecimal(gdvEmployee.Rows[e.RowIndex].Cells["price"].Value);
                int stock = Convert.ToInt32(gdvEmployee.Rows[e.RowIndex].Cells["stock"].Value);


                bool alreadyInCart = false;

                foreach (DataGridViewRow row in gdvCart.Rows)
                {
                    if (Convert.ToInt32(row.Cells["ProductId"].Value) == productId)
                    {
                        alreadyInCart = true;
                        break;
                    }
                }

                if (alreadyInCart)
                {
                    MessageBox.Show($"The product '{name}' is already in the cart!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    AddToCart(productId, name, price, stock);
                }
            }
        }


       

        //Function for getting stock value by id
        private int GetStock(int productId)
        {
            foreach (DataGridViewRow row in gdvEmployee.Rows)
            {
                if (Convert.ToInt32(row.Cells["id"].Value) == productId)
                {
                    return Convert.ToInt32(row.Cells["stock"].Value);
                }
            }
            return 0;
        }
        //Function for update stock value in product list
        private void UpdateStock()
        {
            foreach (DataGridViewRow row in gdvEmployee.Rows)
            {
                int productId = Convert.ToInt32(row.Cells["id"].Value);
                var cartItem = cartItems.FirstOrDefault(item => item.ProductId == productId);
                int stock = GetStock(productId) - (cartItem?.Quantity ?? 0);

                row.Cells["stock"].Value = stock;
            }
        }
        // Increase and Decrease button event in Cart.
        private void gdvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = gdvCart.Rows[e.RowIndex];
                string productName = selectedRow.Cells["ProductName"].Value.ToString();

                var cartItem = cartItems.FirstOrDefault(item => item.Name == productName);

                if (cartItem != null)
                {
                    if (e.ColumnIndex == gdvCart.Columns["Increase"].Index) // '+' Button
                    {
                        var stock = GetStock(cartItem.ProductId);
                        if (cartItem.Quantity < stock)
                        {
                            cartItem.Quantity++;
                            UpdateProductStockInDatabase(cartItem.ProductId, stock - 1); // Reduce stock in database
                        }
                        else
                        {
                            MessageBox.Show("Not enough stock!");
                        }
                    }
                    else if (e.ColumnIndex == gdvCart.Columns["Decrease"].Index) // '-' Button
                    {
                        if (cartItem.Quantity > 1)
                        {
                            cartItem.Quantity--;
                            UpdateProductStockInDatabase(cartItem.ProductId, GetStock(cartItem.ProductId) + 1); // Increase stock in database
                        }
                        else
                        {
                            cartItems.Remove(cartItem);
                            UpdateProductStockInDatabase(cartItem.ProductId, GetStock(cartItem.ProductId) + 1); // Increase stock in database
                        }
                    }
                }

                RefreshCart();
                RefreshProductData(); // Refresh the product grid to reflect stock changes
            }

        }
        //Function for Refresh Product data.
        private void RefreshProductData()
        {
            gdvEmployee.Rows.Clear();
            LoadProductData(); // Reload data from the database
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search by Product or Category Name...";
                txtSearch.ForeColor = Color.Gray;  // Change text color to gray for placeholder effect
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim().ToLower();

            try
            {
                // SQL query to filter products by name or category
                string query = $"SELECT id, name, category, price, stock, description FROM product " +
                               $"WHERE name LIKE '%{searchQuery}%' OR category LIKE '%{searchQuery}%'";

                // Execute the query and update the DataGridView
                DataTable dt = Da.ExecuteQueryTable(query);
                gdvEmployee.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    gdvEmployee.Rows.Add(
                        row["id"].ToString(),
                        row["name"].ToString(),
                        row["category"].ToString(),
                        row["price"].ToString(),
                        row["stock"].ToString(),
                        row["description"].ToString(),
                        "Add To Cart"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (gdvCart.Rows.Count < 0)
            {
                MessageBox.Show("The cart is empty. Please add items to proceed.", "Cart Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Prepare cart data for checkout
                DataTable cartData = new DataTable();
                cartData.Columns.Add("Product Name");
                cartData.Columns.Add("Price");
                cartData.Columns.Add("Quantity");
                cartData.Columns.Add("Total");

                decimal totalPrice = 0;

                foreach (DataGridViewRow row in gdvCart.Rows)
                {
                    if (row.Cells[0].Value != null) // Ensure row is valid
                    {
                        string productName = row.Cells[1].Value.ToString();
                        decimal price = Convert.ToDecimal(row.Cells[2].Value);
                        int quantity = Convert.ToInt32(row.Cells[3].Value);
                        decimal total = Convert.ToDecimal(row.Cells[4].Value);

                        cartData.Rows.Add(productName, price, quantity, total);
                        totalPrice += total;
                    }
                }

                // Pass data to CheckoutForm
               // string employeeId = lblEmployeeId.Text; // Assuming lblEmployeeId holds the logged-in Employee ID
                CheckoutForm checkoutForm = new CheckoutForm(cartData, this.EmployeeId, totalPrice);
                this.Visible = false;
                checkoutForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Proceed Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    


}
