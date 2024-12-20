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
    public partial class FormAddProduct : Form
    {
        private DataAccess Da {  get; set; }
        FormEmployee Fe { get; set; }
        public FormAddProduct()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.AutoGenerateId();
        }
        public FormAddProduct(FormEmployee fe) : this()
        {
            this.Fe = fe;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Fe.Visible = true;
        }
        private void AutoGenerateId()
        {
            var sql = "select ProductId from Product order by ProductId desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            string oldid = dt.Rows[0][0].ToString();
            string[] temp = oldid.Split('-');
            int num = Convert.ToInt32(temp[1]);
            string newId = "p-" + (++num).ToString("d3");
            this.txtProductId.Text = newId;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.txtPName.Text == "")
                    MessageBox.Show("Product Name Can't Be Empty");
                else if (System.Convert.ToDouble(this.txtPPrice.Text) < 0)
                    MessageBox.Show("Product Price Can't Be Negative Value");
                else if (System.Convert.ToInt32(this.txtPQuan.Text) < 0)
                    MessageBox.Show("Product Quantity Can't Be Negative Value");
                else
                {
                    var sql = "INSERT INTO Product values('" + this.txtProductId.Text + "', '" + this.txtPName.Text + "', " + this.txtPPrice.Text + ", " + this.txtPQuan.Text + ");";
                    int cnt = this.Da.ExecuteDMLQuery(sql);
                    if (cnt == 1) MessageBox.Show("Ok");
                    this.AutoGenerateId();
                    this.txtPQuan.Text = "";
                    this.txtPName.Text = "";
                    this.txtPPrice.Text = "";
                }


            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error");
            }
            
        }

        
    }
}
