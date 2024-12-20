using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFACRUD;

namespace Project
{
    public partial class Profile : Form
    {
        private string id;
        private DataAccess daa;
        private Form1 f1;
        public Profile()
        {
            InitializeComponent();
        }
        public Profile(Form1 f1, string id):base()
        {
            InitializeComponent();
            this.f1 = f1;
            this.id = id;
            this.daa = new DataAccess();
            this.executequery();
        }
        private void executequery()
        {
            try
            {
                this.txtUserId.Text = this.id;
                var sql = "select * from UserInfo where UserId='" + this.txtUserId.Text.Trim() + "';";

                DataSet ds = this.daa.ExecuteQuery(sql);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    
                    this.lblName2.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                    this.lblPassword.Text = ds.Tables[0].Rows[0]["Password"].ToString();
                    this.lblSalary.Text = ds.Tables[0].Rows[0]["Salary"].ToString();
                }
                else
                {
                    MessageBox.Show("No row found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("There is an error!",ex.Message);
            }
        }

        private void txtEnterNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.txtEnterNewPassword.Visible = true;
            this.btnOk.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are You Sure? ", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if (dg == DialogResult.Yes)
                {
                    this.daa = new DataAccess();
                    var sql = "update UserInfo set Password='" + this.txtEnterNewPassword.Text + "' where UserId='" + this.id + "';";
                    var da = this.daa.ExecuteDMLQuery(sql);
                    if (da == 1)
                    {
                        MessageBox.Show("Password Changed");
                    }
                    else MessageBox.Show("Error!");
                }
                else
                {
                    MessageBox.Show("Password Unchanged");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured", ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.f1.Visible = true;
        }
    }
}
