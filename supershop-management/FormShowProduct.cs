using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFACRUDDB;

namespace SuperShop_Management
{
    public partial class FormShowProduct : Form
    {
        DataAccess Da { get; set; }
        public FormShowProduct()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        private void PopulateGridView(string sql = "Select * from Product")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);


            this.dgvShowProduct.AutoGenerateColumns = false;
            this.dgvShowProduct.DataSource = ds.Tables[0];
        }
        private void ShowDetails()
        {
            string sql = "Select * from Product;";
           this.PopulateGridView(sql);

        }

        private void btncBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            this.txtSearch.Text = "";
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //search button
            string sql = "Select * from Product where ProductName like '"+this.txtSearch.Text+"%';";
            this.PopulateGridView(sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.dgvShowProduct.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please Select a Row First!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }
                DialogResult result = MessageBox.Show("Are You Sure You Want To Delete this Product", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;
                var id = this.dgvShowProduct.CurrentRow.Cells[0].Value.ToString();
                var sql = "delete from Product where ProductId = '" + id + "';";
                int cnt = this.Da.ExecuteDMLQuery(sql);

                if (cnt == 1)
                    MessageBox.Show("Product Deleted");
                else
                    MessageBox.Show("Something Error");

                this.PopulateGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something Error!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormShowProduct_Load(object sender, EventArgs e)
        {
            this.dgvShowProduct.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvShowProduct.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please Select a Row First!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            var id = this.dgvShowProduct.CurrentRow.Cells[0].Value.ToString();
            var name = this.dgvShowProduct.CurrentRow.Cells[1].Value.ToString();
            var price = this.dgvShowProduct.CurrentRow.Cells[2].Value.ToString();
            var quan = this.dgvShowProduct.CurrentRow.Cells[3].Value.ToString();
            this.Close();
            new FormUpdate(id, name, price, quan,this).Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //show
            this.PopulateGridView();
        }
    }
}
