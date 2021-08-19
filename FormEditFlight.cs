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
    public partial class FormEditFlight : Form
    {
        private DataAccess Da { get; set; }
        private Admin FormAdmin { get; set; }
        public FormEditFlight()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        public FormEditFlight(Admin formAdmin) : this()
        {
            this.FormAdmin = formAdmin;
        }

        private void PopulateGridView(string sql = "select * from FlightInfo;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);
                this.dgvAirlineInfo.AutoGenerateColumns = false;
                this.dgvAirlineInfo.DataSource = ds.Tables[0];
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void dgvAirlineInfo_Click(object sender, EventArgs e)
        {
            this.txtFlightID.Text = this.dgvAirlineInfo.CurrentRow.Cells[0].Value.ToString();
            this.txtFlightName.Text = this.dgvAirlineInfo.CurrentRow.Cells[1].Value.ToString();
            this.comboFlightCategory.Text = this.dgvAirlineInfo.CurrentRow.Cells[2].Value.ToString();
            this.comboStartForm.Text = this.dgvAirlineInfo.CurrentRow.Cells[3].Value.ToString();
            this.comboDestination.Text = this.dgvAirlineInfo.CurrentRow.Cells[4].Value.ToString();
            this.txtPrice.Text = this.dgvAirlineInfo.CurrentRow.Cells[5].Value.ToString();
            this.txtTotalSeat.Text = this.dgvAirlineInfo.CurrentRow.Cells[6].Value.ToString();

        }

        private bool IsInvalidInput()
        {
            if (String.IsNullOrEmpty(this.txtFlightID.Text) || String.IsNullOrEmpty(this.txtFlightName.Text) || String.IsNullOrEmpty(this.txtPrice.Text) || String.IsNullOrEmpty(this.txtTotalSeat.Text) || String.IsNullOrEmpty(this.comboFlightCategory.Text) || String.IsNullOrEmpty(this.comboStartForm.Text) || String.IsNullOrEmpty(this.comboDestination.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsInvalidInput())
            {
                MessageBox.Show("Please fill all the fields properly.");
            }
            else
            {
                try
                {
                    var sql = "UPDATE FlightInfo SET FlightName = '"+this.txtFlightName.Text+"', Category= '"+this.comboFlightCategory.Text+"', Location1 = '"+this.comboStartForm.Text+"', Location2 = '"+this.comboDestination.Text+"', Price = '"+this.txtPrice.Text+"', TotalSeat = '"+this.txtTotalSeat.Text+"' WHERE FlightId = '"+this.txtFlightID.Text+"';";
                    int count = this.Da.ExecuteUpdateQuery(sql);
                    if(count == 1)
                    {
                        MessageBox.Show("Flight information updated.");
                        this.PopulateGridView();
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessfull Update Operation");
                    }
                }
                catch(Exception exc)
                {
                    MessageBox.Show("Something Went Wrong. \n\n" + exc);
                }
            }
        }

        private void FormEditFlight_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
