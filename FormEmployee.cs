using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop_Management
{
    public partial class FormEmployee : Form
    {
        private Formlogin Fl { get; set; }
        public string Id {  get; set; }
        public FormEmployee()
        {
            InitializeComponent();
            this.lblTime.Text = DateTime.Now.ToString();
        }
        public FormEmployee(string id,Formlogin f1) :this()
        {
            this.lblId.Text += id;
            this.Fl = f1;
            this.Id = id;
            
        }
        private void panel1_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnProfile_MouseHover(object sender, EventArgs e)
        {
            lblprofiledetails.Visible = true;
        }

        private void btnProfile_MouseLeave(object sender, EventArgs e)
        {
            lblprofiledetails.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblproducts_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnaddproduct.Visible = true;
            btnshowproduct.Visible = true;
            btncloseproduct.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            btnaddproduct.Visible = false;
            btnshowproduct.Visible = false;
            btncloseproduct.Visible = false;
        }

        private void button2_MouseHover_1(object sender, EventArgs e)
        {
            lblcart.Visible = true;
        }

        private void btncart_MouseLeave(object sender, EventArgs e)
        {
            lblcart.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormProfileDetails(this.Id, this).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Log Out
            this.Close();
            Fl.Visible = true ;
        }

        private void btnMore_MouseHover(object sender, EventArgs e)
        {
            btnChangePassword.Visible = true;
            btnLogOut.Visible = true;
            btnclose2.Visible = true;
        }

        private void btnclose2_MouseHover(object sender, EventArgs e)
        {
            btnChangePassword.Visible = false;
            btnLogOut.Visible = false;
            btnclose2.Visible=false;
        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FormAddProduct(this).Visible=true;
        }

        private void btnshowproduct_Click(object sender, EventArgs e)
        {
            new FormShowProduct().Visible=true;
        }

        private void btncart_Click(object sender, EventArgs e)
        {
            new FormSelectProduct().Visible=true;
        }

        private void btnshowproduct_MouseHover(object sender, EventArgs e)
        {
            lblAll.Visible=true;
        }

        private void btnshowproduct_MouseLeave(object sender, EventArgs e)
        {
            lblAll.Visible = false;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            new FormChangePass(this.Id).Visible=true;
        }
    }
}
