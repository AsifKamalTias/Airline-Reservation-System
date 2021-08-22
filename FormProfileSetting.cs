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
    public partial class FormProfileSetting : Form
    {
        private DataAccess Da { get; set; }
        private Reserver FormReserver { get; set; }
        private Admin FormAdmin { get; set; }
        private static byte countBack = 0;
        public FormProfileSetting()
        {
            this.Da = new DataAccess();
            InitializeComponent();
        }

        public FormProfileSetting(Reserver formreserver, string rreserverId, string reserverName, string reserverPassword) : this()
        {
            this.FormReserver = formreserver;
            this.txtID.Text = rreserverId;
            this.txtName.Text = reserverName;
            this.txtPassword.Text = reserverPassword;
            countBack = 0;
        }

        public FormProfileSetting(Admin formAdmin, string adminId, string adminName, string adminPassword) : this()
        {
            this.FormAdmin = formAdmin;
            this.txtID.Text = adminId;
            this.txtName.Text = adminName;
            this.txtPassword.Text = adminPassword;
            countBack = 1;
        }

        private void FormProfileSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(countBack == 0)
            {
                this.FormReserver.Show();
            }
            else
            {
                this.FormAdmin.Show();
            }
        }


        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            this.txtPassword.UseSystemPasswordChar = false;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.txtPassword.Enabled = true;
            this.btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var sqlSetPassword = "UPDATE UserInfo SET Password = '"+this.txtPassword.Text+"' WHERE UserId = '"+this.txtID.Text+"';";
            int countChangePassword = this.Da.ExecuteUpdateQuery(sqlSetPassword);

            if(countChangePassword == 1)
            {
                MessageBox.Show("Password Changed");
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxShowPassword.Checked)
            {
                this.txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
