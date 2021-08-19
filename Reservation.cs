using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Airline_Reservation_System
{
    public partial class Reservation : Form
    {
        private DataAccess Da { get; set; }
        private Reserver R1 { get; set; }

        public Reservation()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        public Reservation(Reserver r1) : this()
        {
            this.R1 = r1;
        }

        private void Reservation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.R1.Show();
        }

        private void PopulateGridView(string sql = "select * from FlightInfo where TotalSeat <> ReservedSeat;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);
                this.dgvAirlineInfo.AutoGenerateColumns = false;
                this.dgvAirlineInfo.DataSource = ds.Tables[0];
            }
            catch(Exception exc)
            {
                MessageBox.Show("Something Went Wrong. \n\n" + exc);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void comboPickUpPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from FlightInfo where Location1 = '" + this.comboPickUpPoint.Text + "' and TotalSeat<> ReservedSeat;";
            this.PopulateGridView(sql);
        }

        private void comboDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from FlightInfo where Location2 = '"+this.comboDestination.Text+"' and TotalSeat<> ReservedSeat;";
            this.PopulateGridView(sql);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var flightId = this.dgvAirlineInfo.CurrentRow.Cells[0].Value.ToString();
            var pickupPoint = this.dgvAirlineInfo.CurrentRow.Cells[3].Value.ToString();
            var destination = this.dgvAirlineInfo.CurrentRow.Cells[4].Value.ToString();
            if (flightId != null)
            {
                this.Hide();
                FormReservationDetail frd = new FormReservationDetail(this, flightId, pickupPoint, destination);
                frd.Show();
            }
            else
            {
                MessageBox.Show("Please select required flight from the list.");
            }
        }

    }
}
