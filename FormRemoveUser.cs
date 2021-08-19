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
    public partial class FormRemoveUser : Form
    {
        private Admin FormAdmin { get; set; }
        private DataAccess Da { get; set; }
        public FormRemoveUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        public FormRemoveUser(Admin formAdmin) : this()
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sqlSearch = "select * from UserInfo where UserId = '" + this.txtSearch.Text + "' or UserName = '"+this.txtSearch.Text+"';";
            this.PopulateGridView(sqlSearch);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedUser = this.dgvUserInfo.CurrentRow.Cells[0].Value.ToString();
                string sql = "DELETE FROM UserInfo WHERE UserId = '" + selectedUser + "';";
                int count = this.Da.ExecuteUpdateQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show(selectedUser + " Removed Successfully.");
                    this.PopulateGridView();
                }
                else
                {
                    MessageBox.Show("User did not removed.");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Something Went Wrong. \n\n"+exc);
            }
        }

        private void FormRemoveUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
