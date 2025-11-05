using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFACRUD;

namespace Project
{
    public partial class EmployeeDetails : Form
    {
        private Form1 f1;
        private int x = 0;
        private DataAccess daa;
        public EmployeeDetails()
        {
            InitializeComponent();
        }
        public EmployeeDetails(Form1 f1):base()
        {
            InitializeComponent();
            this.f1 = f1;
            this.daa = new DataAccess();
            this.AutoGenerateId();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void DataTable()
        {
            try
            {

                var sql = "select * from UserInfo where Role='Employee';";
                var ds = this.daa.ExecuteQuery(sql);
                this.dgvEmployeeDetail.AutoGenerateColumns = false;
                this.dgvEmployeeDetail.DataSource = ds.Tables[0];
                this.dgvEmployeeDetail.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }
        private void btnShowTable_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                this.DataTable();
                x++;
            }
            else
            {
                this.dgvEmployeeDetail.DataSource = null;
                x--;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.f1.Visible = true;
        }
        private void QueryExecution(string sql)
        {
            var ds = this.daa.ExecuteQuery(sql);
            this.dgvEmployeeDetail.AutoGenerateColumns = false;
            this.dgvEmployeeDetail.DataSource = ds.Tables[0];
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var sql = "select * from UserInfo where UserId='"+this.txtSearch.Text+"' and Role='Employee';";
            this.QueryExecution(sql);
            this.dgvEmployeeDetail.ClearSelection();
        }

        private void dgvEmployeeDetail_DoubleClick(object sender, EventArgs e)
        {
            this.txtUserId.Text = this.dgvEmployeeDetail.CurrentRow.Cells[0].Value.ToString();
            this.txtUserName.Text = this.dgvEmployeeDetail.CurrentRow.Cells[1].Value.ToString();
            this.txtPassword.Text = this.dgvEmployeeDetail.CurrentRow.Cells[2].Value.ToString();
            this.txtEmployeeSalary.Text = this.dgvEmployeeDetail.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUserId.Clear();
            this.txtUserName.Clear();
            this.txtPassword.Clear();
            this.txtEmployeeSalary.Clear();
            this.AutoGenerateId();
        }
        private bool IsSaveValid()
        {
            if (string.IsNullOrEmpty(this.txtUserId.Text) || string.IsNullOrEmpty(this.txtUserName.Text) ||
                string.IsNullOrEmpty(this.txtPassword.Text) || string.IsNullOrEmpty(this.txtEmployeeSalary.Text))
            {
                return false;
            }
            else return true;
        }
        private void AutoGenerateId()
        {
            var sql = "select UserId from UserInfo order by UserId desc;";
            var dt = this.daa.ExecuteQueryTable(sql);
            string oldid = dt.Rows[0][0].ToString();
            string[] temp = oldid.Split('-');
            int num = Convert.ToInt32(temp[1]);
            string newId = "u-" + (++num).ToString("d3");
            this.txtUserId.Text = newId;
        }
        private void clr()
        {
            this.txtUserId.Clear();
            this.txtUserName.Clear();
            this.txtPassword.Clear();
            this.txtEmployeeSalary.Clear();
            this.dgvEmployeeDetail.ClearSelection();
            this.txtSearch.Clear();
            this.AutoGenerateId();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsSaveValid())
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                var query = "select * from UserInfo where UserId='" + this.txtUserId.Text + "';";
                var dss = this.daa.ExecuteQuery(query);
                if (dss.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update UserInfo set Name='" + this.txtUserName.Text + @"',
                              Password='" + this.txtPassword.Text + @"',
                             
                              Salary='" + this.txtEmployeeSalary.Text + @"'
                               where UserId='" + this.txtUserId.Text + "';";
                    int count = this.daa.ExecuteDMLQuery(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Data Updated");
                        string s = "select * from UserInfo where Role='Employee';";
                        this.QueryExecution(s);
                        this.clr();
                        this.dgvEmployeeDetail.ClearSelection();
                        this.AutoGenerateId();

                    }
                    else MessageBox.Show("Data Update Failed");

                }
                else {
                    int sal = Convert.ToInt32(this.txtEmployeeSalary.Text);
                    if (sal < 0) {
                        MessageBox.Show("Please Enter valid salary", "Alert");
                        return;
                    }
                    var sql = "insert into UserInfo values('"+this.txtUserId.Text+"','"+this.txtPassword.Text+"','"+this.txtUserName.Text+"','Employee',"+sal+",'0','"+sal+"','-');";
                    int count = this.daa.ExecuteDMLQuery(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Data Added");
                        string s = "select * from UserInfo where Role='Employee';";
                        this.QueryExecution(s);
                        this.dgvEmployeeDetail.ClearSelection();
                        this.clr();
                        this.AutoGenerateId();

                    }
                    else MessageBox.Show("Data Additon failed");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured", ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvEmployeeDetail.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select an item first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult dg = MessageBox.Show("Are you sure want to delete?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dg == DialogResult.No) return;

                var id = this.dgvEmployeeDetail.CurrentRow.Cells[0].Value.ToString();
                var nam = this.dgvEmployeeDetail.CurrentRow.Cells[2].Value.ToString();
                var sql = "delete from UserInfo where UserId='" + id + "'";
                int count = this.daa.ExecuteDMLQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show(nam.ToUpper() + " Has been deleted");
                    string s = "select * from UserInfo where Role='Employee';";
                    this.QueryExecution(s);
                    this.dgvEmployeeDetail.ClearSelection();
                    this.clr();
                    this.AutoGenerateId();

                }
                else MessageBox.Show("Data Deletion failed");
            }
            catch (Exception exp)
            {
                MessageBox.Show("There is an error" + exp.ToString());
            }
        }

      /*  private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           txtSearch.Text = string.Empty;
        }*/
      
      


        /* private void txtSearch_TextChanged(object sender, EventArgs e)
         {

         }*/

    }
}
