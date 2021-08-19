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
        public FormProfileSetting()
        {
            this.Da = new DataAccess();
            InitializeComponent();
        }

        public FormProfileSetting(Reserver reserver, string ReserverId, string ReserverName, string ReserverPassword) : this()
        {
            this.FormReserver = reserver;
            this.txtID.Text = ReserverId;
            this.txtName.Text = ReserverName;
            this.txtPassword.Text = ReserverPassword;
        }

        private void FormProfileSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReserver.Show();
        }

        private void SetInformation()
        {

            //this.txtName
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            this.txtPassword.UseSystemPasswordChar = false;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.txtPassword.Enabled = true;
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
    }
}
