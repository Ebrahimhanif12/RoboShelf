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


         void LoadProductData()
        {
            DataAccess da = new DataAccess();
            try
            {
                string query = "SELECT id,name, category, price, stock FROM product"; // Change 'employee' to your actual table name
                DataTable dt = da.ExecuteQueryTable(query);

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
    }
}
