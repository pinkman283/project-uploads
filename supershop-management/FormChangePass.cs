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
    public partial class FormChangePass : Form
    {
        private DataAccess Da { get; set; }
        private string Id { get;set; }
        public FormChangePass()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public FormChangePass(String id) : this()
            {
                this.Id = id;
            }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtNp1.Text.ToString()== txtNp2.Text.ToString())
            {
                string sql = "Update UserInfo set Password = '"+this.txtNp1.Text+"' where UserId='"+this.Id+"';";
                int cnt = this.Da.ExecuteDMLQuery(sql);
                if (cnt == 1)
                    MessageBox.Show("Password Changed");
                else
                    MessageBox.Show("Password Not Changed");
            }
            else
            {
                MessageBox.Show("Password Doesn't Match");
            }
        }

        private void btnclose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNp2_Enter(object sender, EventArgs e)
        {
            txtNp2.Text = "";
        }
    }
}
