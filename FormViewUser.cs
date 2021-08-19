using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Reservation_System
{
    public partial class FormViewUser : Form
    {
        private Admin FormAdmin { get; set; }
        private DataAccess Da { get; set; }
        public FormViewUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        public FormViewUser(Admin formAdmin) : this()
        {
            this.FormAdmin = formAdmin;
        }

        private void PopulateGridView(string sql = "select * from UserInfo;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);
                this.dgvUserInfo.AutoGenerateColumns = false;
                this.dgvUserInfo.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Something Went Wrong. \n\n" + exc);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void FormViewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from UserInfo where UserId = '" + this.txtSearch.Text + "' or UserName = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void comboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from UserInfo where Role = '" + this.comboRole.Text + "';";
            this.PopulateGridView(sql);
        }
    }
}
