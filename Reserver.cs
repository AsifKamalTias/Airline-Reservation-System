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
    public partial class Reserver : Form
    {
        private Signin SignIn { get; set; }
        private string ReserverId{ get; set; }
        private string ReserverName { get; set; }
        private string ReserverDob { get; set; }
        private string ReserverGender { get; set; }
        private string ReserverPassword { get; set; }
        public Reserver()
        {
            InitializeComponent();
        }

        public Reserver(Signin signIn, string reserverId, string reserverName, string reserverDOB, string reserverGender, string reserverPassword) : this()
        {
            this.SignIn = signIn;
            this.ReserverId = reserverId;
            this.ReserverName = reserverName;
            this.ReserverDob = reserverDOB;
            this.ReserverGender = reserverGender;
            this.ReserverPassword = reserverPassword;
            this.lblUsername.Text = "Hello " + this.ReserverName + ",";
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SignIn.Show();
        }

        private void Reserver_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservation reservation = new Reservation(this);
            reservation.Show();
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCancelReservation formCancelReservation = new FormCancelReservation(this);
            formCancelReservation.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProfileSetting formProfileSeting = new FormProfileSetting(this, ReserverId, ReserverName, ReserverPassword);
            formProfileSeting.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReservationHistory reservationHistory = new FormReservationHistory(this);
            reservationHistory.Show();
        }
    }
}
