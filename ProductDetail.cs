using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFACRUD;

namespace Project
{
    public partial class ProductDetail : Form
    {
        private Form1 f1;
        private DataAccess daa;
        private int x = 0;
        public ProductDetail()
        {
            InitializeComponent();
        }
        public ProductDetail(Form1 f1) : base()
        {
            InitializeComponent();
            this.f1 = f1;
            this.daa = new DataAccess(); // Initialize the DataAccess object

            // Additional initialization if needed
        }


       /* private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtProductId.Text = string.Empty;
            this.txtProductName.Text = string.Empty;
            this.txtProductPrice.Text = string.Empty;
            this.txtQuantity.Text = string.Empty;
        }*/

       
        private void DataTable()
        {
            try
            {

                var sql = "SELECT * FROM Product;";
                var ds = this.daa.ExecuteQuery(sql);
                this.dgvProductDetail.AutoGenerateColumns = false;
                this.dgvProductDetail.DataSource = ds.Tables[0];
               // this.dgvProductDetail.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }
        private void btnShowTable_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                this.DataTable();
                x++;
            }
            else
            {
                this.dgvProductDetail.DataSource = null;
                x--;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.f1.Visible = true;
        }

       /* private void dgvProductDetail_DoubleClick(object sender, EventArgs e)
        {
            this.txtProductId.Text = this.dgvProductDetail.CurrentRow.Cells[0].Value.ToString();
            this.txtProductName.Text = this.dgvProductDetail.CurrentRow.Cells[1].Value.ToString();
            this.txtProductPrice.Text = this.dgvProductDetail.CurrentRow.Cells[2].Value.ToString();
            this.txtQuantity.Text = this.dgvProductDetail.CurrentRow.Cells[3].Value.ToString();
        }*/

        private void QueryExecution(string sql)
        {
            var ds = this.daa.ExecuteQuery(sql);
            this.dgvProductDetail.AutoGenerateColumns = false;
            this.dgvProductDetail.DataSource = ds.Tables[0];
        }
        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            var sql = "select * from Products where ProductId='"+this.txtProductSearch.Text+"';";
            this.QueryExecution(sql);
            this.dgvProductDetail.ClearSelection();
        }
    }
}
