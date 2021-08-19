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
        public Admin()
        {
            InitializeComponent();
        }

        public Admin(Signin signIn):this()
        {
            this.SignIn = signIn;
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
    }
}
