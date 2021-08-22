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
    public partial class FormReservationDetail : Form
    {
        private DataAccess Da { get; set; }
        Reservation FormReservation { get; set; }
        public FormReservationDetail()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.AutoGenerateReservationId();
            this.dateTimePickerDateOfFlight.MinDate = DateTime.Now;
        }

        public FormReservationDetail(Reservation fr, string flightId, string pickupPoint, string destination) : this()
        {
            this.FormReservation = fr;
            this.txtFlightId.Text = flightId;
            this.txtPickUpPoint.Text = pickupPoint;
            this.txtDestination.Text = destination;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReservation.Show();
        }

        private void FormReservationDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AutoGenerateReservationId()
        {
            var sql = "select ReservationId from ReservationDetails order by ReservationId desc;";
            DataSet ds = this.Da.ExecuteQuery(sql);

            string previousId = ds.Tables[0].Rows[0]["ReservationId"].ToString();
            string[] temp = previousId.Split("-");
            int num = Convert.ToInt32(temp[1]);
            string newId = "r-" + (++num).ToString();
            this.txtReservationId.Text = newId;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!this.IsInvalidInput() || !VaildateRadioGroupIsChecked(this.radioBtnMale, this.radioBtnFemale))
            {
                MessageBox.Show("Please fill up all information properly");
            }
            else
            {
                //Add to Reservation Details
                string gender;
                if (this.radioBtnMale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }

                try
                {
                    //reserve
                    string sqlAddToReservationDetails = "insert into ReservationDetails values('" + this.txtReservationId.Text + "', 'reserved', '" + this.txtCustomerName.Text + "', '" + this.txtCustomerEmail.Text + "', '" + gender + "', '" + this.dateTimePickerDateOfFlight.Text + "', '" + this.txtPickUpPoint.Text + "', '" + this.txtDestination.Text + "', '" + this.txtFlightId.Text + "');";
                    int countAddToReservedDetails = this.Da.ExecuteUpdateQuery(sqlAddToReservationDetails);

                    //Update Reserved Seat
                    string getPreviousReservedSeat = "select ReservedSeat from FlightInfo where FlightId = '" + this.txtFlightId.Text + "';";
                    DataSet ds = this.Da.ExecuteQuery(getPreviousReservedSeat);
                    string previousReservedSeat = ds.Tables[0].Rows[0]["ReservedSeat"].ToString();
                    int reservedSeat = Int32.Parse(previousReservedSeat) + 1;

                    string sqlUpdateReservedSeat = "UPDATE FlightInfo SET ReservedSeat = " + reservedSeat + " WHERE FlightId = '" + this.txtFlightId.Text + "';";
                    int countUpdateReservedSeat = this.Da.ExecuteUpdateQuery(sqlUpdateReservedSeat);

                    if (countAddToReservedDetails == 1 && countUpdateReservedSeat == 1)
                    {
                        this.Clear();
                        this.Hide();
                        FormReservation.Show();
                        MessageBox.Show(this.txtReservationId.Text + " Reserved Successfully.");

                    }
                    else
                    {
                        MessageBox.Show("Reservation Unsuccessfull.");
                    }
                }

                catch (Exception exc)
                {
                    MessageBox.Show("Something Went Wrong. Exception: " + exc);
                }
                
            }
        }

        private bool IsInvalidInput()
        {
            if(String.IsNullOrEmpty(this.txtCustomerName.Text) || String.IsNullOrEmpty(this.txtCustomerEmail.Text) || String.IsNullOrEmpty(this.dateTimePickerDateOfFlight.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VaildateRadioGroupIsChecked(RadioButton a, RadioButton b)
        {
            if (!a.Checked && !b.Checked)
            {
                return false;
            }
            return true;
        }

        private void Clear()
        {
            this.txtCustomerName.Clear();
            this.txtCustomerEmail.Clear();
            this.radioBtnMale.Checked = false;
            this.radioBtnFemale.Checked = false;
        }
    }
}
