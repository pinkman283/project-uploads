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
    public partial class FormAddQuantity : Form
    {
        private DataAccess Da { get; set; }
        private string name;
        private double price;
        private int quantity;
        private string id;
        public string Id { get; set; }
        private FormSelectProduct Fs {get;set;}
        public string Name { get; set; }
        public double Price { get; set; }

        public int Quantity { get; set; }   
        public FormAddQuantity()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public FormAddQuantity(string id,string name,double price,int Quan,FormSelectProduct fs) : this()
        {
            this.Id = id;
            this.Fs = fs;
            this.Name = name;
            this.Price = price;
            this.Quantity = Quan;
            lblQuan.Text += Quan.ToString();
        }
        private void txtQuan_Enter(object sender, EventArgs e)
        {
            txtQuan.Text = "";
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            int q = System.Convert.ToInt32(txtQuan.Text);
            if(q <=0 || q>this.Quantity)
            {
                MessageBox.Show("Pleas Input Valid Quantity");

            }
            else
            {
                try
                {
                    double total = this.Price*q;
                    var sql = "Insert Into Cart values('"+this.Name+"', "+this.Price+","+this.txtQuan.Text+","+total+");";
                     int cnt = this.Da.ExecuteDMLQuery(sql);

                    if (cnt == 1) MessageBox.Show("Product Added To Cart");
                    this.Quantity -= q;
                    var sql1 = "Update Product set Quantity= "+this.Quantity+" where ProductId='"+this.Id+"';";
                    this.Da.ExecuteDMLQuery(sql1);

                    this.Fs.PopulateGridView();
                    this.Close();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Error");
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
