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
    public partial class FormProfileDetails : Form
    {
        public DataAccess Da { get; set; }
        FormEmployee Fe {  get; set; }
        public FormProfileDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.lblTime.Text = DateTime.Now.ToString();
        }
        public FormProfileDetails(string id,FormEmployee fe) : this()
        {
            this.Fe = fe;
            this.ShowDetails(id);
        }
        public void ShowDetails(string id)
        {
            try
            {
                txtUserId.Text = id;
                string sql = "select * from UserInfo where UserId='" + txtUserId.Text + "';";
                DataSet ds = this.Da.ExecuteQuery(sql);
                txtPass.Text = ds.Tables[0].Rows[0][1].ToString();
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtSalary.Text = ds.Tables[0].Rows[0][4].ToString();
                txtOver.Text = ds.Tables[0].Rows[0][5].ToString();
                txtPhone.Text = ds.Tables[0].Rows[0][7].ToString();


            }
            catch(Exception ex) 
            {
                MessageBox.Show("Something Error");
            }
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.txtPass.UseSystemPasswordChar = false;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.txtPass.UseSystemPasswordChar = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Fe.Visible = true;
        }
    }
}
