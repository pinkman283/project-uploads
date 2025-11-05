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
    
    public partial class SalesReport : Form
    {
        private Form1 f1;
        private DataAccess daa;
        private int x = 0;
        public SalesReport()
        {
            InitializeComponent();
        }
        public SalesReport(Form1 f1) : base()
        {
            InitializeComponent();
            this.f1 = f1;
            this.daa = new DataAccess();
           // this.DataTable();
        }
        private void DataTable()
        {
            try
            {

                var sql = "select * from SalesReport;";
                var ds = this.daa.ExecuteQuery(sql);
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = ds.Tables[0];
                this.dataGridView1.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.f1.Visible=true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                this.DataTable();
                x++;
            }
            else
            {
                this.dataGridView1.DataSource = null;
                x--;
            }
        }
    }
}
