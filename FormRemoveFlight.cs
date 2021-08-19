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
    public partial class FormRemoveFlight : Form
    {
        private DataAccess Da { get; set; }
        private Admin FormAdmin { get; set; }
        public FormRemoveFlight()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        public FormRemoveFlight(Admin formAdmin):this()
        {
            this.FormAdmin = formAdmin;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin.Show();
        }

        private void FormRemoveFlight_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void txtSearchForRemoveFlight_TextChanged(object sender, EventArgs e)
        {
            string sqlSearch = "select * from FlightInfo where FlightId = '" + this.txtSearchForRemoveFlight.Text + "';";
            this.PopulateGridView(sqlSearch);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            try
            {
                //remove flight
                var selectedFlightId = this.dgvAirlineInfo.CurrentRow.Cells[0].Value.ToString();
                string sql = "DELETE FROM FlightInfo WHERE FlightId = '"+selectedFlightId+"';";
                int count = this.Da.ExecuteUpdateQuery(sql);

                //cancel from reservation details
                string sqlSetStatus = "UPDATE ReservationDetails SET ReservationStatus = 'cancelled' WHERE FlightId = '" + selectedFlightId + "';";
                int countChangeStatus = this.Da.ExecuteUpdateQuery(sqlSetStatus);

                if (count == 1 && countChangeStatus>= 0)
                {
                    MessageBox.Show("Flight Removed Successfully.");
                    this.PopulateGridView();
                }
                else
                {
                    MessageBox.Show("Cannot be removed..");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Something Went Wrong. \n\n" + exc);
            }
        }
    }
}
