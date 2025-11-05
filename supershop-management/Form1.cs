//using SuperShop_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
       // private  Formlogin f1;
        private string id;
        private string name;

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string id,string name):base()
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.lblName.Text = name;
        }


        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SalesReport sale = new SalesReport(this);
            sale.Visible = true;
        }

        private void btnProductInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ProductDetail pd = new ProductDetail(this);
            pd.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEmployeeDetails_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EmployeeDetails ed = new EmployeeDetails(this);
            ed.Visible = true;

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            new Profile(this,id).Show();
        }
    }
}
