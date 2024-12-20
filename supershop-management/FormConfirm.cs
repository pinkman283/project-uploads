using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFACRUDDB;

namespace SuperShop_Management
{
    
    public partial class Formconfirm : Form
    {
        DataAccess Da { get; set; }
        public Formconfirm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.CalculateToal();
        }
        private void CalculateToal()
        {
            var sql = "SELECT SUM(Total) FROM Cart";
            DataSet ds = this.Da.ExecuteQuery(sql);
            txtTotal.Text = ds.Tables[0].Rows[0][0].ToString();
        }
        public Formconfirm(int x) : this()
        {
            this.btnConfirm.Visible = false;
        }
        public Formconfirm(string x) : this()
        {
            this.btnCancel.Visible = false;
        }
        private void ClearTable()
        {
            try
            {
                var sql = "DELETE FROM Cart";
                int cnt = this.Da.ExecuteDMLQuery(sql);
                if(cnt>=1)
                {
                    MessageBox.Show("All Selected Product Has Been Removed");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
            
        }
        private void PopulateGridView(string sql = "Select * from Cart")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvShowProduct.AutoGenerateColumns = false;
            this.dgvShowProduct.DataSource = ds.Tables[0];
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaction Successfull");
            this.ClearTable();
            this.Close();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormConfirm_Load(object sender, EventArgs e)
        {
            this.dgvShowProduct.ClearSelection();
        }

        private void dgvShowProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
