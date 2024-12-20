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
using WFACRUDDB;

namespace SuperShop_Management
{
    public partial class FormSelectProduct : Form
    {
        DataAccess Da {  get; set; }

        public FormSelectProduct()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public void PopulateGridView(string sql = "Select * from Product")
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.ShowDetails();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSelectProduct_Load(object sender, EventArgs e)
        {
            this.dgvShowProduct.ClearSelection();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.dgvShowProduct.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please Select a Row First!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            var id = this.dgvShowProduct.CurrentRow.Cells[0].Value.ToString();
            var name = this.dgvShowProduct.CurrentRow.Cells[1].Value.ToString();
            var price = System.Convert.ToDouble(this.dgvShowProduct.CurrentRow.Cells[2].Value.ToString());
            var quan = System.Convert.ToInt32(this.dgvShowProduct.CurrentRow.Cells[3].Value.ToString());
            new FormAddQuantity(id,name,price,quan,this).Visible = true;

            

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //btn GO to Cart
            try
            {
                string sql = "select * from Cart;";
                DataSet ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No Product Has Been Added");
                    return;
                }
                new Formconfirm(1).Visible=true;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error");
            }
        }

        private void btnCon_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Once You Confim Order You Can't cancel Transaction","Warning",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            string sql = "select * from Cart;";
            DataSet ds = this.Da.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No Product Has Been Added");
                return;
            }
            new Formconfirm("1").Visible = true;
        }

        private void btnCon_MouseEnter(object sender, EventArgs e)
        {
            lblConfirmation.Visible = true;
        }

        private void btnCon_MouseLeave(object sender, EventArgs e)
        {
            lblConfirmation.Visible = false;
        }
    }
}
