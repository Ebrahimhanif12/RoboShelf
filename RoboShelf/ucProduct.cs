using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboShelf
{
    public partial class ucProduct : UserControl
    {
        private DataAccess Da {  get; set; }
        
        public ucProduct()
        {
            this.Da = new DataAccess();
            InitializeComponent();
            LoadProductData();


        }


        public void LoadProductData()
        {
            //this.gvbProduct.AllowUserToAddRows = false;
            //this.gvbProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //this.gvbProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


           // DataAccess da = new DataAccess();
            try
            {
                string query = "SELECT id,name, category, price, stock,description ,image_path FROM product"; // Change 'employee' to your actual table name
                DataTable dt = this.Da.ExecuteQueryTable(query);
                int fetchedCount = dt.Rows.Count;
                //MessageBox.Show($"Total rows fetched: {fetchedCount}");

                int hiddenCount = this.gvbProduct.Rows.Cast<DataGridViewRow>().Count(row => !row.Visible);
                



                foreach (DataRow row in dt.Rows)
                {
                    this.gvbProduct.Rows.Add(
                        row["id"].ToString(),
                        row["name"].ToString(),
                        row["category"].ToString(),
                        row["price"].ToString(),
                        row["stock"].ToString(),
                        row["description"].ToString(),
                        row["image_path"].ToString()



                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void lblProductList_Click(object sender, EventArgs e)
        {

        }

        private void gvbProduct_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.deleteToolStripMenuItem.Click += new EventHandler(DeleteProduct);
            this.updateToolStripMenuItem.Click += new EventHandler(UpdateProduct_Click);

            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                gvbProduct.ClearSelection();
                gvbProduct.Rows[e.RowIndex].Selected = true;

                contextMenu.Show(Cursor.Position);
            }


        }

        private void DeleteProduct(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (gvbProduct.SelectedRows.Count == 0) return;

            DataGridViewRow selectedRow = gvbProduct.SelectedRows[0];
            string productId = selectedRow.Cells["productId"].Value.ToString();

            var confirmResult = MessageBox.Show(
                "Are you sure to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                string query = $"DELETE FROM product WHERE id = '{productId}'";

                try
                {
                   int count =  da.ExecuteDMLQuery(query);
                    gvbProduct.Rows.Remove(selectedRow);
                    if (count > 0)
                    {
                        MessageBox.Show("Product deleted successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting product: " + ex.Message);
                }
            }
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            if (gvbProduct.SelectedRows.Count == 0) return;

            DataGridViewRow selectedRow = gvbProduct.SelectedRows[0];

            string id = selectedRow.Cells["productId"].Value.ToString();
            string name = selectedRow.Cells["productName"].Value.ToString();
            string category = selectedRow.Cells["productCategory"].Value.ToString();
            string price = selectedRow.Cells["productPrice"].Value.ToString();
            string stock = selectedRow.Cells["productStock"].Value.ToString();
            string description = selectedRow.Cells["productDescription"].Value.ToString();
            string imagePath = selectedRow.Cells["productImagePath"].Value.ToString();

            var parentForm = this.FindForm() as AdminForm;

            parentForm.pnlForCUDUser.Controls.Clear();
            var updateControl = new UcUpdateProduct(id, name, category, price, stock, description, imagePath);
            parentForm.pnlForCUDUser.Controls.Add(updateControl);
           // updateControl.Dock = DockStyle.Fill;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim().ToLower();

            try
            {
                // SQL query to filter products by name or category
                string query = $"SELECT id, name, category, price, stock, description FROM product " +
                               $"WHERE name LIKE '%{searchQuery}%' OR category LIKE '%{searchQuery}%'";

                // Executing the query and updating the DataGridView
                DataTable dt = this.Da.ExecuteQueryTable(query);
                gvbProduct.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    gvbProduct.Rows.Add(
                        row["id"].ToString(),
                        row["name"].ToString(),
                        row["category"].ToString(),
                        row["price"].ToString(),
                        row["stock"].ToString(),
                        row["description"].ToString()
                        
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        
        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

      
    }
    

}

