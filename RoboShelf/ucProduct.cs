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
    public partial class ucProduct : UserControl
    {

        
        public ucProduct()
        {
            InitializeComponent();
            LoadProductData();


        }


        public void LoadProductData()
        {
            //this.gvbProduct.AllowUserToAddRows = false;
            //this.gvbProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //this.gvbProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            DataAccess da = new DataAccess();
            try
            {
                string query = "SELECT id,name, category, price, stock FROM product"; // Change 'employee' to your actual table name
                DataTable dt = da.ExecuteQueryTable(query);
                int fetchedCount = dt.Rows.Count;
                MessageBox.Show($"Total rows fetched: {fetchedCount}");

                int hiddenCount = this.gvbProduct.Rows.Cast<DataGridViewRow>().Count(row => !row.Visible);
                MessageBox.Show($"Hidden rows: {hiddenCount}");



                foreach (DataRow row in dt.Rows)
                {
                    this.gvbProduct.Rows.Add(
                        row["id"].ToString(),
                        row["name"].ToString(),
                        row["category"].ToString(),
                        row["price"].ToString(),
                        row["stock"].ToString()
                       


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
            string productId = selectedRow.Cells["id"].Value.ToString();

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
    }
}
