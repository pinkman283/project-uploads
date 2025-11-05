using Project;
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
    public partial class Formlogin : Form
    {
        public DataAccess Da {  get; set; }
        public Formlogin()
        {
            InitializeComponent();
            txtUserId.TabStop= false;
            txtPassword.TabStop= false;
            this.Da = new DataAccess();
            this.lblTime.Text = DateTime.Now.ToString();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Text = "";
           txtPassword.UseSystemPasswordChar = true;
        }

        private void txtUserId_Enter(object sender, EventArgs e)
        {
            txtUserId.Text = string.Empty;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try 
            {
                string sql = "select * from UserInfo where UserId='" + txtUserId.Text + "' and Password='" + txtPassword.Text + "';";
                DataSet ds = this.Da.ExecuteQuery(sql);
                string name = ds.Tables[0].Rows[0][2].ToString();
                string id = this.txtUserId.Text;
                if (ds.Tables[0].Rows.Count == 1)
                {
                    txtPassword.Text = "Password";
                    txtUserId.Text = "User Id";
                    txtPassword.UseSystemPasswordChar = false;
                    if (ds.Tables[0].Rows[0][3].ToString() == "Employee")
                    {
                        this.Hide();
                        new FormEmployee(ds.Tables[0].Rows[0][0].ToString(),this).Show();
                    }
                    else
                    {
                        this.Hide();
                        new Form1(id, name).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User Id & Password","warning!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error Occur", "warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
