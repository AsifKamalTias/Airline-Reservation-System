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
    public partial class Admin : Form
    {
        private Signin SignIn { get; set; }
        private string AdminId { get; set; }
        private string AdminName { get; set; }
        private string AdminDob { get; set; }
        private string AdminGender { get; set; }
        private string AdminPassword { get; set; }
        public Admin()
        {
            InitializeComponent();
        }

        public Admin(Signin signIn, string adminId, string adminName, string adminDOB, string adminGender, string adminPassword) :this()
        {
            this.SignIn = signIn;
            this.AdminId = adminId;
            this.AdminName = adminName;
            this.AdminDob = adminDOB;
            this.AdminGender = adminGender;
            this.AdminPassword = adminPassword;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SignIn.Show();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReservationDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReservationHistory formReservationHistory= new FormReservationHistory(this);
            formReservationHistory.Show();
        }

        private void btnViewFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormViewFlights formViewFlights = new FormViewFlights(this);
            formViewFlights.Show();
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddFlight formAddFlight = new FormAddFlight(this);
            formAddFlight.Show();
        }

        private void btnRemovePlane_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRemoveFlight formRemoveFLight = new FormRemoveFlight(this);
            formRemoveFLight.Show();
        }

        private void btnEditPlaneDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEditFlight formEditFlight = new FormEditFlight(this);
            formEditFlight.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddUser formAddUser = new FormAddUser(this);
            formAddUser.Show();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRemoveUser formRemoveUser = new FormRemoveUser(this);
            formRemoveUser.Show();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormViewUser formViewUser = new FormViewUser(this);
            formViewUser.Show();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEditUser formEditUser = new FormEditUser(this);
            formEditUser.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProfileSetting formProfileSetting = new FormProfileSetting(this, AdminId, AdminName, AdminPassword);
            //FormAdminProfileSettting fromAdminProfileSetting = new FormAdminProfileSettting(this, AdminId, AdminName, AdminPassword);
            formProfileSetting.Show();
        }
    }
}
