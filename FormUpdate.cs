using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFACRUDDB;

namespace SuperShop_Management
{
    public partial class FormUpdate : Form
    {
        private DataAccess Da {  get; set; } 
        private FormShowProduct Fs { get; set; }
        public FormUpdate()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public FormUpdate(string id, string name,string price,string quantity,FormShowProduct fs) : this() 
        {
            this.Fs = fs;
            this.txtUpId.Text = id;
            this.txtUpName.Text = name;
            this.txtUpPrice.Text = price;
            this.txtUpQuan.Text = quantity;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {

                string sql = "update Product set ProductName = '"+this.txtUpName.Text + "',Price = " + this.txtUpPrice.Text + ",Quantity = "+ this.txtUpQuan.Text + " where ProductId = '"+this.txtUpId.Text+"';";
                int cnt = this.Da.ExecuteDMLQuery(sql);
                if (cnt == 1)
                    MessageBox.Show("Product Updated");
                else
                    MessageBox.Show("Product Not Updated");
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
