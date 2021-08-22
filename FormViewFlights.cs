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
    public partial class FormViewFlights : Form
    {
        private DataAccess Da { get; set; }
        private Admin FormAdmin { get; set; }
        public FormViewFlights()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        public FormViewFlights(Admin formAdmin):this()
        {
            this.FormAdmin = formAdmin;
            
        }

        private void FormViewFlights_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.FormAdmin.Show();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from FlightInfo where FlightId like '"+this.txtSearch.Text+"%' or FlightName like '"+this.txtSearch.Text+"%';";
            this.PopulateGridView(sql);
        }

        private void comboStartFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from FlightInfo where Location1 = '" + this.comboStartFrom.Text + "';";
            this.PopulateGridView(sql);
        }

        private void comboDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from FlightInfo where Location2 = '" + this.comboDestination.Text + "';";
            this.PopulateGridView(sql);
        }
    }
}
