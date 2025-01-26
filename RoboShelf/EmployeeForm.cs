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
        //Properties
        public string EmployeeName { get; set; }
        private string EmployeeId { get; set; }
        public LoginForm Lf { get; set; }
        private DataAccess Da { get; set; }

        private List<CartItem> cartItems = new List<CartItem>();
        public EmployeeForm(string employeeId, string employeeName , LoginForm lgf)

        {
            this.Lf = lgf;
            //DataAccess class is a class in our project where All Sql query operation method implemented including database connection. It is because we will not have to write aql queries and methods in every time in every class.
            //Now we will use Da property when we have to call any sql operation.
            this.Da = new DataAccess();
            this.EmployeeId = employeeId;
            InitializeComponent();
            //initially Loading total sale, Low stock data and all product iin form.
            LoadTotalSalesAmount();
            LoadLowStockData();
            LoadProductData();
            this.EmployeeName = employeeName;
            
            this.lblName4.Text = this.EmployeeName;
            this.lblId.Text = employeeId;
        }
       //Method for Loading Low stock product data which stocks are less than 10 from Database in form.
        private void LoadLowStockData()
        {   //try and catch block in every method for Exception handling which is a requirment of our project
            try
            {
                string query = "SELECT id,name,  stock FROM product where stock <10"; 
                DataTable dt = Da.ExecuteQueryTable(query);

                foreach (DataRow row in dt.Rows)
                {
                    dgvLowStock.Rows.Add(
                        row["id"].ToString(),
                        row["name"].ToString(),
                        row["stock"].ToString()
                        


                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        

        //Method for loading all product info from database in form
        private void LoadProductData()
        {
            try
            {
                string query = "SELECT id,name, category, price, stock, description FROM product"; 
                DataTable dt = Da.ExecuteQueryTable(query);
                //We add a ""Add to Cart ? button colum in every row for adding the selected tem into cart.
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

        //Function for Refresh cart after clcking Proceed button
        public void RefreshCart()
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

        
        //event for changing text in search box
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search by Product or Category Name...";
                txtSearch.ForeColor = Color.Gray;  // Change text color to gray for placeholder effect
            }
        }

        //event for changing text in search box
        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        //Evdnt for searching by text changed
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim().ToLower();

            try
            {
                // SQL query to filter products by name or category
                string query = $"SELECT id, name, category, price, stock, description FROM product " +
                               $"WHERE name LIKE '%{searchQuery}%' OR category LIKE '%{searchQuery}%'";

                // Executing the query and updating the DataGridView
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
        //Event for Proceed button
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (gdvCart.Rows.Count < 0)
            {
                MessageBox.Show("The cart is empty. Please add items to proceed.", "Cart Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Preparing cart data for checkout
                DataTable cartData = new DataTable();
                cartData.Columns.Add("Product Name");
                cartData.Columns.Add("Price");
                cartData.Columns.Add("Quantity");
                cartData.Columns.Add("Total");

                decimal totalPrice = 0;

                foreach (DataGridViewRow row in gdvCart.Rows)
                {
                    if (row.Cells[0].Value != null) 
                    {
                        string productName = row.Cells[1].Value.ToString();
                        decimal price = Convert.ToDecimal(row.Cells[2].Value);
                        int quantity = Convert.ToInt32(row.Cells[3].Value);
                        decimal total = Convert.ToDecimal(row.Cells[4].Value);

                        cartData.Rows.Add(productName, price, quantity, total);
                        totalPrice += total;
                    }
                }

                // Passiing data to CheckoutForm
                CheckoutForm checkoutForm = new CheckoutForm(cartData,this.EmployeeName, this.EmployeeId, totalPrice,this);
                this.Visible = false;
                checkoutForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Proceed Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Functon for calculating total sale amount
        public void LoadTotalSalesAmount()
        {
            try
            {
                

                // Query to calculate the total bill amount for the given EmployeeId
                string query = $@"
            SELECT SUM(bill)
            FROM salesData
            WHERE selledBy = '{this.EmployeeId}';";
               

                // Executing the query and retrieve the result
                var dt = this.Da.ExecuteQueryTable(query);

                // Extracting the total sales amount from the result
                decimal totalSales = dt.Rows[0][0] != DBNull.Value ? Convert.ToDecimal(dt.Rows[0][0]) : 0;

                // Updating the label to display the total sales amount
               this.lblTotalSale.Text = $"{totalSales:0.00}";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading total sales amount: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Function for clear cart data after procedd
        public void ClearCart()
        {
            this.cartItems.Clear(); 
            RefreshCart();          
        }

        //Event for logout button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Lf.Show();
        }
        //Event for closing application by close button
        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }



}