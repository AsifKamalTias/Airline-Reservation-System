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
    public partial class FormCancelReservation : Form
    {
        private DataAccess Da { get; set; }
        private Reserver FormReserver { get; set; }
        public FormCancelReservation()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        public FormCancelReservation(Reserver reserver) : this()
        {
            this.FormReserver = reserver;
        }

        private void PopulateGridView(string sql = "select * from ReservationDetails;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvReservationList.AutoGenerateColumns = false;
            this.dgvReservationList.DataSource = ds.Tables[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void FormCancelReservation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Clear();
            this.PopulateGridView();
            this.Hide();
            FormReserver.Show();
        }

        private void Clear()
        {
            this.txtSearchByReservationID.Clear();
            this.txtSearch.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var currentReservationStatus = this.dgvReservationList.CurrentRow.Cells[1].Value.ToString();
                
                if (currentReservationStatus.Equals("cancelled"))
                {
                    MessageBox.Show("Reservation already cancelled");
                }

                else
                {
                    var selectedReservationId = this.dgvReservationList.CurrentRow.Cells[0].Value.ToString();
                    string sqlSetStatus = "UPDATE ReservationDetails SET ReservationStatus = 'cancelled' WHERE ReservationId = '" + selectedReservationId + "';";
                    int countChangeStatus = this.Da.ExecuteUpdateQuery(sqlSetStatus);

                    var selectedFlightId = this.dgvReservationList.CurrentRow.Cells[8].Value.ToString();
                    string getPreviousReservedSeat = "select ReservedSeat from FlightInfo where FlightId = '" + selectedFlightId + "';";
                    DataSet ds = this.Da.ExecuteQuery(getPreviousReservedSeat);
                    string previousReservedSeat = ds.Tables[0].Rows[0]["ReservedSeat"].ToString();
                    int reservedSeat = Int32.Parse(previousReservedSeat) - 1;

                    string sqlUpdateReservedSeat = "UPDATE FlightInfo SET ReservedSeat = " + reservedSeat + " WHERE FlightId = '" + selectedFlightId + "';";
                    int countUpdateReservedSeat = this.Da.ExecuteUpdateQuery(sqlUpdateReservedSeat);

                    if (countChangeStatus == 1 && countUpdateReservedSeat == 1)
                    {
                        MessageBox.Show(selectedReservationId + ": Resevation Cancelled");
                        this.PopulateGridView();
                    }
                    else
                    {
                        MessageBox.Show("Cancellation Unsuccessful");
                    }
                }
                
            }
            catch(Exception exc)
            {
                MessageBox.Show("Something Went Wrong. " + exc);
            }

        }

        private void txtSearchByReservationID_TextChanged(object sender, EventArgs e)
        {
            string sqlSearch = "select * from ReservationDetails where ReservationId like '" + this.txtSearchByReservationID.Text + "%';";
            this.PopulateGridView(sqlSearch);
        }

        private void txtSeatxhByEmail_TextChanged(object sender, EventArgs e)
        {
            string sqlSearch = "select * from ReservationDetails where CustomerEmail like '" + this.txtSearch.Text + "%' or CustomerName like '"+this.txtSearch.Text+"%';";
            this.PopulateGridView(sqlSearch);
        }
    }
}
